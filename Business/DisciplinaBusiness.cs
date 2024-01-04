using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Business
{
    public class DisciplinaBusiness
    {
        public List<Disciplina> List()
        {
			List<Disciplina> listOfDisciplina = new List<Disciplina>();
			DataAccess dataAccess = new DataAccess();

			string queryString = "SELECT Id, Disciplina FROM TESTING_DISCIPLINAS";
			dataAccess.SetQuery(queryString);

			try
			{
				dataAccess.ExecuteQuery();

				while (dataAccess.Reader.Read())
				{
					Disciplina aux = new Disciplina();
					aux.Id = (int)dataAccess.Reader["Id"];
					aux.Descripcion = (string)dataAccess.Reader["Disciplina"];

					listOfDisciplina.Add(aux);
				}

				return listOfDisciplina;
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
