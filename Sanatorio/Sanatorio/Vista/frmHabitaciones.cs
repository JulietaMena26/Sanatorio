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
    public partial class frmHabitaciones : Form
    {
        private ToolTip toolTip;
        public frmHabitaciones()
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void cargar_habitaciones()
        {
            dataGridHabitaciones.Rows.Clear(); 
            try
            {
                DataTable tabla = new DataTable();
                tabla = (new DatosHabitacion()).listarHabitacion();
                foreach (DataRow fila in tabla.Rows)
                {
                    dataGridHabitaciones.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8], fila[9]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
               // throw ex;
            }
            dataGridHabitaciones.ClearSelection();
        }

        private void actualizar_habitacion() // Método con el cual se carga la ventana para actualizar los datos
        {

            
            if (dataGridHabitaciones.SelectedRows.Count > 0)
            {
                Habitacion habitacion = new Habitacion();
                habitacion.idHabitacion = int.Parse(dataGridHabitaciones.CurrentRow.Cells[0].Value.ToString());
                habitacion.numero = dataGridHabitaciones.CurrentRow.Cells[1].Value.ToString();
                habitacion.id_tipo = int.Parse(dataGridHabitaciones.CurrentRow.Cells[9].Value.ToString());
                habitacion.piso = int.Parse(dataGridHabitaciones.CurrentRow.Cells[3].Value.ToString());
                habitacion.capacidad = int.Parse(dataGridHabitaciones.CurrentRow.Cells[4].Value.ToString());
                habitacion.estado = dataGridHabitaciones.CurrentRow.Cells[5].Value.ToString();
                habitacion.precio = decimal.Parse(dataGridHabitaciones.CurrentRow.Cells[6].Value.ToString());
                habitacion.comodidad = dataGridHabitaciones.CurrentRow.Cells[7].Value.ToString();
                habitacion.observacion = dataGridHabitaciones.CurrentRow.Cells[8].Value.ToString();
                //MessageBox.Show(habitacion.ToString());
				frmNewHabitacion nuevo = new frmNewHabitacion(habitacion);
				nuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una habitación","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void mensajestoolTip()
		{
			toolTip = new ToolTip();
			toolTip.SetToolTip(txtBuscar, "Ingrese un dni o apellido o parte");
			toolTip.SetToolTip(btnBuscar, "Buscar precione F1");
			toolTip.SetToolTip(btnNuevo, "Nuevo precione F2");
			toolTip.SetToolTip(btnEditar, "Edita precione F3");
			toolTip.SetToolTip(btnEliminar, "Eliminar precione F4");
		}
		#endregion

		private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
			frmNewHabitacion nuevo = new frmNewHabitacion();
            nuevo.txtNumero.Focus();;
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
            //listado_Pacientes(txtBuscar.Text.Trim());
        }

		private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_habitacion();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
             
			if (dataGridHabitaciones.SelectedRows.Count > 0)
			{
				respuesta = MessageBox.Show("¿Desea eliminar la habitación N° "+ dataGridHabitaciones.CurrentRow.Cells[1].Value.ToString() + "?", "Sistemas Santa Rita",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DatosHabitacion habitacion = new DatosHabitacion();
                    if (habitacion.eliminar(int.Parse(dataGridHabitaciones.CurrentRow.Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Habitación Eliminada", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
						MessageBox.Show("No se pudo eliminar la habitación", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}                    
                }
			}
			else
			{
				MessageBox.Show("Seleccione una habitación", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.cargar_habitaciones();
        }
        
        private void frmHabitaciones_KeyDown(object sender, KeyEventArgs e)
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

        private void dataGridHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void frmHabitaciones_Load(object sender, EventArgs e)
		{
			this.cargar_habitaciones();
		}

		private void dataGridHabitaciones_DoubleClick(object sender, EventArgs e)
		{
			this.actualizar_habitacion();
		}
	}
}
