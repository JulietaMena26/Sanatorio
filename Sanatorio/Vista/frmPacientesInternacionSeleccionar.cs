using System;
using System.Data;
using System.Windows.Forms;

namespace Sanatorio.Datos
{
    public partial class frmPacientesInternacionSeleccionar : Form
    {
        public string SelectedIDPaciente { get; private set; }
        public string SelectedDNI { get; private set; }

        public frmPacientesInternacionSeleccionar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listado_Pacientes(txtBuscar.Text.Trim());
        }

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


        private void frmPacientesInternacionSeleccionar_Load(object sender, EventArgs e)
        {
            listado_Pacientes("%");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridPaciente.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridPaciente.SelectedRows[0];

                try
                {
                    SelectedIDPaciente = selectedRow.Cells[0].Value.ToString(); 
                    SelectedDNI = selectedRow.Cells[2].Value.ToString(); 

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al seleccionar datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente.");
            }
        }
    }
}
