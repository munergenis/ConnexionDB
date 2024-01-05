namespace Testing1ConexionesDB
{
    partial class FrmLobby
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
            this.BtnProfesores = new System.Windows.Forms.Button();
            this.BtnAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProfesores
            // 
            this.BtnProfesores.Location = new System.Drawing.Point(161, 119);
            this.BtnProfesores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnProfesores.Name = "BtnProfesores";
            this.BtnProfesores.Size = new System.Drawing.Size(176, 84);
            this.BtnProfesores.TabIndex = 0;
            this.BtnProfesores.Text = "Profesores";
            this.BtnProfesores.UseVisualStyleBackColor = true;
            this.BtnProfesores.Click += new System.EventHandler(this.BtnProfesores_Click);
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.Location = new System.Drawing.Point(391, 119);
            this.BtnAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(176, 84);
            this.BtnAlumnos.TabIndex = 1;
            this.BtnAlumnos.Text = "Alumnos";
            this.BtnAlumnos.UseVisualStyleBackColor = true;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // FrmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 322);
            this.Controls.Add(this.BtnAlumnos);
            this.Controls.Add(this.BtnProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLobby";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProfesores;
        private System.Windows.Forms.Button BtnAlumnos;
    }
}