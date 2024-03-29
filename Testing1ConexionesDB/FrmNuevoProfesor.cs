﻿using Business;
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
using System.Configuration;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Testing1ConexionesDB
{
    public partial class FrmNuevoProfesor : Form
    {
        Profesor profesor = null;
        OpenFileDialog imagen = null;

        public FrmNuevoProfesor()
        {
            InitializeComponent();
        }

        public FrmNuevoProfesor(Profesor profesor)
        {
            InitializeComponent();
            Text = "Modificar " + profesor.Nombre;
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
                CbxGenero.ValueMember = "Id";
                CbxGenero.DisplayMember = "Descripcion";

                CbxDisciplinas.DataSource = disciplinaBusiness.List();
                CbxDisciplinas.ValueMember = "Id";
                CbxDisciplinas.DisplayMember = "Descripcion";

                CbxGrupos.DataSource = grupoBusiness.List();
                CbxGrupos.ValueMember = "Id";
                CbxGrupos.DisplayMember = "Descripcion";

                LoadImage(string.Empty);

                if (profesor != null)
                {
                    LblTitle.Text = "Modificar " + profesor.Nombre;
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
                    CbxGenero.SelectedValue = profesor.Genero.Id;
                    CbxDisciplinas.SelectedValue = profesor.Disciplinas.Id;
                    CbxGrupos.SelectedValue = profesor.Grupos.Id;

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
            ProfesorBusiness profesorBusiness = new ProfesorBusiness();

            if (profesor == null)
                profesor = new Profesor();

            try
            {
                profesor.NombreUsuario = TxtNombreUsuario.Text;
                profesor.Contraseña = TxtContraseña.Text;
                profesor.Nombre = TxtNombre.Text;
                profesor.Apellido1 = TxtApellido1.Text;
                profesor.Apellido2 = TxtApellido2.Text;
                profesor.FechaNacimiento = (DateTime)DtpFechaNacimiento.Value;
                profesor.Email = TxtEmail.Text;
                profesor.Telefono = int.Parse(TxtTelefono.Text);
                profesor.Direccion = TxtDireccion.Text;
                profesor.Ciudad = TxtCiudad.Text;

                if (imagen != null && !(TxtUrlImagenPerfil.Text.ToLower().Contains("http")))
                {
                    File.Copy(imagen.FileName, ConfigurationManager.AppSettings["profile-image"] + imagen.SafeFileName);
                    profesor.UrlImagenPerfil = ConfigurationManager.AppSettings["profile-image"] + imagen.SafeFileName;
                }
                else
                {
                    profesor.UrlImagenPerfil = TxtUrlImagenPerfil.Text;
                }

                profesor.Genero = (Genero)CbxGenero.SelectedItem;
                profesor.Disciplinas = (Disciplina)CbxDisciplinas.SelectedItem;
                profesor.Grupos = (Grupo)CbxGrupos.SelectedItem;


                if (profesor.Id != 0)
                {
                    profesorBusiness.ModificarProfesor(profesor);
                    MessageBox.Show("Profesor modificado"); 
                }
                else
                {
                    profesorBusiness.AgragarProfesor(profesor);
                    MessageBox.Show("Nuevo profesor agregado");
                }


                Close();
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
