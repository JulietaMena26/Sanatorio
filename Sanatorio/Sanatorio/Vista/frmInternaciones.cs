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
    public partial class frmInternaciones : Form
    {
        private ToolTip toolTip;
        public frmInternaciones()
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void listado_Internaciones(string cTexto,string _estado)
        {
            dataGridInternacion.Rows.Clear(); 
            try
            {
               DataTable tabla = new DataTable();
               tabla = (new DatosInternacion()).listarInternacion(cTexto,_estado);

               foreach (DataRow fila in tabla.Rows)
                {

                    string fechaAlta = "";

                    if (!string.IsNullOrEmpty(fila[8].ToString()))
                    {
                        fechaAlta = (DateTime.Parse(fila[8].ToString())).ToString("dd/MM/yyyy");
					}
                    dataGridInternacion.Rows.Add(fila[0], (DateTime.Parse(fila[1].ToString())).ToString("dd/MM/yyyy"), DateTime.Parse(fila[2].ToString()).ToString("HH:mm:ss"), fila[3], fila[4], fila[5], fila[6],fila[7], fechaAlta);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
               // throw ex;
            }
            dataGridInternacion.ClearSelection();
        }

        private void actualizar_Internacion()
        {
			
            if (dataGridInternacion.SelectedRows.Count > 0)
            {
				Internacion _internacion = new Internacion();

                int id_Interncion = (int)dataGridInternacion.CurrentRow.Cells[0].Value; 

                _internacion = (new DatosInternacion()).buscarInternacionId(id_Interncion);

                //MessageBox.Show(_internacion.ToString());

                frmNewInternacion nuevo = new frmNewInternacion(_internacion);
				nuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una Internación","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void altaPaciente()
        {
			if (dataGridInternacion.SelectedRows.Count > 0)
			{
                string nombre = dataGridInternacion.CurrentRow.Cells[3].Value.ToString();
                DialogResult resp = MessageBox.Show($"¿Quiere dar de alta al paciente {nombre}?","Sistema Santa Rita",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    if ((new DatosInternacion()).altaInternacion(int.Parse(dataGridInternacion.CurrentRow.Cells[0].Value.ToString())))
                    {
                        MessageBox.Show($"Paciente {nombre} dado de ALTA", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Habitacion habitacion_ = (new DatosHabitacion()).buscarHabitacionNumero(dataGridInternacion.CurrentRow.Cells[5].Value.ToString());
                        (new DatosHabitacion()).liberarCama(habitacion_.idHabitacion);
						this.listado_Internaciones("%", "Internación");
					}
                    else 
                    {
						MessageBox.Show($"No se puedo dar de alta al Paciente {nombre} dado de ALTA", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
                }
                dataGridInternacion.ClearSelection();
			}
			else
			{
				MessageBox.Show("Seleccione una Paciente para dar de Alta ", "Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

            this.listado_Internaciones("%","Internación");

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
			frmNewInternacion nuevo = new frmNewInternacion();
            nuevo.dateTimePickerFechIngreso.Focus();
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
            txtBuscar.BackColor = Color.FromArgb(202,219,183);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(rdbInternado.Checked)
            {
				this.listado_Internaciones(txtBuscar.Text.Trim(), "Internación");
			}

            if(rdbAlta.Checked)
            {
		        this.listado_Internaciones(txtBuscar.Text.Trim(), "Alta");
			}      
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_Internacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridInternacion.CurrentRow.Cells[11].Value.ToString());
        }

        private void dataGridPaciente_DoubleClick(object sender, EventArgs e)
        {
           
            this.actualizar_Internacion();
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

		private void rdbAlta_CheckedChanged(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
            {
                this.listado_Internaciones("%", "Alta");
            }
            else 
            {
				this.listado_Internaciones(txtBuscar.Text.Trim(), "Alta");
			}			
		}

		private void rdbInternado_CheckedChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtBuscar.Text.Trim()))
			{
				this.listado_Internaciones("%", "Internación");
			}
			else
			{
				this.listado_Internaciones(txtBuscar.Text.Trim(), "Internación");
			}			
		}

		private void button1_Click(object sender, EventArgs e)
		{
            this.altaPaciente();
		}
	}
}
