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
        private void listado_Internaciones()
        {
            dataGridInternacion.Rows.Clear(); 
            try
            {
               DataTable tabla = new DataTable();
               tabla = (new DatosInternacion()).listarInternacion();

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

        private void actualizar_paciente()
        {
			frmNewPaciente nuevo = new frmNewPaciente();
            if (dataGridInternacion.SelectedRows.Count > 0)
            {
                nuevo.txtId.Text = dataGridInternacion.CurrentRow.Cells[0].Value.ToString();
                nuevo.txtHistoriClinica.Text = dataGridInternacion.CurrentRow.Cells[1].Value.ToString();
                nuevo.txtDni.Text = dataGridInternacion.CurrentRow.Cells[2].Value.ToString();
                nuevo.txtApellido.Text = dataGridInternacion.CurrentRow.Cells[3].Value.ToString();
                nuevo.txtNombre.Text = dataGridInternacion.CurrentRow.Cells[4].Value.ToString();
                DateTime fechaDateTime = DateTime.ParseExact(dataGridInternacion.CurrentRow.Cells[5].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                nuevo.dateTimePickerFechaNaci.Value = fechaDateTime;
                nuevo.txtEdad.Text = dataGridInternacion.CurrentRow.Cells[6].Value.ToString();
                nuevo.txtDomicilio.Text = dataGridInternacion.CurrentRow.Cells[7].Value.ToString();
                nuevo.txtTelefono.Text = dataGridInternacion.CurrentRow.Cells[8].Value.ToString();
                nuevo.cmbObraSocial.Text = dataGridInternacion.CurrentRow.Cells[9].Value.ToString();
                nuevo.txtNunAfiliado.Text = dataGridInternacion.CurrentRow.Cells[10].Value.ToString();
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

            this.listado_Internaciones();

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
           // txtBuscar.Text = "";
            txtBuscar.BackColor = Color.FromArgb(202,219,183);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //listado_Pacientes(txtBuscar.Text.Trim());           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.actualizar_paciente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridInternacion.CurrentRow.Cells[11].Value.ToString());
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
