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
    public partial class FrmNuevoAlumno : Form
    {
        public FrmNuevoAlumno()
        {
            InitializeComponent();
        }

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
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
            Alumno nuevoAlumno = new Alumno();
            AlumnoBusiness alumnoBusiness = new AlumnoBusiness();

            nuevoAlumno.NombreUsuario = TxtNombreUsuario.Text;
            nuevoAlumno.Contraseña = TxtContraseña.Text;
            nuevoAlumno.Email = TxtEmail.Text;
            nuevoAlumno.Nombre = TxtNombre.Text;
            nuevoAlumno.Apellido1 = TxtApellido1.Text;
            nuevoAlumno.Apellido2 = TxtApellido2.Text;
            nuevoAlumno.FechaNacimiento = DtpFechaNacimiento.Value;
            nuevoAlumno.Genero = (Genero)CbxGenero.SelectedItem;
            nuevoAlumno.Telefono = int.Parse(TxtTelefono.Text);
            nuevoAlumno.Direccion = TxtDireccion.Text;
            nuevoAlumno.Ciudad = TxtCiudad.Text;
            nuevoAlumno.UrlImagenPerfil = TxtUrlImagenPerfil.Text;
            nuevoAlumno.Disciplina = (Disciplina)CbxDisciplinas.SelectedItem;
            nuevoAlumno.Grupo = (Grupo)CbxGrupos.SelectedItem;

            try
            {
                alumnoBusiness.AgregarAlumno(nuevoAlumno);
                Close();
                MessageBox.Show("Nuevo alumno agregado");
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
