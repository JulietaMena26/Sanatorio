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
        public frmRegistros()
        {
            InitializeComponent();
            mensajestoolTip();
        }
        #region "Mis Métodos"
     
        private void listado_frmRegistros(string cTexto)
        {
            dataGridRegsitros.Rows.Clear();
            try
            {
                DataTable tabla = new DataTable();
                tabla = (new DatosPaciente()).listarPaciente(cTexto);

                foreach (DataRow fila in tabla.Rows)
                {
                    dataGridRegsitros.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8], fila[9]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
                // throw ex;
            }
            dataGridRegsitros.ClearSelection();
        }
        private void actualizar_frmRegistros() // Método con el cual se carga la ventana para actualizar los datos
        {


            if (dataGridRegsitros.SelectedRows.Count > 0)
            {
                frmRegistros Registros = new frmRegistros();
                Registros.id.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[0].Value.ToString());
                Registros.id_paciente.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[1].Value.ToString());
                Registros.id_medico.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[2].Value.ToString());
                Registros.fecha.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[3].Value.ToString());
                Registros.hora.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[4].Value.ToString());
                Registros.motivo.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[5].Value.ToString());
                Registros.diagnostico.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[6].Value.ToString());
                Registros.tratamiento.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[7].Value.ToString());
                Registros.proxima_visita.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[8].Value.ToString());
                Registros.observacion.ToolTipText = (dataGridRegsitros.CurrentRow.Cells[9].Value.ToString());

                Registros.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        #endregion

        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txtBuscar, "Ingrese un dni o apellido o parte");
            toolTip.SetToolTip(btnBuscar, "Buscar precione F1");
            toolTip.SetToolTip(btnNuevo, "Nuevo precione F2");
            toolTip.SetToolTip(btnEditar, "Edita precione F3");
            toolTip.SetToolTip(btnEliminar, "Eliminar precione F4");
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistros_Load(object sender, EventArgs e)
        {

            listado_frmRegistros("%");

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
            listado_frmRegistros(txtBuscar.Text.Trim());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_frmRegistros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridRegsitros.CurrentRow.Cells[11].Value.ToString());
        }

        private void dataGridRegsitros_DoubleClick(object sender, EventArgs e)
        {

            this.actualizar_frmRegistros();
        }

        private void frmRegistros_KeyDown(object sender, KeyEventArgs e)
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
