using Sanatorio.Datos;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanatorio.Vista
{
    public partial class frmNewPaciente : Form
    {
        private Paciente paciente;
        public frmNewPaciente()
        {
            InitializeComponent();
        }

        public frmNewPaciente(Paciente paciente)
        {
            this.paciente = paciente;
            InitializeComponent();
        }

        #region "Mis Métodos"

        public void cargar_combo_obraSocial()
        {
            DatosObraSocial datos = new DatosObraSocial();
            cmbObraSocial.DataSource = datos.listarObraSocial("%");
            cmbObraSocial.ValueMember = "idSocial";
            cmbObraSocial.DisplayMember = "nombre";            
        }

        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("paciente Nuevo");
            }
            else
            {
                MessageBox.Show("Actualizar PAciente");
            }
            
           
        }

        private void cmbObraSocial_Click(object sender, EventArgs e)
        {
            cargar_combo_obraSocial();
        }
    }
}
