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
        private ProfesorBusiness profesores = new ProfesorBusiness();

        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void FrmProfesor_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvProfesores_SelectionChanged(object sender, EventArgs e)
        {
            Profesor seleccionado = (Profesor)DgvProfesores.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagenPerfil);
            LblNombre.Text = seleccionado.Nombre;
            LblApellido.Text = seleccionado.Apellido1;
            LblNombreUsuario.Text = seleccionado.NombreUsuario;
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevoProfesor frmNuevoProfesor = new FrmNuevoProfesor();
            frmNuevoProfesor.ShowDialog();
            LoadData();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Profesor profesorSeleccionado = (Profesor)DgvProfesores.CurrentRow.DataBoundItem;

            FrmNuevoProfesor frmModificarProfesor = new FrmNuevoProfesor(profesorSeleccionado);
            frmModificarProfesor.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                ListaProfesores = profesores.List();
                DgvProfesores.DataSource = ListaProfesores;
                DgvProfesores.Columns["UrlImagenPerfil"].Visible = false;

                CargarImagen(ListaProfesores[0].UrlImagenPerfil);
                LblNombre.Text = ListaProfesores[0].Nombre;
                LblApellido.Text = ListaProfesores[0].Apellido1;
                LblNombreUsuario.Text = ListaProfesores[0].NombreUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha habido un error al cargar la lista: " + ex.ToString());
            }
        }

        private void CargarImagen(string url)
        {
            try
            {
                PbxFotoPerfil.Load(url);
            }
            catch (Exception)
            {
                PbxFotoPerfil.Load("https://th.bing.com/th/id/OIG.B0QdXb93IrIqv0h68bQK?pid=ImgGn");
            }
        }

    }
}
