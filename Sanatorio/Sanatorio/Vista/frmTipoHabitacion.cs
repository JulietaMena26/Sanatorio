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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sanatorio.Vista
{
    public partial class frmTipoHabitacion : Form
    {
        //private ToolTip toolTip;
        public frmTipoHabitacion()
        {
            InitializeComponent();
            //mensajestoolTip();
        }

        #region "Mis Métodos"
        private void listado_tipoHabitacion()
        {
            dataGridTipoHabitacion.Rows.Clear(); 
            try
            {
               DataTable tabla = new DataTable();
               tabla = (new DatosTipoHabitacion()).listarTipoHabitacion("%");

               foreach (DataRow fila in tabla.Rows)
                {
                    dataGridTipoHabitacion.Rows.Add(fila[0], fila[1]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
               // throw ex;
            }
            dataGridTipoHabitacion.ClearSelection();
        }

        private void actualizar_tipoHabitacion()
        {
            frmNewTipoHabitacion nuevo = new frmNewTipoHabitacion();
            if (dataGridTipoHabitacion.SelectedRows.Count > 0)
            {
                nuevo.txtId.Text = dataGridTipoHabitacion.CurrentRow.Cells[0].Value.ToString();
                nuevo.txtDescripcion.Text = dataGridTipoHabitacion.CurrentRow.Cells[1].Value.ToString();
                nuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        #endregion
        
        //private void mensajestoolTip()
        //{
        //    toolTip = new ToolTip();    
        //    //toolTip.SetToolTip(txtBuscar,"Ingrese un dni o apellido o parte");
        //    //toolTip.SetToolTip(btnBuscar, "Buscar precione F1");
        //    toolTip.SetToolTip(btnNuevo, "Nuevo precione F2");
        //    toolTip.SetToolTip(btnEditar, "Edita precione F3");
        //    toolTip.SetToolTip(btnEliminar, "Eliminar precione F4");
        //}

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {

            listado_tipoHabitacion();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNewTipoHabitacion nuevo = new frmNewTipoHabitacion();
            nuevo.txtDescripcion.Focus();
            nuevo.ShowDialog();

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            //txtBuscar.ForeColor = Color.White;
            //txtBuscar.BackColor = Color.FromArgb(72, 89, 53);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
           // txtBuscar.Text = "";
            //txtBuscar.BackColor = Color.FromArgb(202,219,183);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //listado_Pacientes(txtBuscar.Text.Trim());           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_tipoHabitacion();
			
		}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea eliminar la descripción seleccionada?","Sistema Santa Rita",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            { 
                DatosTipoHabitacion tipo = new DatosTipoHabitacion();
                tipo.eliminarHabitacion(int.Parse(dataGridTipoHabitacion.CurrentRow.Cells[0].Value.ToString()));
				listado_tipoHabitacion();
			}            
        }

        private void dataGridPaciente_DoubleClick(object sender, EventArgs e)
        {
           
            this.actualizar_tipoHabitacion();
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

		private void dataGridTipoHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica si se hizo clic en una fila válida
			if (e.RowIndex >= 0)
			{
				// Obtén el valor de la celda que deseas mostrar (ajusta el nombre de la columna según tu caso)
				string valorCelda = dataGridTipoHabitacion.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();

				// Asigna el valor al TextBox
				txtDetalle.Text = valorCelda;
			}
		}

		private void dataGridTipoHabitacion_MouseLeave(object sender, EventArgs e)
		{
            txtDetalle.Text = "";
		}
	}
}
