﻿namespace Testing1ConexionesDB
{
    partial class FrmProfesor
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
            this.PbxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.GbxNombreUsuario = new System.Windows.Forms.GroupBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.DgvProfesores = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminarFisico = new System.Windows.Forms.Button();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.LblCampos = new System.Windows.Forms.Label();
            this.CbxCampos = new System.Windows.Forms.ComboBox();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblFiltroAvanzado = new System.Windows.Forms.Label();
            this.TxtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFotoPerfil)).BeginInit();
            this.GbxNombreUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxFotoPerfil
            // 
            this.PbxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxFotoPerfil.Location = new System.Drawing.Point(114, 76);
            this.PbxFotoPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.PbxFotoPerfil.Name = "PbxFotoPerfil";
            this.PbxFotoPerfil.Size = new System.Drawing.Size(201, 201);
            this.PbxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxFotoPerfil.TabIndex = 1;
            this.PbxFotoPerfil.TabStop = false;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.Location = new System.Drawing.Point(12, 114);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(119, 19);
            this.LblNombreUsuario.TabIndex = 4;
            this.LblNombreUsuario.Text = "NombreUsuario";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxNombreUsuario
            // 
            this.GbxNombreUsuario.AutoSize = true;
            this.GbxNombreUsuario.Controls.Add(this.LblNombreUsuario);
            this.GbxNombreUsuario.Controls.Add(this.LblNombre);
            this.GbxNombreUsuario.Controls.Add(this.LblApellido);
            this.GbxNombreUsuario.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxNombreUsuario.Location = new System.Drawing.Point(323, 76);
            this.GbxNombreUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.GbxNombreUsuario.Name = "GbxNombreUsuario";
            this.GbxNombreUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.GbxNombreUsuario.Size = new System.Drawing.Size(361, 165);
            this.GbxNombreUsuario.TabIndex = 6;
            this.GbxNombreUsuario.TabStop = false;
            this.GbxNombreUsuario.Text = "Profesor";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(10, 22);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(87, 25);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(12, 64);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(66, 19);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido";
            this.LblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvProfesores
            // 
            this.DgvProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesores.Location = new System.Drawing.Point(114, 402);
            this.DgvProfesores.Margin = new System.Windows.Forms.Padding(5);
            this.DgvProfesores.MultiSelect = false;
            this.DgvProfesores.Name = "DgvProfesores";
            this.DgvProfesores.ReadOnly = true;
            this.DgvProfesores.RowHeadersWidth = 51;
            this.DgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProfesores.Size = new System.Drawing.Size(1295, 376);
            this.DgvProfesores.TabIndex = 0;
            this.DgvProfesores.SelectionChanged += new System.EventHandler(this.DgvProfesores_SelectionChanged);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnAgregar.Location = new System.Drawing.Point(114, 787);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(149, 45);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(272, 787);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(149, 45);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminarFisico
            // 
            this.BtnEliminarFisico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarFisico.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnEliminarFisico.Location = new System.Drawing.Point(1260, 784);
            this.BtnEliminarFisico.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarFisico.Name = "BtnEliminarFisico";
            this.BtnEliminarFisico.Size = new System.Drawing.Size(149, 45);
            this.BtnEliminarFisico.TabIndex = 9;
            this.BtnEliminarFisico.Text = "Eliminar";
            this.BtnEliminarFisico.UseVisualStyleBackColor = true;
            this.BtnEliminarFisico.Click += new System.EventHandler(this.BtnEliminarFisico_Click);
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeshabilitar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnDeshabilitar.Location = new System.Drawing.Point(426, 787);
            this.BtnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(149, 45);
            this.BtnDeshabilitar.TabIndex = 10;
            this.BtnDeshabilitar.Text = "Deshabilitar";
            this.BtnDeshabilitar.UseVisualStyleBackColor = true;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.BtnDeshabilitar_Click);
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFiltro.Location = new System.Drawing.Point(110, 318);
            this.LblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(50, 15);
            this.LblFiltro.TabIndex = 11;
            this.LblFiltro.Text = "Buscar:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(169, 316);
            this.TxtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(335, 20);
            this.TxtFiltro.TabIndex = 12;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // LblCampos
            // 
            this.LblCampos.AutoSize = true;
            this.LblCampos.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblCampos.Location = new System.Drawing.Point(110, 362);
            this.LblCampos.Name = "LblCampos";
            this.LblCampos.Size = new System.Drawing.Size(54, 15);
            this.LblCampos.TabIndex = 13;
            this.LblCampos.Text = "Campos";
            // 
            // CbxCampos
            // 
            this.CbxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCampos.FormattingEnabled = true;
            this.CbxCampos.Location = new System.Drawing.Point(170, 358);
            this.CbxCampos.Name = "CbxCampos";
            this.CbxCampos.Size = new System.Drawing.Size(202, 21);
            this.CbxCampos.TabIndex = 14;
            this.CbxCampos.SelectedIndexChanged += new System.EventHandler(this.CbxCampos_SelectedIndexChanged);
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(504, 358);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(202, 21);
            this.CbxCriterio.TabIndex = 16;
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblCriterio.Location = new System.Drawing.Point(450, 362);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(47, 15);
            this.LblCriterio.TabIndex = 15;
            this.LblCriterio.Text = "Criterio";
            // 
            // LblFiltroAvanzado
            // 
            this.LblFiltroAvanzado.AutoSize = true;
            this.LblFiltroAvanzado.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblFiltroAvanzado.Location = new System.Drawing.Point(803, 362);
            this.LblFiltroAvanzado.Name = "LblFiltroAvanzado";
            this.LblFiltroAvanzado.Size = new System.Drawing.Size(38, 15);
            this.LblFiltroAvanzado.TabIndex = 17;
            this.LblFiltroAvanzado.Text = "Texto";
            // 
            // TxtFiltroAvanzado
            // 
            this.TxtFiltroAvanzado.Location = new System.Drawing.Point(849, 359);
            this.TxtFiltroAvanzado.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFiltroAvanzado.Name = "TxtFiltroAvanzado";
            this.TxtFiltroAvanzado.Size = new System.Drawing.Size(224, 20);
            this.TxtFiltroAvanzado.TabIndex = 18;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnBuscar.Location = new System.Drawing.Point(1121, 352);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(126, 31);
            this.BtnBuscar.TabIndex = 19;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(1284, 352);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(126, 31);
            this.BtnLimpiar.TabIndex = 20;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1516, 844);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtFiltroAvanzado);
            this.Controls.Add(this.LblFiltroAvanzado);
            this.Controls.Add(this.CbxCriterio);
            this.Controls.Add(this.LblCriterio);
            this.Controls.Add(this.CbxCampos);
            this.Controls.Add(this.LblCampos);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.BtnDeshabilitar);
            this.Controls.Add(this.BtnEliminarFisico);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbxNombreUsuario);
            this.Controls.Add(this.PbxFotoPerfil);
            this.Controls.Add(this.DgvProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmProfesor";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            this.Load += new System.EventHandler(this.FrmProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFotoPerfil)).EndInit();
            this.GbxNombreUsuario.ResumeLayout(false);
            this.GbxNombreUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PbxFotoPerfil;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.GroupBox GbxNombreUsuario;
        private System.Windows.Forms.DataGridView DgvProfesores;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminarFisico;
        private System.Windows.Forms.Button BtnDeshabilitar;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label LblCampos;
        private System.Windows.Forms.ComboBox CbxCampos;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblFiltroAvanzado;
        private System.Windows.Forms.TextBox TxtFiltroAvanzado;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

