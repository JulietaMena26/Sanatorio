using Sanatorio.Datos;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sanatorio.Vista
{
    public partial class frmNewInternacion : Form
    {
        private Paciente paciente;
        private int pacienteId { set; get; } // atributo para guardar el id del paciente 
        private int medicoId { set; get; } // atributo para guardar el id del medico
		private int habitacionId { set; get; } // atributo para guardar el id de la habitación


		private System.Windows.Forms.ToolTip toolTip;
        public frmNewInternacion()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		public frmNewInternacion(Internacion internacion_)
        {
            InitializeComponent();
            mensajestoolTip();
            
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new System.Windows.Forms.ToolTip();
            //toolTip.SetToolTip(txtHoraIngreso, "Solo ingrese números sin los puntos");
            //toolTip.SetToolTip(txtTelefono, "Solo ingrese números");           
        }
        public void cargar_combo_medico()
        {
			Dictionary<int, string> medicos = new Dictionary<int, string>();
            			
			foreach (DataRow fila in (new DatosMedico()).listarMedico().Rows)
			{
			    string nombreCompleto = fila["apellido"].ToString() + " " + fila["nombre"].ToString() + "-" + fila["dni"].ToString();
                medicos.Add((int)fila["idMedico"],nombreCompleto);
			}
			// Crear una lista de objetos para el ComboBox
			var listaMedicos = medicos.Select(m => new { Id = m.Key, Nombre = m.Value }).ToList();
			
            cmbMedico.DataSource = listaMedicos;
			cmbMedico.DisplayMember = "nombre"; // Muestra el valor (nombre completo)
			cmbMedico.ValueMember = "Id";   // Utiliza la clave (ID) como valor interno		
            cmbMedico.SelectedIndex = -1; // ningun Items queda seleccionado
            cmbMedico.Text = "-- Seleccionar el Medico --";
		}

        public void cargar_combo_camas_disponibles()
        {
			Dictionary<int, string> camas = new Dictionary<int, string>();

			foreach (DataRow fila in (new DatosHabitacion()).listarCamasDisponible().Rows)
			{
				string camaDisponible = "Número: " + fila["numero"].ToString() + " - Piso: " + fila["piso"].ToString() + " - Cama Disponible: " + fila["camaDisponible"].ToString();
				camas.Add((int)fila["idHabitacion"], camaDisponible);
			}
			// Crear una lista de objetos para el ComboBox
			var listaMedicos = camas.Select(m => new { Id = m.Key, cama = m.Value }).ToList();

			cmbHabitacion.DataSource = listaMedicos;
			cmbHabitacion.DisplayMember = "cama"; // Muestra el valor (nombre completo)
			cmbHabitacion.ValueMember = "Id";   // Utiliza la clave (ID) como valor interno		
			cmbHabitacion.SelectedIndex = -1; // ningun Items queda seleccionado
			cmbHabitacion.Text = "-- Seleccione la Habitación --";
		}
        
        private bool verificarControlesVacios() // verifica que los controles los txtbox no esten vacios
        {
            
            if (cmbMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleleccionar un medico", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbMedico.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPaciente.Text.Trim()))
            {
                MessageBox.Show("Debe buscar un Paciente", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnBuscar.Focus();              
                return false;
            }
            if (string.IsNullOrEmpty(txtMotivo.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar el Motivo de la Internacion", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtMotivo.Focus();
                return false;
            }
			
            if (string.IsNullOrEmpty(txtDiagnostico.Text.Trim()))
			{
				MessageBox.Show("Debe ingresar el diganostico", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtDiagnostico.Focus();
				return false;
			}

			if (cmbEstado.SelectedIndex == -1)
			{
				MessageBox.Show("Debe seleleccionar un Estado", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbEstado.Focus();
				return false;
			}
            return true;
        }
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            this.cargar_combo_medico();
            this.cargar_combo_camas_disponibles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
			if (!verificarControlesVacios()) // Verificar que los controles no esten vacios
            {
                return ;
            }

			Internacion internacion = new Internacion();

			this.medicoId = (int)cmbMedico.SelectedValue; // guardamos el id del medico
			this.habitacionId = (int)cmbHabitacion.SelectedValue; // guardamos el id del habitacion
																  // Cargamos con los datos la nueva internación
			internacion.fechaIngreso = dateTimePickerFechIngreso.Value;
            internacion.horaIngreso = dateTimePickerHoraIngreso.Value;
            internacion.id_medico =  this.medicoId;
            internacion.id_paciente = this.pacienteId;
            internacion.id_habitacion = this.habitacionId;
            internacion.motivoInternacion = txtMotivo.Text.Trim();
            internacion.diagnostico = txtDiagnostico.Text.Trim();
            internacion.deuda = chcDeuda.Checked;
            internacion.estado = cmbEstado.SelectedItem.ToString();
            internacion.fechaEgreso = null;
            internacion.horaEgreso = null;

            DatosInternacion datos = new DatosInternacion();


            if (string.IsNullOrEmpty(txtId.Text.Trim())) // si esta vacia el texbox txtId es porque se va crear una nueva internación
            {
                // Verificar que le paciente no este internado
                if (!datos.isInternadoPaciente(internacion.id_paciente))
                {
                    if (datos.guardarInternacion(internacion))
                    {
                        (new DatosHabitacion()).ocuparCama(this.habitacionId); // Actualiza la cama disponible en la tabla Habitaciones
                        MessageBox.Show("Se registro una nueva Internacion","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("No se pudo registrar la Internacion", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else 
                {
					MessageBox.Show("Paciente Esta Internado");
				}
            }
			else // NO esta vacia el texbox txtId entonces se va actualizar la internación
			{
                internacion.idinternacion = int.Parse(txtId.Text.Trim()); // obtengo el id de la internación para actualizar
            }

			this.Close();
		}       

        private void dateTimePickerFechaNaci_ValueChanged(object sender, EventArgs e)
        {
			// Obtener la hora del primer DateTimePicker
			TimeSpan hora = dateTimePickerFechIngreso.Value.TimeOfDay;
			// Asignar la hora al segundo DateTimePicker
			dateTimePickerHoraIngreso.Value = dateTimePickerHoraIngreso.Value.Date.Add(hora);

		}       

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			using (frmBuscarPaciente formBuscar = new frmBuscarPaciente())
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

		private void dateTimePickerFechaAlta_ValueChanged(object sender, EventArgs e)
		{
			// Obtener la hora del primer DateTimePicker
			TimeSpan hora = dateTimePickerFechaAlta.Value.TimeOfDay;
			// Asignar la hora al segundo DateTimePicker
			dateTimePickerHoraAlta.Value = dateTimePickerHoraAlta.Value.Date.Add(hora);

			// Si la fecha de alta es menor a la fecha de ingreso, mostramos un mensaje de error
			if (dateTimePickerFechaAlta.Value < dateTimePickerFechIngreso.Value)
			{
				MessageBox.Show("La fecha de alta no puede ser anterior a la fecha de ingreso.","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				dateTimePickerFechaAlta.Value = dateTimePickerFechIngreso.Value; // O puedes dejar que el usuario corrija la fecha
			}
		}
	}
}
