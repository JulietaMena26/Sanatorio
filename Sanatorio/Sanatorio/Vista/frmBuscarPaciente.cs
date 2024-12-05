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
    public partial class frmBuscarPaciente : Form
    {
        public int idPaciente { set; get; }
        private ToolTip toolTip;
        public frmBuscarPaciente()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		public frmBuscarPaciente(Paciente paciente)
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txtBuscar, "Solo ingrese el DNI o el Apellido");                      
        }

		private void listado_Pacientes(string cTexto)
		{
			dataGridPaciente.Rows.Clear();
			try
			{
				DataTable tabla = new DataTable();
				tabla = (new DatosPaciente()).listarPaciente(cTexto);

				foreach (DataRow fila in tabla.Rows)
				{
					dataGridPaciente.Rows.Add(fila[0], fila[2], fila[3], fila[4]);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + " " + ex.StackTrace);
				// throw ex;
			}
			dataGridPaciente.ClearSelection();
		}
       
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            this.listado_Pacientes("%");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
		{
            this.listado_Pacientes(txtBuscar.Text.Trim());
		}

		private void btnSeleccion_Click(object sender, EventArgs e)
		{
			if (dataGridPaciente.SelectedRows.Count > 0) 
            { 
                this.idPaciente = (int)dataGridPaciente.SelectedRows[0].Cells["id"].Value; 
                DialogResult = DialogResult.OK; 
                this.Close(); 
            } 
            else 
            { 
                MessageBox.Show("Por favor, selecciona un paciente.","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            }
		}

		private void dataGridPaciente_DoubleClick(object sender, EventArgs e)
		{
			this.idPaciente = (int)dataGridPaciente.SelectedRows[0].Cells["id"].Value;
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
