using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanatorio.Datos;
using Sanatorio.Modelos;

namespace Sanatorio.Vista
{
    public partial class frmPaciente : Form
    {
        private ToolTip toolTip;
        public frmPaciente()
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void listado_Pacientes(string cTexto)
        {
            dataGridPaciente.Rows.Clear(); 
            try
            {
               DataTable tabla = new DataTable();
               tabla = (new DatosPaciente()).listarPaciente(cTexto);

               foreach (DataRow fila in tabla.Rows)
                {
                    dataGridPaciente.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], (DateTime.Parse(fila[5].ToString())).ToString("dd/MM/yyyy"), fila[6], fila[7], fila[8], fila[9], fila[10], fila[11]);
                }
            
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
               // throw ex;
            }
            dataGridPaciente.ClearSelection();
        }

        private void actualizar_paciente()
        {
            frmNewPaciente nuevo = new frmNewPaciente();
            if (dataGridPaciente.SelectedRows.Count > 0)
            {
                nuevo.txtId.Text = dataGridPaciente.CurrentRow.Cells[0].Value.ToString();
                nuevo.txtHistoriClinica.Text = dataGridPaciente.CurrentRow.Cells[1].Value.ToString();
                nuevo.txtDni.Text = dataGridPaciente.CurrentRow.Cells[2].Value.ToString();
                nuevo.txtApellido.Text = dataGridPaciente.CurrentRow.Cells[3].Value.ToString();
                nuevo.txtNombre.Text = dataGridPaciente.CurrentRow.Cells[4].Value.ToString();
                DateTime fechaDateTime = DateTime.ParseExact(dataGridPaciente.CurrentRow.Cells[5].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nuevo.dateTimePickerFechaNaci.Value = fechaDateTime;
                nuevo.txtEdad.Text = dataGridPaciente.CurrentRow.Cells[6].Value.ToString();
                nuevo.txtDomicilio.Text = dataGridPaciente.CurrentRow.Cells[7].Value.ToString();
                nuevo.txtTelefono.Text = dataGridPaciente.CurrentRow.Cells[8].Value.ToString();
                nuevo.cmbObraSocial.Text = dataGridPaciente.CurrentRow.Cells[9].Value.ToString();
                nuevo.txtNunAfiliado.Text = dataGridPaciente.CurrentRow.Cells[10].Value.ToString();
                nuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un Paciente");
            }
        }
        #endregion
        
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();    
            toolTip.SetToolTip(txtBuscar,"Ingrese un dni o apellido o parte");
            toolTip.SetToolTip(btnBuscar, "Buscar precione F1");
            toolTip.SetToolTip(btnNuevo, "Nuevo precione F2");
            toolTip.SetToolTip(btnEditar, "Edita precione F3");
            toolTip.SetToolTip(btnEliminar, "Eliminar precione F4");
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

            listado_Pacientes("%");

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNewPaciente nuevo = new frmNewPaciente();
            nuevo.txtHistoriClinica.Focus();
            nuevo.ShowDialog();     
            
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.ForeColor = Color.White;
            txtBuscar.BackColor = Color.FromArgb(72, 89, 53);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.BackColor = Color.FromArgb(202,219,183);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listado_Pacientes(txtBuscar.Text.Trim());           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_paciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			DialogResult respuesta;

			if (dataGridPaciente.SelectedRows.Count > 0)
			{
				respuesta = MessageBox.Show("¿Desea eliminar al Paciente DNI: " + dataGridPaciente.CurrentRow.Cells[2].Value.ToString() + " " + dataGridPaciente.CurrentRow.Cells[3].Value.ToString() + " " + dataGridPaciente.CurrentRow.Cells[4].Value.ToString() + "?", "Sistemas Santa Rita", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (respuesta == DialogResult.Yes)
				{
                    DatosPaciente datos = new DatosPaciente();
                    datos.eliminarPaciente(int.Parse(dataGridPaciente.CurrentRow.Cells[0].Value.ToString()));
					MessageBox.Show("Cliente Eliminado", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);					
				}
			}
			else
			{
				MessageBox.Show("Seleccione una Paciente a Eliminar", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

            this.listado_Pacientes("%");
			
		}

        private void dataGridPaciente_DoubleClick(object sender, EventArgs e)
        {
           
            this.actualizar_paciente();
        }

        private void frmPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.btnBuscar_Click(sender,e);
            }
            if (e.KeyCode == Keys.F2)
            {
                this.btnNuevo_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                this.btnEditar_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                this.btnEliminar_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.lblCerrar_Click(sender, e);
            }
        }
    }
}
