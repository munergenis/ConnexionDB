﻿namespace Testing1ConexionesDB
{
    partial class FrmNuevoAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbDatosEscuela = new System.Windows.Forms.GroupBox();
            this.CbxGrupos = new System.Windows.Forms.ComboBox();
            this.CbxDisciplinas = new System.Windows.Forms.ComboBox();
            this.LblGrupos = new System.Windows.Forms.Label();
            this.LblDisciplinas = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.GbxDatosContacto = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.GbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.CbxGenero = new System.Windows.Forms.ComboBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblApellido1 = new System.Windows.Forms.Label();
            this.LblApellido2 = new System.Windows.Forms.Label();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.TxtApellido1 = new System.Windows.Forms.TextBox();
            this.TxtApellido2 = new System.Windows.Forms.TextBox();
            this.GbxDatosUsuario = new System.Windows.Forms.GroupBox();
            this.TxtNombreUsuario = new System.Windows.Forms.TextBox();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.GrbImagenPerfil = new System.Windows.Forms.GroupBox();
            this.PbxImagenPerfil = new System.Windows.Forms.PictureBox();
            this.TxtUrlImagenPerfil = new System.Windows.Forms.TextBox();
            this.LblUrlImagenPerfil = new System.Windows.Forms.Label();
            this.BtnCargarImagen = new System.Windows.Forms.Button();
            this.GrbDatosEscuela.SuspendLayout();
            this.GbxDatosContacto.SuspendLayout();
            this.GbxDatosPersonales.SuspendLayout();
            this.GbxDatosUsuario.SuspendLayout();
            this.GrbImagenPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDatosEscuela
            // 
            this.GrbDatosEscuela.Controls.Add(this.CbxGrupos);
            this.GrbDatosEscuela.Controls.Add(this.CbxDisciplinas);
            this.GrbDatosEscuela.Controls.Add(this.LblGrupos);
            this.GrbDatosEscuela.Controls.Add(this.LblDisciplinas);
            this.GrbDatosEscuela.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.GrbDatosEscuela.Location = new System.Drawing.Point(124, 728);
            this.GrbDatosEscuela.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GrbDatosEscuela.Name = "GrbDatosEscuela";
            this.GrbDatosEscuela.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GrbDatosEscuela.Size = new System.Drawing.Size(642, 172);
            this.GrbDatosEscuela.TabIndex = 3;
            this.GrbDatosEscuela.TabStop = false;
            this.GrbDatosEscuela.Text = "Datos de la Escuela";
            // 
            // CbxGrupos
            // 
            this.CbxGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGrupos.FormattingEnabled = true;
            this.CbxGrupos.Location = new System.Drawing.Point(235, 101);
            this.CbxGrupos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CbxGrupos.Name = "CbxGrupos";
            this.CbxGrupos.Size = new System.Drawing.Size(330, 27);
            this.CbxGrupos.TabIndex = 1;
            // 
            // CbxDisciplinas
            // 
            this.CbxDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDisciplinas.FormattingEnabled = true;
            this.CbxDisciplinas.Location = new System.Drawing.Point(235, 58);
            this.CbxDisciplinas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CbxDisciplinas.Name = "CbxDisciplinas";
            this.CbxDisciplinas.Size = new System.Drawing.Size(330, 27);
            this.CbxDisciplinas.TabIndex = 0;
            // 
            // LblGrupos
            // 
            this.LblGrupos.AutoSize = true;
            this.LblGrupos.Location = new System.Drawing.Point(165, 105);
            this.LblGrupos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGrupos.Name = "LblGrupos";
            this.LblGrupos.Size = new System.Drawing.Size(65, 20);
            this.LblGrupos.TabIndex = 1;
            this.LblGrupos.Text = "Grupos";
            // 
            // LblDisciplinas
            // 
            this.LblDisciplinas.AutoSize = true;
            this.LblDisciplinas.Location = new System.Drawing.Point(138, 61);
            this.LblDisciplinas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDisciplinas.Name = "LblDisciplinas";
            this.LblDisciplinas.Size = new System.Drawing.Size(91, 20);
            this.LblDisciplinas.TabIndex = 0;
            this.LblDisciplinas.Text = "Disciplinas";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAceptar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnAceptar.Location = new System.Drawing.Point(1124, 909);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(165, 51);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnCancelar.Location = new System.Drawing.Point(1299, 909);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(165, 51);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(116, 65);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(171, 29);
            this.LblTitle.TabIndex = 30;
            this.LblTitle.Text = "Nuevo Alumno";
            // 
            // GbxDatosContacto
            // 
            this.GbxDatosContacto.Controls.Add(this.TxtEmail);
            this.GbxDatosContacto.Controls.Add(this.LblEmail);
            this.GbxDatosContacto.Controls.Add(this.LblTelefono);
            this.GbxDatosContacto.Controls.Add(this.TxtCiudad);
            this.GbxDatosContacto.Controls.Add(this.LblDireccion);
            this.GbxDatosContacto.Controls.Add(this.TxtDireccion);
            this.GbxDatosContacto.Controls.Add(this.LblCiudad);
            this.GbxDatosContacto.Controls.Add(this.TxtTelefono);
            this.GbxDatosContacto.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.GbxDatosContacto.Location = new System.Drawing.Point(816, 146);
            this.GbxDatosContacto.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GbxDatosContacto.Name = "GbxDatosContacto";
            this.GbxDatosContacto.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GbxDatosContacto.Size = new System.Drawing.Size(648, 239);
            this.GbxDatosContacto.TabIndex = 1;
            this.GbxDatosContacto.TabStop = false;
            this.GbxDatosContacto.Text = "Datos de Contacto";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(206, 52);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(330, 27);
            this.TxtEmail.TabIndex = 0;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(142, 58);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(51, 20);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Email";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(119, 96);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(75, 20);
            this.LblTelefono.TabIndex = 7;
            this.LblTelefono.Text = "Teléfono";
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(206, 172);
            this.TxtCiudad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(330, 27);
            this.TxtCiudad.TabIndex = 3;
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(114, 136);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(80, 20);
            this.LblDireccion.TabIndex = 8;
            this.LblDireccion.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(206, 132);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(330, 27);
            this.TxtDireccion.TabIndex = 2;
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.Location = new System.Drawing.Point(132, 176);
            this.LblCiudad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(62, 20);
            this.LblCiudad.TabIndex = 9;
            this.LblCiudad.Text = "Ciudad";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(206, 92);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(330, 27);
            this.TxtTelefono.TabIndex = 1;
            // 
            // GbxDatosPersonales
            // 
            this.GbxDatosPersonales.Controls.Add(this.CbxGenero);
            this.GbxDatosPersonales.Controls.Add(this.LblGenero);
            this.GbxDatosPersonales.Controls.Add(this.TxtNombre);
            this.GbxDatosPersonales.Controls.Add(this.LblNombre);
            this.GbxDatosPersonales.Controls.Add(this.DtpFechaNacimiento);
            this.GbxDatosPersonales.Controls.Add(this.LblApellido1);
            this.GbxDatosPersonales.Controls.Add(this.LblApellido2);
            this.GbxDatosPersonales.Controls.Add(this.LblFechaNacimiento);
            this.GbxDatosPersonales.Controls.Add(this.TxtApellido1);
            this.GbxDatosPersonales.Controls.Add(this.TxtApellido2);
            this.GbxDatosPersonales.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.GbxDatosPersonales.Location = new System.Drawing.Point(121, 369);
            this.GbxDatosPersonales.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GbxDatosPersonales.Name = "GbxDatosPersonales";
            this.GbxDatosPersonales.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GbxDatosPersonales.Size = new System.Drawing.Size(645, 319);
            this.GbxDatosPersonales.TabIndex = 2;
            this.GbxDatosPersonales.TabStop = false;
            this.GbxDatosPersonales.Text = "Datos Personales";
            // 
            // CbxGenero
            // 
            this.CbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGenero.FormattingEnabled = true;
            this.CbxGenero.Location = new System.Drawing.Point(238, 206);
            this.CbxGenero.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CbxGenero.Name = "CbxGenero";
            this.CbxGenero.Size = new System.Drawing.Size(330, 27);
            this.CbxGenero.TabIndex = 3;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(168, 210);
            this.LblGenero.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(64, 20);
            this.LblGenero.TabIndex = 7;
            this.LblGenero.Text = "Genero";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(238, 58);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(330, 27);
            this.TxtNombre.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(162, 61);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(71, 20);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(238, 251);
            this.DtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(330, 27);
            this.DtpFechaNacimiento.TabIndex = 4;
            // 
            // LblApellido1
            // 
            this.LblApellido1.AutoSize = true;
            this.LblApellido1.Location = new System.Drawing.Point(112, 101);
            this.LblApellido1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApellido1.Name = "LblApellido1";
            this.LblApellido1.Size = new System.Drawing.Size(126, 20);
            this.LblApellido1.TabIndex = 4;
            this.LblApellido1.Text = "Primer Apellido";
            // 
            // LblApellido2
            // 
            this.LblApellido2.AutoSize = true;
            this.LblApellido2.Location = new System.Drawing.Point(96, 141);
            this.LblApellido2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApellido2.Name = "LblApellido2";
            this.LblApellido2.Size = new System.Drawing.Size(142, 20);
            this.LblApellido2.TabIndex = 5;
            this.LblApellido2.Text = "Segundo Apellido";
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(69, 259);
            this.LblFechaNacimiento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(168, 20);
            this.LblFechaNacimiento.TabIndex = 6;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // TxtApellido1
            // 
            this.TxtApellido1.Location = new System.Drawing.Point(238, 98);
            this.TxtApellido1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtApellido1.Name = "TxtApellido1";
            this.TxtApellido1.Size = new System.Drawing.Size(330, 27);
            this.TxtApellido1.TabIndex = 1;
            // 
            // TxtApellido2
            // 
            this.TxtApellido2.Location = new System.Drawing.Point(238, 138);
            this.TxtApellido2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtApellido2.Name = "TxtApellido2";
            this.TxtApellido2.Size = new System.Drawing.Size(330, 27);
            this.TxtApellido2.TabIndex = 2;
            // 
            // GbxDatosUsuario
            // 
            this.GbxDatosUsuario.Controls.Add(this.TxtNombreUsuario);
            this.GbxDatosUsuario.Controls.Add(this.LblNombreUsuario);
            this.GbxDatosUsuario.Controls.Add(this.LblContraseña);
            this.GbxDatosUsuario.Controls.Add(this.TxtContraseña);
            this.GbxDatosUsuario.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.GbxDatosUsuario.Location = new System.Drawing.Point(124, 146);
            this.GbxDatosUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GbxDatosUsuario.Name = "GbxDatosUsuario";
            this.GbxDatosUsuario.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GbxDatosUsuario.Size = new System.Drawing.Size(642, 189);
            this.GbxDatosUsuario.TabIndex = 0;
            this.GbxDatosUsuario.TabStop = false;
            this.GbxDatosUsuario.Text = "Datos de Usuario";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.Location = new System.Drawing.Point(235, 68);
            this.TxtNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(330, 27);
            this.TxtNombreUsuario.TabIndex = 0;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Location = new System.Drawing.Point(101, 71);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(133, 20);
            this.LblNombreUsuario.TabIndex = 0;
            this.LblNombreUsuario.Text = "Nombre Usuario";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Location = new System.Drawing.Point(134, 111);
            this.LblContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(96, 20);
            this.LblContraseña.TabIndex = 1;
            this.LblContraseña.Text = "Contraseña";
            this.LblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(235, 108);
            this.TxtContraseña.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(330, 27);
            this.TxtContraseña.TabIndex = 1;
            // 
            // GrbImagenPerfil
            // 
            this.GrbImagenPerfil.Controls.Add(this.BtnCargarImagen);
            this.GrbImagenPerfil.Controls.Add(this.PbxImagenPerfil);
            this.GrbImagenPerfil.Controls.Add(this.TxtUrlImagenPerfil);
            this.GrbImagenPerfil.Controls.Add(this.LblUrlImagenPerfil);
            this.GrbImagenPerfil.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.GrbImagenPerfil.Location = new System.Drawing.Point(816, 415);
            this.GrbImagenPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrbImagenPerfil.Name = "GrbImagenPerfil";
            this.GrbImagenPerfil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrbImagenPerfil.Size = new System.Drawing.Size(648, 485);
            this.GrbImagenPerfil.TabIndex = 31;
            this.GrbImagenPerfil.TabStop = false;
            this.GrbImagenPerfil.Text = "Imagen de Perfil";
            // 
            // PbxImagenPerfil
            // 
            this.PbxImagenPerfil.Location = new System.Drawing.Point(209, 95);
            this.PbxImagenPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PbxImagenPerfil.Name = "PbxImagenPerfil";
            this.PbxImagenPerfil.Size = new System.Drawing.Size(329, 329);
            this.PbxImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImagenPerfil.TabIndex = 10;
            this.PbxImagenPerfil.TabStop = false;
            // 
            // TxtUrlImagenPerfil
            // 
            this.TxtUrlImagenPerfil.Location = new System.Drawing.Point(206, 46);
            this.TxtUrlImagenPerfil.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TxtUrlImagenPerfil.Name = "TxtUrlImagenPerfil";
            this.TxtUrlImagenPerfil.Size = new System.Drawing.Size(330, 27);
            this.TxtUrlImagenPerfil.TabIndex = 8;
            this.TxtUrlImagenPerfil.Leave += new System.EventHandler(this.TxtUrlImagenPerfil_Leave);
            // 
            // LblUrlImagenPerfil
            // 
            this.LblUrlImagenPerfil.AutoSize = true;
            this.LblUrlImagenPerfil.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblUrlImagenPerfil.Location = new System.Drawing.Point(44, 50);
            this.LblUrlImagenPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUrlImagenPerfil.Name = "LblUrlImagenPerfil";
            this.LblUrlImagenPerfil.Size = new System.Drawing.Size(157, 20);
            this.LblUrlImagenPerfil.TabIndex = 0;
            this.LblUrlImagenPerfil.Text = "Url Imagen de Perfil";
            // 
            // BtnCargarImagen
            // 
            this.BtnCargarImagen.Location = new System.Drawing.Point(48, 95);
            this.BtnCargarImagen.Name = "BtnCargarImagen";
            this.BtnCargarImagen.Size = new System.Drawing.Size(154, 51);
            this.BtnCargarImagen.TabIndex = 11;
            this.BtnCargarImagen.Text = "Cargar Imagen";
            this.BtnCargarImagen.UseVisualStyleBackColor = true;
            this.BtnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // FrmNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1580, 990);
            this.Controls.Add(this.GrbImagenPerfil);
            this.Controls.Add(this.GrbDatosEscuela);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.GbxDatosContacto);
            this.Controls.Add(this.GbxDatosPersonales);
            this.Controls.Add(this.GbxDatosUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmNuevoAlumno";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Alumno";
            this.Load += new System.EventHandler(this.FrmNuevoAlumno_Load);
            this.GrbDatosEscuela.ResumeLayout(false);
            this.GrbDatosEscuela.PerformLayout();
            this.GbxDatosContacto.ResumeLayout(false);
            this.GbxDatosContacto.PerformLayout();
            this.GbxDatosPersonales.ResumeLayout(false);
            this.GbxDatosPersonales.PerformLayout();
            this.GbxDatosUsuario.ResumeLayout(false);
            this.GbxDatosUsuario.PerformLayout();
            this.GrbImagenPerfil.ResumeLayout(false);
            this.GrbImagenPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDatosEscuela;
        private System.Windows.Forms.ComboBox CbxGrupos;
        private System.Windows.Forms.ComboBox CbxDisciplinas;
        private System.Windows.Forms.Label LblGrupos;
        private System.Windows.Forms.Label LblDisciplinas;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GbxDatosContacto;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.GroupBox GbxDatosPersonales;
        private System.Windows.Forms.ComboBox CbxGenero;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Label LblApellido1;
        private System.Windows.Forms.Label LblApellido2;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.TextBox TxtApellido1;
        private System.Windows.Forms.TextBox TxtApellido2;
        private System.Windows.Forms.GroupBox GbxDatosUsuario;
        private System.Windows.Forms.TextBox TxtNombreUsuario;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.GroupBox GrbImagenPerfil;
        private System.Windows.Forms.PictureBox PbxImagenPerfil;
        private System.Windows.Forms.TextBox TxtUrlImagenPerfil;
        private System.Windows.Forms.Label LblUrlImagenPerfil;
        private System.Windows.Forms.Button BtnCargarImagen;
    }
}