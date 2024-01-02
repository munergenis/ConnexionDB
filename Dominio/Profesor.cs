using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Profesor
    {
        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Email { get; set; }

        public string Nombre { get; set; }

        public string Apellido1 { get; set; }

        public string Apellido2 { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Genero Genero { get; set; }

        public int Telefono { get; set; }

        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        public string UrlImagenPerfil { get; set; }

        public Disciplina Disciplinas { get; set; }

        public Grupo Grupos { get; set; }
    }
}
