using System;
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

            string queryString = "SELECT A.Id as Id, NombreUsuario, Contraseña, Email, Nombre, Apellido1, Apellido2, FechaNacimiento, GE.Genero as Genero, Telefono, Direccion, Ciudad, UrlImagenPerfil, D.Disciplina as Disciplina, GR.Grupo as Grupo FROM TESTING_ALUMNOS A, TESTING_GENEROS GE, TESTING_DISCIPLINAS D, TESTING_GRUPOS GR WHERE A.IdGenero = GE.Id AND A.IdDisciplinas = D.Id AND A.IdGrupos = GR.Id";
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
                    aux.Genero.Descripcion = (string)dataAccess.Reader["Genero"];
                    aux.Telefono = (int)dataAccess.Reader["Telefono"];
                    aux.Direccion = (string)dataAccess.Reader["Direccion"];
                    aux.Ciudad = (string)dataAccess.Reader["Ciudad"];
                    aux.UrlImagenPerfil = (string)dataAccess.Reader["UrlImagenPerfil"];
                    aux.Disciplina = new Disciplina();
                    aux.Disciplina.Descripcion = (string)dataAccess.Reader["Disciplina"];
                    aux.Grupo = new Grupo();
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
    }
}
