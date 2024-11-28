using Sanatorio.Datos;
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

namespace Sanatorio.Vista
{
    public partial class frmObrassociales : Form
    {
        private ToolTip toolTip;
        public frmObrassociales()
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void listado_Pacientes(string cTexto)
        {
            dataGridobrasocial.Rows.Clear();
            try
            {
                DataTable tabla = new DataTable();
                tabla = (new DatosPaciente()).listarPaciente(cTexto);

                foreach (DataRow fila in tabla.Rows)
                {
                    dataGridobrasocial.Rows.Add(fila[0], fila[1], fila[2]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
                // throw ex;
            }
            dataGridobrasocial.ClearSelection();
        }

        private void actualizar_paciente()
        {
			frmNewPaciente nuevo = new frmNewPaciente();
            if (dataGridobrasocial.SelectedRows.Count > 0)
            {
                nuevo.txtId.Text = dataGridobrasocial.CurrentRow.Cells[0].Value.ToString();
                nuevo.txtHistoriClinica.Text = dataGridobrasocial.CurrentRow.Cells[1].Value.ToString();
                nuevo.txtDni.Text = dataGridobrasocial.CurrentRow.Cells[2].Value.ToString();
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
            //toolTip.SetToolTip(txtBuscar, "Ingrese una obra social");
            //toolTip.SetToolTip(btnBuscar, "Buscar precione F1");
            //toolTip.SetToolTip(btnNuevo, "Nuevo precione F2");
            //toolTip.SetToolTip(btnEditar, "Edita precione F3");
            //toolTip.SetToolTip(btnEliminar, "Eliminar precione F4");
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmObrassociales_Load(object sender, EventArgs e)
        {

           //listado_ObraSocial("%");

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
			frmNewPaciente nuevo = new frmNewPaciente();
            nuevo.txtHistoriClinica.Focus();
            nuevo.ShowDialog();

        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            //txtBuscar.ForeColor = Color.White;
            //txtBuscar.BackColor = Color.FromArgb(72, 89, 53);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            //txtBuscar.Text = "";
            //txtBuscar.BackColor = Color.FromArgb(202, 219, 183);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //listado_ObrasSociales(txtBuscar.Text.Trim());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_paciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            if (dataGridobrasocial.SelectedRows.Count > 0)
            {
                respuesta = MessageBox.Show("¿Desea eliminar la obra social: " + dataGridobrasocial.CurrentRow.Cells[2].Value.ToString() + " " + dataGridobrasocial.CurrentRow.Cells[3].Value.ToString() + " " + dataGridobrasocial.CurrentRow.Cells[4].Value.ToString() + "?", "Sistemas Santa Rita", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DatosPaciente datos = new DatosPaciente();
                    datos.eliminarPaciente(int.Parse(dataGridobrasocial.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Cliente Eliminado", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Paciente a Eliminar", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //this.listado_ObraSocial("%");

        }

        private void dataGridObrasocial_DoubleClick(object sender, EventArgs e)
        {

            //this.actualizar_obraSocial();
        }

        private void frmObrassociales_KeyDown(object sender, KeyEventArgs e)
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

    }
}
