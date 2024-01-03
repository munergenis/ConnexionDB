using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class GeneroBusiness
    {
        public List<Genero> List()
        {
            List<Genero> listGenero = new List<Genero>();
            DataAccess dataAccess = new DataAccess();

            string queryString = "SELECT Id, Genero FROM TESTING_GENEROS";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();

                while (dataAccess.Reader.Read())
                {
                    Genero aux = new Genero();
                    aux.Id = (int)dataAccess.Reader["Id"];
                    aux.Descripcion = (string)dataAccess.Reader["Genero"];

                    listGenero.Add(aux);
                }

                return listGenero;
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
