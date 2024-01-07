namespace Testing1ConexionesDB
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
            this.DgvProfesores = new System.Windows.Forms.DataGridView();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFotoPerfil)).BeginInit();
            this.GbxNombreUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // PbxFotoPerfil
            // 
            this.PbxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxFotoPerfil.Location = new System.Drawing.Point(129, 95);
            this.PbxFotoPerfil.Margin = new System.Windows.Forms.Padding(5);
            this.PbxFotoPerfil.Name = "PbxFotoPerfil";
            this.PbxFotoPerfil.Size = new System.Drawing.Size(330, 305);
            this.PbxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxFotoPerfil.TabIndex = 1;
            this.PbxFotoPerfil.TabStop = false;
            // 
            // LblNombreUsuario
            // 
            this.LblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblNombreUsuario.AutoSize = true;
            this.LblNombreUsuario.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreUsuario.Location = new System.Drawing.Point(10, 41);
            this.LblNombreUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombreUsuario.Name = "LblNombreUsuario";
            this.LblNombreUsuario.Size = new System.Drawing.Size(181, 29);
            this.LblNombreUsuario.TabIndex = 4;
            this.LblNombreUsuario.Text = "NombreUsuario";
            this.LblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GbxNombreUsuario
            // 
            this.GbxNombreUsuario.AutoSize = true;
            this.GbxNombreUsuario.Controls.Add(this.LblNombreUsuario);
            this.GbxNombreUsuario.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxNombreUsuario.Location = new System.Drawing.Point(471, 95);
            this.GbxNombreUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.GbxNombreUsuario.Name = "GbxNombreUsuario";
            this.GbxNombreUsuario.Padding = new System.Windows.Forms.Padding(5);
            this.GbxNombreUsuario.Size = new System.Drawing.Size(259, 101);
            this.GbxNombreUsuario.TabIndex = 6;
            this.GbxNombreUsuario.TabStop = false;
            this.GbxNombreUsuario.Text = "User";
            // 
            // DgvProfesores
            // 
            this.DgvProfesores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesores.Location = new System.Drawing.Point(129, 412);
            this.DgvProfesores.Margin = new System.Windows.Forms.Padding(5);
            this.DgvProfesores.MultiSelect = false;
            this.DgvProfesores.Name = "DgvProfesores";
            this.DgvProfesores.ReadOnly = true;
            this.DgvProfesores.RowHeadersWidth = 51;
            this.DgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProfesores.Size = new System.Drawing.Size(1295, 365);
            this.DgvProfesores.TabIndex = 0;
            this.DgvProfesores.SelectionChanged += new System.EventHandler(this.DgvProfesores_SelectionChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(471, 279);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(140, 41);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(475, 348);
            this.LblApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(101, 29);
            this.LblApellido.TabIndex = 3;
            this.LblApellido.Text = "Apellido";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.BtnAgregar.Location = new System.Drawing.Point(129, 801);
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
            this.BtnModificar.Location = new System.Drawing.Point(286, 802);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(149, 45);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // FrmProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1516, 891);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GbxNombreUsuario);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
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
    }
}

