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
    public partial class frmMedicos : Form
    {
        private ToolTip toolTip;
        public frmMedicos()
        {
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void listado_Medico(string cTexto)
        {
            dataGridMedico.Rows.Clear();
            try
            {
                DataTable tabla = new DataTable();
                tabla = (new DatosMedico()).listarMedico(cTexto);

                foreach (DataRow fila in tabla.Rows)
                {
                    dataGridMedico.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], (DateTime.Parse(fila[5].ToString())).ToString("dd/MM/yyyy"), fila[6], fila[7], fila[8], fila[9], fila[10], fila[11]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
                // throw ex;
            }
        }

        private void actualizar_paciente()
        {
            frmNewPaciente nuevo = new frmNewPaciente();
            if (dataGridMedico.SelectedRows.Count > 0)
            {
                nuevo.txtId.Text = dataGridMedico.CurrentRow.Cells[0].Value.ToString();
                nuevo.txtHistoriClinica.Text = dataGridMedico.CurrentRow.Cells[1].Value.ToString();
                nuevo.txtDni.Text = dataGridMedico.CurrentRow.Cells[2].Value.ToString();
                nuevo.txtApellido.Text = dataGridMedico.CurrentRow.Cells[3].Value.ToString();
                nuevo.txtNombre.Text = dataGridMedico.CurrentRow.Cells[4].Value.ToString();
                DateTime fechaDateTime = DateTime.ParseExact(dataGridMedico.CurrentRow.Cells[5].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nuevo.dateTimePickerFechaNaci.Value = fechaDateTime;
                nuevo.txtEdad.Text = dataGridMedico.CurrentRow.Cells[6].Value.ToString();
                nuevo.txtDomicilio.Text = dataGridMedico.CurrentRow.Cells[7].Value.ToString();
                nuevo.txtTelefono.Text = dataGridMedico.CurrentRow.Cells[8].Value.ToString();
                nuevo.cmbObraSocial.Text = dataGridMedico.CurrentRow.Cells[9].Value.ToString();
                nuevo.txtNunAfiliado.Text = dataGridMedico.CurrentRow.Cells[10].Value.ToString();
                nuevo.ShowDialog();
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

        #region "mis Metodos"

        private void listar_Medico(string texto)
        {

            dataGridMedico.Rows.Clear();
            try
            {
                DataTable tabla = new DataTable();
                tabla = (new DatosMedico()).listarMedico(texto);

                foreach (DataRow fila in tabla.Rows)
                {
                    dataGridMedico.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8]);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " " + ex.StackTrace);
                throw ex;
            }
          dataGridMedico.ClearSelection();

        }
    
        #endregion

        private void frmPaciente_Load(object sender, EventArgs e)
        {

            this.listado_Medico("%");

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
            listado_Medico(txtBuscar.Text.Trim());           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //this.actualizar_Medico();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            if (dataGridMedico.SelectedRows.Count > 0)
            {
                respuesta = MessageBox.Show("¿Desea eliminar al Medico DNI: " + dataGridMedico.CurrentRow.Cells[2].Value.ToString() + " " + dataGridMedico.CurrentRow.Cells[3].Value.ToString() + " " + dataGridMedico.CurrentRow.Cells[4].Value.ToString() + "?", "Sistemas Santa Rita", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    DatosPaciente datos = new DatosPaciente();
                    datos.eliminarPaciente(int.Parse(dataGridMedico.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("Medico Eliminado", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Medico a Eliminar", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.listado_Medico("%");

        }


        // MessageBox.Show(dataGridMedico.CurrentRow.Cells[8].Value.toInt32());
    

        private void dataGridMedico_DoubleClick(object sender, EventArgs e)
        {
            this.listado_Medico(txtBuscar.Text.Trim());           
        }

        private void frmMedico_KeyDown(object sender, KeyEventArgs e)
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
