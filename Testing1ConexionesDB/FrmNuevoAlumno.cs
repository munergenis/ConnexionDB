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
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede conectar a la Base de Datos " + ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
