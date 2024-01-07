using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Business
{
    public class ProfesorBusiness
    {
        public List<Profesor> List()
        {
            List<Profesor> listOfProfesor = new List<Profesor>();
            DataAccess dataAccess = new DataAccess();

            try
            {
                dataAccess.SetQuery("SELECT P.Id as Id, NombreUsuario, Contraseña, Email, Nombre, Apellido1, " +
                    "Apellido2, FechaNacimiento, P.IdGenero as IdGenero, GE.Genero as Genero, Telefono, Direccion, " +
                    "Ciudad, UrlImagenPerfil, P.IdDisciplinas as IdDisciplina, D.Disciplina as Disciplinas, " +
                    "P.IdGrupos as IdGrupo, GR.Grupo as Grupos " +
                    "FROM TESTING_PROFESORES P, TESTING_GENEROS GE, TESTING_DISCIPLINAS D, TESTING_GRUPOS GR " +
                    "WHERE P.IdGenero = GE.Id AND P.IdDisciplinas = D.Id AND P.IdGrupos = GR.Id");
                dataAccess.ExecuteQuery();

                while (dataAccess.Reader.Read())
                {
                    Profesor aux = new Profesor();
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
                        aux.UrlImagenPerfil = (string)dataAccess.Reader["urlImagenPerfil"];
                    aux.Disciplinas = new Disciplina();
                    aux.Disciplinas.Id = (int)dataAccess.Reader["IdDisciplina"];
                    aux.Disciplinas.Descripcion = (string)dataAccess.Reader["Disciplinas"];
                    aux.Grupos = new Grupo();
                    aux.Grupos.Id = (int)dataAccess.Reader["IdGrupo"];
                    aux.Grupos.Descripcion = (string)dataAccess.Reader["Grupos"];

                    listOfProfesor.Add(aux);
                }

                return listOfProfesor;
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

        public void AgragarProfesor(Profesor nuevoProfesor)
        { 
            DataAccess dataAccess = new DataAccess();

            string queryString = $"INSERT INTO TESTING_PROFESORES (NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento, IdGenero, Telefono, Direccion, Ciudad, UrlImagenPerfil, IdDisciplinas, IdGrupos) VALUES (@NombreUsuario, @Contraseña, @Email, @Nombre, @Apellido1, @Apellido2, @FechaNacimiento, @IdGenero, @Telefono, @Direccion, @Ciudad, @UrlImagenPerfil, @IdDisciplina, @IdGrupo)";

            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.SetCommandParameters("@NombreUsuario", nuevoProfesor.NombreUsuario);
                dataAccess.SetCommandParameters("@Contraseña", nuevoProfesor.Contraseña);
                dataAccess.SetCommandParameters("@Email", nuevoProfesor.Email);
                dataAccess.SetCommandParameters("@Nombre", nuevoProfesor.Nombre);
                dataAccess.SetCommandParameters("@Apellido1", nuevoProfesor.Apellido1);
                dataAccess.SetCommandParameters("@Apellido2", nuevoProfesor.Apellido2);
                dataAccess.SetCommandParameters("@FechaNacimiento", nuevoProfesor.FechaNacimiento);
                dataAccess.SetCommandParameters("@IdGenero", nuevoProfesor.Genero.Id);
                dataAccess.SetCommandParameters("@Telefono", nuevoProfesor.Telefono);
                dataAccess.SetCommandParameters("@Direccion", nuevoProfesor.Direccion);
                dataAccess.SetCommandParameters("@Ciudad", nuevoProfesor.Ciudad);
                dataAccess.SetCommandParameters("@UrlImagenPerfil", nuevoProfesor.UrlImagenPerfil);
                dataAccess.SetCommandParameters("@IdDisciplina", nuevoProfesor.Disciplinas.Id);
                dataAccess.SetCommandParameters("@IdGrupo", nuevoProfesor.Grupos.Id);

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

        public void ModificarProfesor(Profesor profesorModificar)
        {
            DataAccess dataAccess = new DataAccess();

            string queryString = "UPDATE TESTING_PROFESORES SET NombreUsuario = @NombreUsuario, " +
                "Contraseña = @Contraseña, Email = @Email, Nombre = @Nombre, Apellido1 = @Apellido1, " +
                "Apellido2 = @Apellido2, FechaNacimiento = @FechaNacimiento, IdGenero = @IdGenero, " +
                "Telefono = @Telefono, Direccion = @Direccion, Ciudad = @Ciudad, UrlImagenPerfil = @UrlImagenPerfil, " +
                "IdDisciplinas = @IdDisciplina, IdGrupos = @IdGrupo WHERE Id = @Id";

            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.SetCommandParameters("@NombreUsuario", profesorModificar.NombreUsuario);
                dataAccess.SetCommandParameters("@Contraseña", profesorModificar.Contraseña);
                dataAccess.SetCommandParameters("@Email", profesorModificar.Email);
                dataAccess.SetCommandParameters("@Nombre", profesorModificar.Nombre);
                dataAccess.SetCommandParameters("@Apellido1", profesorModificar.Apellido1);
                dataAccess.SetCommandParameters("@Apellido2", profesorModificar.Apellido2);
                dataAccess.SetCommandParameters("@FechaNacimiento", profesorModificar.FechaNacimiento);
                dataAccess.SetCommandParameters("@IdGenero", profesorModificar.Genero.Id);
                dataAccess.SetCommandParameters("@Telefono", profesorModificar.Telefono);
                dataAccess.SetCommandParameters("@Direccion", profesorModificar.Direccion);
                dataAccess.SetCommandParameters("@Ciudad", profesorModificar.Ciudad);
                dataAccess.SetCommandParameters("@UrlImagenPerfil", profesorModificar.UrlImagenPerfil);
                dataAccess.SetCommandParameters("@IdDisciplina", profesorModificar.Disciplinas.Id);
                dataAccess.SetCommandParameters("@IdGrupo", profesorModificar.Grupos.Id);
                dataAccess.SetCommandParameters("@Id", profesorModificar.Id);

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
    }
}