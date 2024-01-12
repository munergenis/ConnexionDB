namespace Testing1ConexionesDB
{
    partial class FrmAlumno
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GbxNombreUsuario = new System.Windows.Forms.GroupBox();
            this.LblNombreUsuario = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.PbxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.DgvAlumnos = new System.Windows.Forms.DataGridView();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminarFisico = new System.Windows.Forms.Button();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.LblCampos = new System.Windows.Forms.Label();
            this.LblCriterio = new System.Windows.Forms.Label();
            this.LblFiltroAvanzado = new System.Windows.Forms.Label();
            this.CbxCampos = new System.Windows.Forms.ComboBox();
            this.CbxCriterio = new System.Windows.Forms.ComboBox();
            this.TxtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.GrbFiltroAvanzado = new System.Windows.Forms.GroupBox();
            this.GbxNombreUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).BeginInit();
            this.GrbFiltroAvanzado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnAgregar.Location = new System.Drawing.Point(90, 730);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(119, 36);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GbxNombreUsuario
            // 
            this.GbxNombreUsuario.AutoSize = true;
            this.GbxNombreUsuario.Controls.Add(this.LblNombreUsuario);
            this.GbxNombreUsuario.Controls.Add(this.LblNombre);
            this.GbxNombreUsuario.Controls.Add(this.LblApellido);
            this.GbxNombreUsuario.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxNombreUsuario.Location = new System.Drawing.Point(356, 61);
            this.GbxNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbxNombreUsuario.Name = "GbxNombreUsuario";
            this.GbxNombreUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbxNombreUsuario.Size = new System.Drawing.Size(289, 132);
            this.GbxNombreUsuario.TabIndex = 12;
            this.GbxNombreUsuario.TabStop = false;
            this.GbxNombreUsuario.Text = "Alumno";
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.Location = new System.Drawing.Point(10, 91);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(119, 19);
            this.LblNombreUsuario.TabIndex = 4;
            this.LblNombreUsuario.Text = "NombreUsuario";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(8, 18);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(87, 25);
            this.LblNombre.TabIndex = 10;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(10, 51);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(66, 19);
            this.LblApellido.TabIndex = 11;
            this.LblApellido.Text = "Apellido";
            // 
            // PbxFotoPerfil
            // 
            this.PbxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxFotoPerfil.Location = new System.Drawing.Point(91, 61);
            this.PbxFotoPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PbxFotoPerfil.Name = "PbxFotoPerfil";
            this.PbxFotoPerfil.Size = new System.Drawing.Size(245, 245);
            this.PbxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxFotoPerfil.TabIndex = 9;
            this.PbxFotoPerfil.TabStop = false;
            // 
            // DgvAlumnos
            // 
            this.DgvAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlumnos.Location = new System.Drawing.Point(90, 428);
            this.DgvAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvAlumnos.MultiSelect = false;
            this.DgvAlumnos.Name = "DgvAlumnos";
            this.DgvAlumnos.ReadOnly = true;
            this.DgvAlumnos.RowHeadersWidth = 51;
            this.DgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAlumnos.Size = new System.Drawing.Size(1036, 283);
            this.DgvAlumnos.TabIndex = 8;
            this.DgvAlumnos.SelectionChanged += new System.EventHandler(this.DgvAlumnos_SelectionChanged);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(216, 730);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(119, 36);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminarFisico
            // 
            this.BtnEliminarFisico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarFisico.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnEliminarFisico.Location = new System.Drawing.Point(1007, 730);
            this.BtnEliminarFisico.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEliminarFisico.Name = "BtnEliminarFisico";
            this.BtnEliminarFisico.Size = new System.Drawing.Size(119, 36);
            this.BtnEliminarFisico.TabIndex = 15;
            this.BtnEliminarFisico.Text = "Eliminar";
            this.BtnEliminarFisico.UseVisualStyleBackColor = true;
            this.BtnEliminarFisico.Click += new System.EventHandler(this.BtnEliminarFisico_Click);
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeshabilitar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnDeshabilitar.Location = new System.Drawing.Point(340, 730);
            this.BtnDeshabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(119, 36);
            this.BtnDeshabilitar.TabIndex = 16;
            this.BtnDeshabilitar.Text = "Deshabilitar";
            this.BtnDeshabilitar.UseVisualStyleBackColor = true;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.BtnDeshabilitar_Click);
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblFiltro.Location = new System.Drawing.Point(88, 324);
            this.LblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(50, 15);
            this.LblFiltro.TabIndex = 17;
            this.LblFiltro.Text = "Buscar:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(144, 322);
            this.TxtFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(269, 20);
            this.TxtFiltro.TabIndex = 18;
            this.TxtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // LblCampos
            // 
            this.LblCampos.AutoSize = true;
            this.LblCampos.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblCampos.Location = new System.Drawing.Point(6, 31);
            this.LblCampos.Name = "LblCampos";
            this.LblCampos.Size = new System.Drawing.Size(54, 15);
            this.LblCampos.TabIndex = 19;
            this.LblCampos.Text = "Campos";
            // 
            // LblCriterio
            // 
            this.LblCriterio.AutoSize = true;
            this.LblCriterio.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblCriterio.Location = new System.Drawing.Point(279, 31);
            this.LblCriterio.Name = "LblCriterio";
            this.LblCriterio.Size = new System.Drawing.Size(47, 15);
            this.LblCriterio.TabIndex = 20;
            this.LblCriterio.Text = "Criterio";
            // 
            // LblFiltroAvanzado
            // 
            this.LblFiltroAvanzado.AutoSize = true;
            this.LblFiltroAvanzado.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.LblFiltroAvanzado.Location = new System.Drawing.Point(545, 31);
            this.LblFiltroAvanzado.Name = "LblFiltroAvanzado";
            this.LblFiltroAvanzado.Size = new System.Drawing.Size(38, 15);
            this.LblFiltroAvanzado.TabIndex = 21;
            this.LblFiltroAvanzado.Text = "Texto";
            // 
            // CbxCampos
            // 
            this.CbxCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCampos.FormattingEnabled = true;
            this.CbxCampos.Location = new System.Drawing.Point(66, 29);
            this.CbxCampos.Name = "CbxCampos";
            this.CbxCampos.Size = new System.Drawing.Size(187, 21);
            this.CbxCampos.TabIndex = 22;
            this.CbxCampos.SelectedIndexChanged += new System.EventHandler(this.CbxCampos_SelectedIndexChanged);
            // 
            // CbxCriterio
            // 
            this.CbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCriterio.FormattingEnabled = true;
            this.CbxCriterio.Location = new System.Drawing.Point(332, 29);
            this.CbxCriterio.Name = "CbxCriterio";
            this.CbxCriterio.Size = new System.Drawing.Size(187, 21);
            this.CbxCriterio.TabIndex = 23;
            // 
            // TxtFiltroAvanzado
            // 
            this.TxtFiltroAvanzado.Location = new System.Drawing.Point(589, 29);
            this.TxtFiltroAvanzado.Name = "TxtFiltroAvanzado";
            this.TxtFiltroAvanzado.Size = new System.Drawing.Size(168, 20);
            this.TxtFiltroAvanzado.TabIndex = 24;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnBuscar.Location = new System.Drawing.Point(783, 20);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(119, 36);
            this.BtnBuscar.TabIndex = 25;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(910, 20);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(119, 36);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // GrbFiltroAvanzado
            // 
            this.GrbFiltroAvanzado.Controls.Add(this.BtnLimpiar);
            this.GrbFiltroAvanzado.Controls.Add(this.LblCampos);
            this.GrbFiltroAvanzado.Controls.Add(this.LblCriterio);
            this.GrbFiltroAvanzado.Controls.Add(this.BtnBuscar);
            this.GrbFiltroAvanzado.Controls.Add(this.LblFiltroAvanzado);
            this.GrbFiltroAvanzado.Controls.Add(this.TxtFiltroAvanzado);
            this.GrbFiltroAvanzado.Controls.Add(this.CbxCampos);
            this.GrbFiltroAvanzado.Controls.Add(this.CbxCriterio);
            this.GrbFiltroAvanzado.Location = new System.Drawing.Point(90, 362);
            this.GrbFiltroAvanzado.Name = "GrbFiltroAvanzado";
            this.GrbFiltroAvanzado.Size = new System.Drawing.Size(1036, 69);
            this.GrbFiltroAvanzado.TabIndex = 28;
            this.GrbFiltroAvanzado.TabStop = false;
            this.GrbFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // FrmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1213, 793);
            this.Controls.Add(this.GrbFiltroAvanzado);
            this.Controls.Add(this.TxtFiltro);
            this.Controls.Add(this.LblFiltro);
            this.Controls.Add(this.BtnDeshabilitar);
            this.Controls.Add(this.BtnEliminarFisico);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbxNombreUsuario);
            this.Controls.Add(this.PbxFotoPerfil);
            this.Controls.Add(this.DgvAlumnos);
            this.MaximizeBox = false;
            this.Name = "FrmAlumno";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmAlumno_Load);
            this.GbxNombreUsuario.ResumeLayout(false);
            this.GbxNombreUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlumnos)).EndInit();
            this.GrbFiltroAvanzado.ResumeLayout(false);
            this.GrbFiltroAvanzado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox GbxNombreUsuario;
        private System.Windows.Forms.Label LblNombreUsuario;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.PictureBox PbxFotoPerfil;
        private System.Windows.Forms.DataGridView DgvAlumnos;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminarFisico;
        private System.Windows.Forms.Button BtnDeshabilitar;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label LblCampos;
        private System.Windows.Forms.Label LblCriterio;
        private System.Windows.Forms.Label LblFiltroAvanzado;
        private System.Windows.Forms.ComboBox CbxCampos;
        private System.Windows.Forms.ComboBox CbxCriterio;
        private System.Windows.Forms.TextBox TxtFiltroAvanzado;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.GroupBox GrbFiltroAvanzado;
    }
}