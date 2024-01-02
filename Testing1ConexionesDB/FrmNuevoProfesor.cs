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
        public FrmNuevoProfesor()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

                profesorBusiness.AgragarProfesor(nuevoProfesor);
                Close();
                MessageBox.Show("Nuevo profesor agregado");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el profesor. " + ex.Message);
            }

        }
    }
}
