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
    public partial class frmBuscarMedico : Form
    {
        public int idMedico { set; get; }
        private ToolTip toolTip;
        public frmBuscarMedico()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		public frmBuscarMedico(Paciente paciente)
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txtBuscar, "Solo ingrese el Apellido, nombre o especialidad");                      
        }

		private void listado_Medicos(string cTexto)
		{
			dataGridMedico.Rows.Clear();
			try
			{
				DataTable tabla = new DataTable();
				tabla = (new DatosMedico()).listarMedico(cTexto);

				foreach (DataRow fila in tabla.Rows)
				{
					dataGridMedico.Rows.Add(fila[0], fila[6], fila[2] + " " + fila[3], fila[7]);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + " " + ex.StackTrace);
				// throw ex;
			}
			dataGridMedico.ClearSelection();
		}
       
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            this.listado_Medicos("%");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.listado_Medicos(txtBuscar.Text.Trim());
		}

		private void btnSeleccion_Click(object sender, EventArgs e)
		{
			if (dataGridMedico.SelectedRows.Count > 0) 
            { 
                this.idMedico = (int)dataGridMedico.SelectedRows[0].Cells["id"].Value; 
                DialogResult = DialogResult.OK; 
                this.Close(); 
            } 
            else 
            { 
                MessageBox.Show("Por favor, selecciona un Medico.","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
		}

		private void dataGridPaciente_DoubleClick(object sender, EventArgs e)
		{
			this.idMedico = (int)dataGridMedico.SelectedRows[0].Cells["id"].Value;
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
