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
                    "Apellido2, FechaNacimiento, GE.Genero as Genero, Telefono, Direccion, " +
                    "Ciudad, UrlImagenPerfil, D.Disciplina as Disciplinas, GR.Grupo as Grupos " +
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
                    aux.Genero.Descripcion = (string)dataAccess.Reader["Genero"];
                    aux.Telefono = (int)dataAccess.Reader["Telefono"];
                    aux.Direccion = (string)dataAccess.Reader["Direccion"];
                    aux.Ciudad = (string)dataAccess.Reader["Ciudad"];
                    if (!(dataAccess.Reader["UrlImagenPerfil"] is DBNull))
                        aux.UrlImagenPerfil = (string)dataAccess.Reader["urlImagenPerfil"];
                    aux.Disciplinas = new Disciplina();
                    aux.Disciplinas.Descripcion = (string)dataAccess.Reader["Disciplinas"];
                    aux.Grupos = new Grupo();
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

            string queryString = $"INSERT INTO TESTING_PROFESORES (NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento, IdGenero, Telefono, Direccion, Ciudad, UrlImagenPerfil, IdDisciplinas, IdGrupos) VALUES ('{nuevoProfesor.NombreUsuario}', '{nuevoProfesor.Contraseña}', '{nuevoProfesor.Email}', '{nuevoProfesor.Nombre}', '{nuevoProfesor.Apellido1}', '{nuevoProfesor.Apellido2}', '{nuevoProfesor.FechaNacimiento}', @IdGenero, {nuevoProfesor.Telefono}, '{nuevoProfesor.Direccion}', '{nuevoProfesor.Ciudad}', @UrlImagenPerfil, @IdDisciplina, @IdGrupo)";

            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.SetCommandParameters("@IdGenero", nuevoProfesor.Genero.Id);
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

        }
    }
}