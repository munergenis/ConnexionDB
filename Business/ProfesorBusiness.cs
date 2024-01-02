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
                dataAccess.SetQuery("SELECT NombreUsuario, Contraseña, Email, Nombre, Apellido1, " +
                    "Apellido2, FechaNacimiento, GE.Genero as Genero, Telefono, Direccion, " +
                    "Ciudad, UrlImagenPerfil, D.Disciplina as Disciplinas, GR.Grupo as Grupos " +
                    "FROM TESTING_PROFESORES P, TESTING_GENEROS GE, TESTING_DISCIPLINAS D, TESTING_GRUPOS GR " +
                    "WHERE P.IdGenero = GE.Id AND P.IdDisciplinas = D.Id AND P.IdGrupos = GR.Id");
                dataAccess.RunQuery();

                while (dataAccess.Reader.Read())
                {
                    Profesor aux = new Profesor();
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
        

























        //public List<Profesor> Listar()
        //{
        //    List<Profesor> listaProfesores = new List<Profesor> ();
        //    SqlConnection conexion = new SqlConnection ();
        //    SqlCommand comando = new SqlCommand ();
        //    SqlDataReader lector;

        //    try
        //    {
        //        conexion.ConnectionString = "server=.\\SQLEXPRESS; database=TESTING_PROFES_DB; integrated security=true;";
        //        comando.CommandType = System.Data.CommandType.Text;
        //        comando.CommandText = "select NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento, GE.Genero as Genero, Telefono, Direccion, Ciudad, UrlImagenPerfil, D.Disciplina as Disciplinas, GR.Grupo as Grupos from TESTING_PROFESORES P, TESTING_GENEROS GE, TESTING_DISCIPLINAS D, TESTING_GRUPOS GR where P.IdGenero = GE.Id AND P.IdDisciplinas = D.Id AND P.IdGrupos = GR.Id";
        //        comando.Connection = conexion;

        //        conexion.Open ();
        //        lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            Profesor aux = new Profesor();
        //            aux.NombreUsuario = (string)lector["NombreUsuario"];
        //            aux.Contraseña = (string)lector["Contraseña"];
        //            aux.Email = (string)lector["email"];
        //            aux.Nombre = (string)lector["Nombre"];
        //            aux.Apellido1 = (string)lector["Apellido1"];
        //            aux.Apellido2 = (string)lector["Apellido2"];
        //            aux.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
        //            aux.Genero = new Genero ();
        //            aux.Genero.Descripcion = (string)lector["Genero"];
        //            aux.Telefono = (int)lector["Telefono"];
        //            aux.Direccion = (string)lector["Direccion"];
        //            aux.Ciudad = (string)lector["Ciudad"];
        //            aux.UrlImagenPerfil = (string)lector["UrlImagenPerfil"];
        //            aux.Disciplinas = new Disciplina ();
        //            aux.Disciplinas.Descripcion = (string)lector["Disciplinas"];
        //            aux.Grupos = new Grupo();
        //            aux.Grupos.Descripcion = (string)lector["Grupos"];

        //            listaProfesores.Add(aux);
        //        }

        //        return listaProfesores;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally 
        //    { 
        //        conexion.Close (); 
        //    }
        //}
    }
}
