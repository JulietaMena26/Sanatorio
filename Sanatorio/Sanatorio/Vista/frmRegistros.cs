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
    public partial class frmRegistros : Form
    {
        private ToolTip toolTip;
        private int PacienteId;
        private int MedicoId;
        public frmRegistros()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		#region "Mis métodos"
		private void mensajestoolTip()
		{
			toolTip = new ToolTip();
			toolTip.SetToolTip(txtBuscar, "Ingrese apellido o nombre del medico o paciente");
			toolTip.SetToolTip(btnBuscar, "Buscar precione F1");
			toolTip.SetToolTip(btnNuevo, "Nuevo precione F2");
			toolTip.SetToolTip(btnEditar, "Edita precione F3");
			toolTip.SetToolTip(btnEliminar, "Eliminar precione F4");
		}

        private void listado_Registros(string texto)
        {
			dataGridRegsitros.Rows.Clear();
			try
			{
				DataTable tabla = new DataTable();
				tabla = (new DatosRegistroClinico()).listarRegistros(texto);

				//MessageBox.Show("Numero de filas: " + tabla.Rows.Count);
				foreach (DataRow fila in tabla.Rows)
				{
                    // las dos untimas columnas fila[10] contiene la id del paciente y fila[11] el id del medico (no se cargan al datagrid)
					dataGridRegsitros.Rows.Add(fila[0], fila[1], fila[2], ((DateTime.Parse(fila[3].ToString()).ToString("dd/MM/yyyy"))), fila[4], fila[5], fila[6], fila[7], ((DateTime.Parse(fila[8].ToString()).ToString("dd/MM/yyyy"))), fila[9], fila[10], fila[11]);					
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + " " + ex.StackTrace);
				// throw ex;
			}
			dataGridRegsitros.ClearSelection();
		}

        private void actualizarRegistro()
        {
            
            this.PacienteId = (int)dataGridRegsitros.CurrentRow.Cells[10].Value;
			this.MedicoId = (int)dataGridRegsitros.CurrentRow.Cells[11].Value;
			
            if (dataGridRegsitros.SelectedRows.Count > 0)
			{
				frmNewRegistros nuevo = new frmNewRegistros();
				nuevo.txtId.Text = dataGridRegsitros.CurrentRow.Cells[0].Value.ToString();
                Paciente nombre = (new DatosPaciente()).buscarPacienteId(this.PacienteId); 
                nuevo.txtPaciente.Text = nombre.apellido + " " + nombre.nombre;
                Medico medico = (new DatosMedico()).buscarMedicoId(this.MedicoId);
                nuevo.txtMedico.Text = medico.apellido + " " + medico.nombre;
				DateTime fecha = DateTime.ParseExact(dataGridRegsitros.CurrentRow.Cells[3].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nuevo.dateTimePickerFechaNaci.Value = fecha;

                DateTime hora;                
              	// Convertimos la cadena a un objeto DateTime
				if (DateTime.TryParseExact(dataGridRegsitros.CurrentRow.Cells[4].Value.ToString(), "HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out hora))
				{
					// Si la conversión es exitosa, asignamos el valor al DateTimePicker
					nuevo.dateTimePicker1.Value = hora;
					//dateTimePicker1.Format = DateTimePickerFormat.Time; // Opcional: para mostrar solo la hora
				}
				nuevo.txtMotivo.Text = dataGridRegsitros.CurrentRow.Cells[5].Value.ToString();
                nuevo.txtdiagnostico.Text = dataGridRegsitros.CurrentRow.Cells[6].Value.ToString();
                nuevo.txttratamiento.Text = dataGridRegsitros.CurrentRow.Cells[7].Value.ToString();
				DateTime proxima = DateTime.ParseExact(dataGridRegsitros.CurrentRow.Cells[8].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
				nuevo.txtproxima_visita.Value = proxima;
                nuevo.txtObservacion.Text = nuevo.txtMotivo.Text = dataGridRegsitros.CurrentRow.Cells[9].Value.ToString();

                nuevo.btnBuscarMedico.Enabled = false;
                nuevo.btnBuscarPaciente.Enabled = false;
                nuevo.ShowDialog();
			}
			else
			{
				MessageBox.Show("Seleccione un Registro");
			}
		}
		#endregion

		private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNewRegistros nuevo = new frmNewRegistros();
            //nuevo.txtHistoriClinica.Focus();
            nuevo.ShowDialog();

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.ForeColor = Color.White;
            txtBuscar.BackColor = Color.FromArgb(72, 89, 53);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            // txtBuscar.Text = "";
            txtBuscar.BackColor = Color.FromArgb(202, 219, 183);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.listado_Registros(txtBuscar.Text.Trim());           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizarRegistro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridRegistros.CurrentRow.Cells[11].Value.ToString());
        }       

        private void frmPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.btnBuscar_Click(sender, e);
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

		private void frmRegistros_Load(object sender, EventArgs e)
		{
            this.listado_Registros("%");
		}

		private void dataGridRegsitros_DoubleClick(object sender, EventArgs e)
		{
            this.actualizarRegistro();
		}
	}
}
