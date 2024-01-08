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
        private List<Alumno> listOfAlumnos = new List<Alumno>();
        private AlumnoBusiness alumnoBusiness = new AlumnoBusiness();
        
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            Alumno seleccionado = (Alumno)DgvAlumnos.CurrentRow.DataBoundItem;
            LoadImage(seleccionado.UrlImagenPerfil);
            LblNombreUsuario.Text = seleccionado.NombreUsuario;
            LblNombre.Text = seleccionado.Nombre;
            LblApellido.Text = seleccionado.Apellido1;
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmNuevoAlumno frmNuevoAlumno = new FrmNuevoAlumno();
            frmNuevoAlumno.ShowDialog();
            LoadData();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Alumno seleccionado = (Alumno)DgvAlumnos.CurrentRow.DataBoundItem;

            FrmNuevoAlumno frmModificarAlumno = new FrmNuevoAlumno(seleccionado);
            frmModificarAlumno.ShowDialog();
            LoadData();
        }

        private void BtnEliminarFisico_Click(object sender, EventArgs e)
        {
            Alumno seleccionado = (Alumno)DgvAlumnos.CurrentRow.DataBoundItem;

            string text = "El alumno será eliminado PERMANENTEMENTE. ¿Deseas continuar?";
            string caption = "ELIMINAR DEFINITIVAMENTE";
            var button = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Warning;

            var result = MessageBox.Show(text, caption, button, icon);

            try
            {
                if (result == DialogResult.Yes)
                {
                    alumnoBusiness.EliminarFisico(seleccionado);
                    MessageBox.Show("Alumno eliminado", "Eliminado");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar alumno: " + ex.ToString());
            }
        }

        private void LoadData()
        {
            try
            {
                listOfAlumnos = alumnoBusiness.List();
                DgvAlumnos.DataSource = listOfAlumnos;
                DgvAlumnos.Columns["UrlImagenPerfil"].Visible = false;

                LoadImage(listOfAlumnos[0].UrlImagenPerfil);
                LblNombreUsuario.Text = listOfAlumnos[0].NombreUsuario;
                LblNombre.Text = listOfAlumnos[0].Nombre;
                LblApellido.Text = listOfAlumnos[0].Apellido1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha habido un error al cargar la lista: " + ex.ToString());
            }
        }

        private void LoadImage(string urlImagen)
        {
            try
            {
                PbxFotoPerfil.Load(urlImagen);
            }
            catch (Exception)
            {
                PbxFotoPerfil.Load("https://th.bing.com/th/id/OIG.B0QdXb93IrIqv0h68bQK?pid=ImgGn");
            }
        }

        private void BtnDeshabilitar_Click(object sender, EventArgs e)
        {
            Alumno seleccionado = (Alumno)DgvAlumnos.CurrentRow.DataBoundItem;

            string text = "¿Seguro que quieres deshabilitar este alumno?";
            string caption = "Deshabilitar Alumno";
            var buttons =  MessageBoxButtons.YesNo ;
            var icon = MessageBoxIcon.Warning;

            var result = MessageBox.Show(text, caption, buttons, icon);

            try
            {
                if (result == DialogResult.Yes)
                {
                    alumnoBusiness.DeshabilitarAlumno(seleccionado);
                    MessageBox.Show("Alumno deshabilitado", "Alumno Deshabilitado");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar el alumno: " + ex.ToString());
            }
        }
    }
}
