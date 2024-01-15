using Business;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Testing1ConexionesDB
{
    public partial class FrmNuevoAlumno : Form
    {
        Alumno alumno = null;
        OpenFileDialog imagen = null;

        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        public FrmNuevoAlumno(Alumno alumnoModificar)
        {
            InitializeComponent();
            alumno = alumnoModificar;
            Text = "Modificar " + alumno.Nombre;
        }

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {
            GeneroBusiness generoBusiness = new GeneroBusiness();
            DisciplinaBusiness disciplinaBusiness = new DisciplinaBusiness();
            GrupoBusiness grupoBusiness = new GrupoBusiness();

            try
            {
                CbxGenero.DataSource = generoBusiness.List();
                CbxGenero.ValueMember = "Id";
                CbxGenero.DisplayMember = "Descripcion";

                CbxDisciplinas.DataSource = disciplinaBusiness.List();
                CbxDisciplinas.ValueMember = "Id";
                CbxDisciplinas.DisplayMember = "Descripcion";

                CbxGrupos.DataSource = grupoBusiness.List();
                CbxGrupos.ValueMember = "Id";
                CbxGrupos.DisplayMember = "Descripcion";

                if (alumno != null)
                {
                    LblTitle.Text = "Modificar " + alumno.Nombre;
                    TxtNombreUsuario.Text = alumno.NombreUsuario;
                    TxtContraseña.Text = alumno.Contraseña;
                    TxtNombre.Text = alumno.Nombre;
                    TxtApellido1.Text = alumno.Apellido1;
                    TxtApellido2.Text = alumno.Apellido2;
                    DtpFechaNacimiento.Value = alumno.FechaNacimiento;
                    TxtEmail.Text = alumno.Email;
                    TxtTelefono.Text = alumno.Telefono.ToString();
                    TxtDireccion.Text = alumno.Direccion;
                    TxtCiudad.Text = alumno.Ciudad;
                    TxtUrlImagenPerfil.Text = alumno.UrlImagenPerfil;
                    LoadImage(TxtUrlImagenPerfil.Text);
                    CbxGenero.SelectedValue = alumno.Genero.Id;
                    CbxDisciplinas.SelectedValue = alumno.Disciplina.Id;
                    CbxGrupos.SelectedValue = alumno.Grupo.Id;
                }
                else
                {
                    LoadImage(string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede conectar a la Base de Datos " + ex.ToString());
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
            AlumnoBusiness alumnoBusiness = new AlumnoBusiness();

            if (alumno == null)
            {
                alumno = new Alumno();
            }

            alumno.NombreUsuario = TxtNombreUsuario.Text;
            alumno.Contraseña = TxtContraseña.Text;
            alumno.Email = TxtEmail.Text;
            alumno.Nombre = TxtNombre.Text;
            alumno.Apellido1 = TxtApellido1.Text;
            alumno.Apellido2 = TxtApellido2.Text;
            alumno.FechaNacimiento = DtpFechaNacimiento.Value;
            alumno.Genero = (Genero)CbxGenero.SelectedItem;
            alumno.Telefono = int.Parse(TxtTelefono.Text);
            alumno.Direccion = TxtDireccion.Text;
            alumno.Ciudad = TxtCiudad.Text;

            if (imagen != null && !(TxtUrlImagenPerfil.Text.ToLower().Contains("http")))
            {
                File.Copy(imagen.FileName, ConfigurationManager.AppSettings["profile-image"] + imagen.SafeFileName);
                alumno.UrlImagenPerfil = ConfigurationManager.AppSettings["profile-image"] + imagen.SafeFileName;
            }
            else
            {
                alumno.UrlImagenPerfil = TxtUrlImagenPerfil.Text;
            }

            alumno.Disciplina = (Disciplina)CbxDisciplinas.SelectedItem;
            alumno.Grupo = (Grupo)CbxGrupos.SelectedItem;

            try
            {
                if (alumno.Id != 0)
                {
                    alumnoBusiness.ModificarAlumno(alumno);
                    MessageBox.Show("Alumno modificado");
                }
                else
                {
                    alumnoBusiness.AgregarAlumno(alumno);
                    MessageBox.Show("Nuevo alumno agregado");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el alumno: " + ex.ToString());
            }
        }

        private void TxtUrlImagenPerfil_Leave(object sender, EventArgs e)
        {
            LoadImage(TxtUrlImagenPerfil.Text);
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            imagen = new OpenFileDialog();
            imagen.Filter = "jpg | *.jpg | png | *.png";

            if (imagen.ShowDialog() == DialogResult.OK)
            {
                TxtUrlImagenPerfil.Text = imagen.FileName;
                LoadImage(TxtUrlImagenPerfil.Text);
            }
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
