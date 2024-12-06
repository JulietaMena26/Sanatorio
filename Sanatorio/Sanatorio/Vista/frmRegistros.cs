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

            listado_Registros("%");

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
            listado_Pacientes(txtBuscar.Text.Trim());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizarRegistro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridRegistros.CurrentRow.Cells[11].Value.ToString());
        }

        private void dataGridPaciente_DoubleClick(object sender, EventArgs e)
        {

            this.actualizarRegistro();
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


    }
}
