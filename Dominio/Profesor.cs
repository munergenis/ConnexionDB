using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Profesor
    {
        public int Id { get; set; }

        [DisplayName("Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Email { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Primer Apellido")]
        public string Apellido1 { get; set; }

        [DisplayName("Segundo Apellido")]
        public string Apellido2 { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Género")]
        public Genero Genero { get; set; }

        [DisplayName("Teléfono")]
        public int Telefono { get; set; }

        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        public string Ciudad { get; set; }

        [DisplayName("Url Imagen de Perfil")]
        public string UrlImagenPerfil { get; set; }

        public Disciplina Disciplinas { get; set; }

        public Grupo Grupos { get; set; }
    }
}
