using Business;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing1ConexionesDB
{
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private List<Alumno> listOfAlumnos = new List<Alumno>();

        private AlumnoBusiness alumnoBusiness = new AlumnoBusiness();

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                listOfAlumnos = alumnoBusiness.List();
                DgvAlumnos.DataSource = listOfAlumnos;
                LoadImage(listOfAlumnos[0].UrlImagenPerfil);
                LblNombreUsuario.Text = listOfAlumnos[0].NombreUsuario;
                LblNombre.Text = listOfAlumnos[0].Nombre;
                LblApellido.Text = listOfAlumnos[0].Apellido1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible conectar con la Base de Datos" + ex.ToString());
            }
        }

        private void DgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            Alumno seleccionado = (Alumno)DgvAlumnos.CurrentRow.DataBoundItem;
            LoadImage(seleccionado.UrlImagenPerfil);
            LblNombreUsuario.Text = seleccionado.NombreUsuario;
            LblNombre.Text = seleccionado.Nombre;
            LblApellido.Text = seleccionado.Apellido1;
        }

        private void LoadImage(string urlImagen)
        {
            try
            {
                PbxFotoPerfil.Load(urlImagen);
            }
            catch (Exception)
            {
                PbxFotoPerfil.Load("https://likeadream.cat/wp-content/uploads/2020/01/cropped-AAFF-Logo-LikeADream-granate.png");
            }
        }
    }
}
