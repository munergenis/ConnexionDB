using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Business;

namespace Testing1ConexionesDB
{
    public partial class FrmProfesor : Form
    {
        private List<Profesor> ListaProfesores;

        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            ProfesorBusiness profesores = new ProfesorBusiness();
            ListaProfesores = profesores.List();
            DgvProfesores.DataSource = ListaProfesores;
            DgvProfesores.Columns["UrlImagenPerfil"].Visible = false;

            CargarImagen(ListaProfesores[0].UrlImagenPerfil);
            LblNombre.Text = ListaProfesores[0].Nombre;
            LblApellido.Text = ListaProfesores[0].Apellido1;
            LblNombreUsuario.Text = ListaProfesores[0].NombreUsuario;
        }

        private void DgvProfesores_SelectionChanged(object sender, EventArgs e)
        {
            Profesor seleccionado = (Profesor)DgvProfesores.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagenPerfil);
            LblNombre.Text = seleccionado.Nombre;
            LblApellido.Text = seleccionado.Apellido1;
            LblNombreUsuario.Text = seleccionado.NombreUsuario;
        }

        private void CargarImagen(string url)
        {
            try
            {
                PbxFotoPerfil.Load(url);
            }
            catch (Exception)
            {
                PbxFotoPerfil.Load("https://likeadream.cat/wp-content/uploads/2020/01/cropped-AAFF-Logo-LikeADream-granate.png");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevoProfesor frmNuevoProfesor = new FrmNuevoProfesor();
            frmNuevoProfesor.ShowDialog();
        }
    }
}
