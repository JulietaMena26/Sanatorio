using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanatorio.Datos;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;

namespace Sanatorio.Vista
{
    public partial class frmNewRegistros : Form
    {
        Conexion conexion = new Conexion();
        private int pacienteId;
        private int medicoId;
        private Paciente paciente;
        private Medico medico;

		public frmNewRegistros()
        {
            InitializeComponent();

        }

        private void frmNewRegsitros_Load(object sender, EventArgs e)
        {

        }

        #region "MIs metodos"

        private bool verificarControlesVacios()
        {

            if (string.IsNullOrEmpty(txtPaciente.Text))
            {
                MessageBox.Show("Debe buscar un paciente","Sistema Santa Rita");
                btnBuscarPaciente.Focus();
                return false;            
            }
			if (string.IsNullOrEmpty(txtMedico.Text))
			{
				MessageBox.Show("Debe buscar el medico", "Sistema Santa Rita");
				btnBuscarMedico.Focus();
				return false;
			}
			return true;

		}


        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (!verificarControlesVacios())
            {
                return;
            }			

			Registro_Clinico registro = new Registro_Clinico();           
            registro.id_paciente = this.pacienteId;
            registro.id_medico = this.medicoId;
            registro.fecha = dateTimePickerFechaNaci.Value;
            registro.hora = dateTimePicker1.Value;
            registro.motivo = txtMotivo.Text.Trim();
            registro.diagnostico = txtdiagnostico.Text.Trim();
            registro.tratamiento = txttratamiento.Text.Trim();
            registro.proxima_visita = txtproxima_visita.Value;
            registro.observacion = txtObservacion.Text.Trim();
            DatosRegistroClinico datos = new DatosRegistroClinico();


            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                if (datos.agregarRegistro(registro))
                {
                    MessageBox.Show("Se agrego con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                registro.idRegistro = int.Parse(txtId.Text.Trim());

				if (datos.actualizarRegistro(registro))
				{
					MessageBox.Show("Se actualizo con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error al Actualizar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

		private void btnBuscarPaciente_Click(object sender, EventArgs e)
		{
			using (frmBuscarPaciente formBuscar = new frmBuscarPaciente(true))
			{
				if (formBuscar.ShowDialog() == DialogResult.OK)
				{
					this.pacienteId = formBuscar.idPaciente;
					// Utiliza el ID del paciente
					this.paciente = (new DatosPaciente()).buscarPacienteId(this.pacienteId);
					//MessageBox.Show("ID del paciente seleccionado: " + paciente.ToString()); 
					txtPaciente.Text = paciente.apellido + " " + paciente.nombre;
				}
			}
		}

		private void btnBuscarMedico_Click(object sender, EventArgs e)
		{
			using (frmBuscarMedico formBuscar = new frmBuscarMedico())
			{
				if (formBuscar.ShowDialog() == DialogResult.OK)
				{
					this.medicoId = formBuscar.idMedico;
                    // Utiliza el ID del medico
                    this.medico = (new DatosMedico()).buscarMedicoId(this.medicoId);
					//MessageBox.Show("ID del medico seleccionado: " + medico.ToString()); 					
                    txtMedico.Text = medico.apellido + " " + medico.nombre;
				}
			}
		}
	}
}
