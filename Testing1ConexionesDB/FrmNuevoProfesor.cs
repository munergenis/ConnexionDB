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
    public partial class FrmNuevoProfesor : Form
    {
        Profesor profesor = null;

        public FrmNuevoProfesor()
        {
            InitializeComponent();
        }

        public FrmNuevoProfesor(Profesor profesor)
        {
            InitializeComponent();
            Text = "Modificar Profesor";
            this.profesor = profesor;
        }

        private void FrmNuevoProfesor_Load(object sender, EventArgs e)
        {
            GeneroBusiness generoBusiness = new GeneroBusiness();
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
            GrupoBusiness grupoBusiness = new GrupoBusiness();


            try
            {
                CbxGenero.DataSource = generoBusiness.List();
                CbxDisciplinas.DataSource = disciplinaBusiness.List();
                CbxGrupos.DataSource = grupoBusiness.List();
                LoadImage(string.Empty);

                if (profesor != null)
                {
                    TxtNombreUsuario.Text = profesor.NombreUsuario;
                    TxtContraseña.Text = profesor.Contraseña;
                    TxtEmail.Text = profesor.Email;
                    TxtNombre.Text = profesor.Nombre;
                    TxtApellido1.Text = profesor.Apellido1;
                    TxtApellido2.Text = profesor.Apellido2;
                    TxtTelefono.Text = profesor.Telefono.ToString();
                    DtpFechaNacimiento.Value = profesor.FechaNacimiento;
                    TxtUrlImagenPerfil.Text = profesor.UrlImagenPerfil;
                    TxtDireccion.Text = profesor.Direccion;
                    TxtCiudad.Text = profesor.Ciudad;

                    LoadImage(profesor.UrlImagenPerfil);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar a la Base de Datos " + ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            string text = "Seguro que quieres salir?";
            string caption = "Cerrar Formulario";
            var buttons = MessageBoxButtons.YesNo;
            var icon = MessageBoxIcon.Question;

            var result = MessageBox.Show(text, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Profesor nuevoProfesor = new Profesor();
            ProfesorBusiness profesorBusiness = new ProfesorBusiness();

            try
            {
                nuevoProfesor.NombreUsuario = TxtNombreUsuario.Text;
                nuevoProfesor.Contraseña = TxtContraseña.Text;
                nuevoProfesor.Nombre = TxtNombre.Text;
                nuevoProfesor.Apellido1 = TxtApellido1.Text;
                nuevoProfesor.Apellido2 = TxtApellido2.Text;
                nuevoProfesor.FechaNacimiento = (DateTime)DtpFechaNacimiento.Value;
                nuevoProfesor.Email = TxtEmail.Text;
                nuevoProfesor.Telefono = int.Parse(TxtTelefono.Text);
                nuevoProfesor.Direccion = TxtDireccion.Text;
                nuevoProfesor.Ciudad = TxtCiudad.Text;
                nuevoProfesor.UrlImagenPerfil = TxtUrlImagenPerfil.Text;
                nuevoProfesor.Genero = (Genero)CbxGenero.SelectedItem;
                nuevoProfesor.Disciplinas = (Disciplina)CbxDisciplinas.SelectedItem;
                nuevoProfesor.Grupos = (Grupo)CbxGrupos.SelectedItem;

                profesorBusiness.AgragarProfesor(nuevoProfesor);
                Close();
                MessageBox.Show("Nuevo profesor agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el profesor: " + ex.Message);
            }
        }

        private void TxtUrlImagenPerfil_Leave(object sender, EventArgs e)
        {
            LoadImage(TxtUrlImagenPerfil.Text);
        }

        private void LoadImage(string url)
        {
            try
            {
                PbxImagenPerfil.Load(url);
            }
            catch (Exception)
            {
                PbxImagenPerfil.Load("https://th.bing.com/th/id/OIG.B0QdXb93IrIqv0h68bQK?pid=ImgGn");
            }
        }
    }
}
