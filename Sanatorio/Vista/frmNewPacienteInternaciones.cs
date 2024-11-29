using Sanatorio.Datos;
using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Data;
using MySqlX.XDevAPI.Relational;


namespace Sanatorio.Vista
{
    public partial class frmNewPacienteInternaciones : Form
    {
        Conexion conexion = new Conexion();
        public frmNewPacienteInternaciones()
        {
            InitializeComponent();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            frmPacientesInternacionSeleccionar secondForm = new frmPacientesInternacionSeleccionar();

            if (secondForm.ShowDialog() == DialogResult.OK)
            {
                txtId.Text = secondForm.SelectedIDPaciente;
                txtDni.Text = secondForm.SelectedDNI;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!verificarControlesVacios())
            {
                return;
            }

            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            try
            {
                SQLdatos.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = SQLdatos;

                if (string.IsNullOrEmpty(txtId.Text.Trim()))
                {
                    if (existeInternacion(txtDni.Text.Trim(), SQLdatos))
                    {
                        MessageBox.Show("El paciente ya está internado!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDni.Focus();
                    }
                    else
                    {
                        // Agregar nueva internación
                        command.CommandText = "psa_agregar_internacion";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("pIDPaciente", int.Parse(txtId.Text.Trim()));
                        //falta hacer bien: command.Parameters.AddWithValue("pFechaIngreso", dateTimePickerFechaIngreso.Value);
                        //falta hacer bien: command.Parameters.AddWithValue("pHoraIngreso", TimeSpan.Parse(txtHoraIngreso.Text.Trim()));
                        //falta hacer bien: command.Parameters.AddWithValue("pIDMedico", int.Parse(cmbMedico.SelectedValue.ToString()));
                        //falta hacer bien: command.Parameters.AddWithValue("pIDHabitacion", int.Parse(cmbHabitacion.SelectedValue.ToString()));
                        //falta hacer bien: command.Parameters.AddWithValue("pMotivoInternacion", txtMotivoInternacion.Text.Trim());
                        //falta hacer bien: command.Parameters.AddWithValue("pDiagnostico", txtDiagnostico.Text.Trim());
                        //falta hacer bien: command.Parameters.AddWithValue("pDeuda", decimal.Parse(txtDeuda.Text.Trim()));
                        //falta hacer bien: command.Parameters.AddWithValue("pEstado", txtEstado.Text.Trim());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Internación agregada con éxito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    command.CommandText = "psa_actualizar_internacion";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("pIDInternacion", int.Parse(txtId.Text.Trim()));
                    //falta hacer bien:  command.Parameters.AddWithValue("pFechaIngreso", dateTimePickerFechaIngreso.Value);
                    //falta hacer bien: command.Parameters.AddWithValue("pHoraIngreso", TimeSpan.Parse(txtHoraIngreso.Text.Trim()));
                    //falta hacer bien: command.Parameters.AddWithValue("pIDMedico", int.Parse(cmbMedico.SelectedValue.ToString()));
                    //falta hacer bien: command.Parameters.AddWithValue("pIDHabitacion", int.Parse(cmbHabitacion.SelectedValue.ToString()));
                    //falta hacer bien: command.Parameters.AddWithValue("pMotivoInternacion", txtMotivoInternacion.Text.Trim());
                    //falta hacer bien:  command.Parameters.AddWithValue("pDiagnostico", txtDiagnostico.Text.Trim());
                    //falta hacer bien:  command.Parameters.AddWithValue("pDeuda", decimal.Parse(txtDeuda.Text.Trim()));
                    //falta hacer bien:  command.Parameters.AddWithValue("pEstado", txtEstado.Text.Trim());

                    command.ExecuteNonQuery();
                    MessageBox.Show("Internación actualizada con éxito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }

            this.Close();
        }

        private bool existeInternacion(string dni, MySqlConnection connection)
        {
            bool existe = false;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_existe_internacion", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("pDNI", dni);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    existe = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el paciente ya está internado: " + ex.Message);
            }

            return existe;
        }



        private bool verificarControlesVacios()
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }

        private bool existePaciente(string dni, MySqlConnection connection)
        {
            bool existe = false;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_existe_paciente", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("pDNI", dni);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    existe = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar si el paciente existe: " + ex.Message);
            }

            return existe;
        }

        private void frmNewPacienteInternaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
