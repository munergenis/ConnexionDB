using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class GrupoBusiness
    {
        public List<Grupo> List()
        {
            List<Grupo> listOfGrupo = new List<Grupo>();
            DataAccess dataAccess = new DataAccess();

            string queryString = "SELECT Id, Grupo FROM TESTING_GRUPOS";
            dataAccess.SetQuery(queryString);

            try
            {
                dataAccess.ExecuteQuery();

                while (dataAccess.Reader.Read())
                {
                    Grupo aux = new Grupo();
                    aux.Id = (int)dataAccess.Reader["Id"];
                    aux.Descripcion = (string)dataAccess.Reader["Grupo"];

                    listOfGrupo.Add(aux);
                }

                return listOfGrupo;
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
