﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class AlumnoBusiness
    {
        public List<Alumno> List()
        {
            List<Alumno> listOfAlumno = new List<Alumno>();
            DataAccess dataAccess = new DataAccess();

            string queryString = "SELECT A.Id as Id, NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento,A.IdGenero as IdGenero, GE.Genero as Genero, Telefono, Direccion, Ciudad, UrlImagenPerfil, A.IdDisciplinas as IdDisciplina, D.Disciplina as Disciplina, A.IdGrupos as IdGrupo, GR.Grupo as Grupo FROM TESTING_ALUMNOS A, TESTING_GENEROS GE, TESTING_DISCIPLINAS D, TESTING_GRUPOS GR WHERE A.IdGenero = GE.Id AND A.IdDisciplinas = D.Id AND A.IdGrupos = GR.Id AND A.Activo = 1";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();

                while (dataAccess.Reader.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Id = (int)dataAccess.Reader["Id"];
                    aux.NombreUsuario = (string)dataAccess.Reader["NombreUsuario"];
                    aux.Contraseña = (string)dataAccess.Reader["Contraseña"];
                    aux.Email = (string)dataAccess.Reader["Email"];
                    aux.Nombre = (string)dataAccess.Reader["Nombre"];
                    aux.Apellido1 = (string)dataAccess.Reader["Apellido1"];
                    aux.Apellido2 = (string)dataAccess.Reader["Apellido2"];
                    aux.FechaNacimiento = (DateTime)dataAccess.Reader["FechaNacimiento"];
                    aux.Genero = new Genero();
                    aux.Genero.Id = (int)dataAccess.Reader["IdGenero"];
                    aux.Genero.Descripcion = (string)dataAccess.Reader["Genero"];
                    aux.Telefono = (int)dataAccess.Reader["Telefono"];
                    aux.Direccion = (string)dataAccess.Reader["Direccion"];
                    aux.Ciudad = (string)dataAccess.Reader["Ciudad"];
                    if (!(dataAccess.Reader["UrlImagenPerfil"] is DBNull))
                        aux.UrlImagenPerfil = (string)dataAccess.Reader["UrlImagenPerfil"];
                    aux.Disciplina = new Disciplina();
                    aux.Disciplina.Id = (int)dataAccess.Reader["IdDisciplina"];
                    aux.Disciplina.Descripcion = (string)dataAccess.Reader["Disciplina"];
                    aux.Grupo = new Grupo();
                    aux.Grupo.Id = (int)dataAccess.Reader["IdGrupo"];
                    aux.Grupo.Descripcion = (string)dataAccess.Reader["Grupo"];

                    listOfAlumno.Add(aux);
                }

                return listOfAlumno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }

        public void AgregarAlumno(Alumno nuevoAlumno)
        {
            DataAccess dataAccess = new DataAccess();

            string queryString = "INSERT INTO TESTING_ALUMNOS (NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento, IdGenero, Telefono, Direccion, Ciudad, UrlImagenPerfil, IdDisciplinas, IdGrupos) VALUES (@NombreUsuario, @Contraseña, @Email, @Nombre, @Apellido1, @Apellido2, @FechaNacimiento, @IdGenero, @Telefono, @Direccion, @Ciudad, @UrlImagenPerfil, @IdDisciplina, @IdGrupo)";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.SetCommandParameters("@NombreUsuario", nuevoAlumno.NombreUsuario);
                dataAccess.SetCommandParameters("@Contraseña", nuevoAlumno.Contraseña);
                dataAccess.SetCommandParameters("@Email", nuevoAlumno.Email);
                dataAccess.SetCommandParameters("@Nombre", nuevoAlumno.Nombre);
                dataAccess.SetCommandParameters("@Apellido1", nuevoAlumno.Apellido1);
                dataAccess.SetCommandParameters("@Apellido2", nuevoAlumno.Apellido2);
                dataAccess.SetCommandParameters("@FechaNacimiento", nuevoAlumno.FechaNacimiento);
                dataAccess.SetCommandParameters("@IdGenero", nuevoAlumno.Genero.Id);
                dataAccess.SetCommandParameters("@Telefono", nuevoAlumno.Telefono);
                dataAccess.SetCommandParameters("@Direccion", nuevoAlumno.Direccion);
                dataAccess.SetCommandParameters("@Ciudad", nuevoAlumno.Ciudad);
                dataAccess.SetCommandParameters("@UrlImagenPerfil", nuevoAlumno.UrlImagenPerfil);
                dataAccess.SetCommandParameters("@IdDisciplina", nuevoAlumno.Disciplina.Id);
                dataAccess.SetCommandParameters("@IdGrupo", nuevoAlumno.Grupo.Id);

                dataAccess.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }

        public void ModificarAlumno(Alumno alumnoModificar)
        {
            DataAccess dataAccess = new DataAccess();

            string queryString = "UPDATE TESTING_ALUMNOS SET NombreUsuario = @NombreUsuario, " +
                "Contraseña = @Contraseña, Email = @Email, Nombre = @Nombre, Apellido1 = @Apellido1, " +
                "Apellido2 = @Apellido2, FechaNacimiento = @FechaNacimiento, IdGenero = @IdGenero, " +
                "Telefono = @Telefono, Direccion = @Direccion, Ciudad = @Ciudad, " +
                "UrlImagenPerfil = @UrlImagenPerfil, IdDisciplinas = @IdDisciplina, IdGrupos = @IdGrupo " +
                "WHERE Id = @Id";
            dataAccess.SetQuery(queryString);

            dataAccess.SetCommandParameters("@NombreUsuario", alumnoModificar.NombreUsuario);
            dataAccess.SetCommandParameters("@Contraseña", alumnoModificar.Contraseña);
            dataAccess.SetCommandParameters("@Email", alumnoModificar.Email);
            dataAccess.SetCommandParameters("@Nombre", alumnoModificar.Nombre);
            dataAccess.SetCommandParameters("@Apellido1", alumnoModificar.Apellido1);
            dataAccess.SetCommandParameters("@Apellido2", alumnoModificar.Apellido2);
            dataAccess.SetCommandParameters("@FechaNacimiento", alumnoModificar.FechaNacimiento);
            dataAccess.SetCommandParameters("@IdGenero", alumnoModificar.Genero.Id);
            dataAccess.SetCommandParameters("@Telefono", alumnoModificar.Telefono);
            dataAccess.SetCommandParameters("@Direccion", alumnoModificar.Direccion);
            dataAccess.SetCommandParameters("@Ciudad", alumnoModificar.Ciudad);
            dataAccess.SetCommandParameters("@UrlImagenPerfil", alumnoModificar.UrlImagenPerfil);
            dataAccess.SetCommandParameters("@IdDisciplina", alumnoModificar.Disciplina.Id);
            dataAccess.SetCommandParameters("@IdGrupo", alumnoModificar.Grupo.Id);
            dataAccess.SetCommandParameters("@Id", alumnoModificar.Id);

            try
            {
                dataAccess.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }

        public void EliminarFisico(Alumno alumnoEliminar)
        {
            DataAccess dataAccess = new DataAccess();

            string queryString = "DELETE FROM TESTING_ALUMNOS WHERE Id = @Id";
            dataAccess.SetQuery(queryString);

            dataAccess.SetCommandParameters("@Id", alumnoEliminar.Id);

            try
            {
                dataAccess.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                dataAccess.CloseConnection(); 
            }
        }

        public void DeshabilitarAlumno(Alumno alumnoDeshabilitar)
        {
            DataAccess dataAccess = new DataAccess();

            string queryString = "UPDATE TESTING_ALUMNOS SET Activo = 0 WHERE Id = @Id";
            dataAccess.SetQuery(queryString);

            dataAccess.SetCommandParameters("@Id", alumnoDeshabilitar.Id);
            try
            {
                dataAccess.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }

        public List<Alumno> FiltroAvanzado(string campo, string criterio, string texto)
        {
            DataAccess dataAccess = new DataAccess();
            List<Alumno> listaFiltroAvanzado = new List<Alumno>();

            if (campo == "Teléfono")
            {
                campo = "Telefono";

                switch (criterio)
                {
                    case "Mayor a":
                        criterio = ">";
                        break;

                    case "Menor a":
                        criterio = "<";
                        break;

                    default:
                        criterio = "=";
                        break;
                }
            }
            else
            {
                if (campo == "Primer Apellido")
                    campo = "Apellido1";

                switch (criterio)
                {
                    case "Empieza con":
                        texto = $"'{texto}%'";
                        break;

                    case "Termina con":
                        texto = $"'%{texto}'";
                        break;

                    default:
                        texto = $"'%{texto}%'";
                        break;
                }

                criterio = "like";
            }

            string queryString = "SELECT A.Id as Id, NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento,A.IdGenero as IdGenero, GE.Genero as Genero, Telefono, Direccion, Ciudad, UrlImagenPerfil, A.IdDisciplinas as IdDisciplina, D.Disciplina as Disciplina, A.IdGrupos as IdGrupo, GR.Grupo as Grupo FROM TESTING_ALUMNOS A, TESTING_GENEROS GE, TESTING_DISCIPLINAS D, TESTING_GRUPOS GR " +
                "WHERE A.IdGenero = GE.Id " +
                "AND A.IdDisciplinas = D.Id " +
                "AND A.IdGrupos = GR.Id " +
                "AND A.Activo = 1" +
                $"AND {campo} {criterio} {texto}";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();

                while (dataAccess.Reader.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Id = (int)dataAccess.Reader["Id"];
                    aux.NombreUsuario = (string)dataAccess.Reader["NombreUsuario"];
                    aux.Contraseña = (string)dataAccess.Reader["Contraseña"];
                    aux.Email = (string)dataAccess.Reader["Email"];
                    aux.Nombre = (string)dataAccess.Reader["Nombre"];
                    aux.Apellido1 = (string)dataAccess.Reader["Apellido1"];
                    aux.Apellido2 = (string)dataAccess.Reader["Apellido2"];
                    aux.FechaNacimiento = (DateTime)dataAccess.Reader["FechaNacimiento"];
                    aux.Genero = new Genero();
                    aux.Genero.Id = (int)dataAccess.Reader["IdGenero"];
                    aux.Genero.Descripcion = (string)dataAccess.Reader["Genero"];
                    aux.Telefono = (int)dataAccess.Reader["Telefono"];
                    aux.Direccion = (string)dataAccess.Reader["Direccion"];
                    aux.Ciudad = (string)dataAccess.Reader["Ciudad"];
                    if (!(dataAccess.Reader["UrlImagenPerfil"] is DBNull))
                        aux.UrlImagenPerfil = (string)dataAccess.Reader["UrlImagenPerfil"];
                    aux.Disciplina = new Disciplina();
                    aux.Disciplina.Id = (int)dataAccess.Reader["IdDisciplina"];
                    aux.Disciplina.Descripcion = (string)dataAccess.Reader["Disciplina"];
                    aux.Grupo = new Grupo();
                    aux.Grupo.Id = (int)dataAccess.Reader["IdGrupo"];
                    aux.Grupo.Descripcion = (string)dataAccess.Reader["Grupo"];

                    listaFiltroAvanzado.Add(aux);
                }

                return listaFiltroAvanzado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dataAccess.CloseConnection();
            }
        }
    }
}
