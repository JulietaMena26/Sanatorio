using Sanatorio.Datos;
using Sanatorio.Interfaz;
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
            this.cmbEstado.SelectedIndex = 0;
        }

		public frmNewInternacion(Internacion internacion_)
        {
            InitializeComponent();
            mensajestoolTip();
            this.cargar_controles(internacion_);
            this.dateTimePickerFechIngreso.Focus();
            this.btnBuscar.Enabled = false;
            this.cmbEstado.Enabled = true;
            //this.dateTimePickerFechaAlta.Value = DateTime.Now;
            //this.dateTimePickerHoraAlta.Value = DateTime.Now;
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

            if (cmbMedico.SelectedIndex == -1 && string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show("Debe seleleccionar un medico", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbMedico.Focus();
                return false;
            }
            else if (!(cmbMedico.SelectedIndex == -1))
            {
                this.medicoId = (int)cmbMedico.SelectedValue;
			}

			//MessageBox.Show("ComboMEdico " + (cmbMedico.SelectedIndex));


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

        private void cargar_controles(Internacion _internacion)
        {
            txtId.Text = _internacion.idinternacion.ToString();
            dateTimePickerFechIngreso.Value = _internacion.fechaIngreso;
			dateTimePickerHoraIngreso.Value = _internacion.horaIngreso;
			cmbMedico.SelectedValue = _internacion.id_medico.ToString();
            this.medicoId = _internacion.id_medico; // gusrdamos el id del medico

			this.pacienteId = _internacion.id_paciente; // guardamos el id del paciente
			// Utiliza el ID del paciente
			this.paciente = (new DatosPaciente()).buscarPacienteId(this.pacienteId);
			//MessageBox.Show("ID del paciente seleccionado: " + paciente.ToString()); 
			txtPaciente.Text = paciente.apellido + " " + paciente.nombre;
            this.habitacionId = _internacion.id_habitacion; // guardamos el id de l habitacion
			cmbHabitacion.SelectedValue = _internacion.id_habitacion.ToString();
            txtMotivo.Text = _internacion.motivoInternacion;
			txtDiagnostico.Text = _internacion.diagnostico;
            chcDeuda.Checked = _internacion.deuda;
			cmbEstado.SelectedItem = _internacion.estado;
			
            dateTimePickerFechaAlta.Enabled = true;            
			dateTimePickerFechaAlta.Value = (DateTime)_internacion.fechaEgreso;
            dateTimePickerHoraAlta.Enabled = true;
			dateTimePickerHoraAlta.Value = (DateTime)_internacion.horaEgreso;

           // MessageBox.Show("Paciente:" + pacienteId + " Medico:" + medicoId + " habitacion:" + habitacionId  );
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

            internacion.idinternacion = string.IsNullOrEmpty(txtId.Text.Trim()) ? 0 : int.Parse(txtId.Text.Trim());

           	this.medicoId = this.medicoId; // guardamos el id del medico            
            																 
			internacion.fechaIngreso = dateTimePickerFechIngreso.Value;
            internacion.horaIngreso = dateTimePickerHoraIngreso.Value;
            internacion.id_medico =  this.medicoId;
            internacion.id_paciente = this.pacienteId;
            internacion.id_habitacion = (cmbHabitacion.SelectedIndex == -1) ? this.habitacionId : (int)cmbHabitacion.SelectedValue; // guardamos el id del habitacion
			internacion.motivoInternacion = txtMotivo.Text.Trim();
            internacion.diagnostico = txtDiagnostico.Text.Trim();
            internacion.deuda = chcDeuda.Checked;
            internacion.estado = cmbEstado.SelectedItem.ToString();
            internacion.fechaEgreso = string.IsNullOrEmpty(txtId.Text.Trim()) ? new DateTime(2000, 1, 1) : dateTimePickerFechaAlta.Value;
            internacion.horaEgreso = string.IsNullOrEmpty(txtId.Text.Trim()) ? new DateTime(2000, 1, 1, 0, 0, 0) : dateTimePickerHoraAlta.Value;
            internacion.activo = true;

            DatosInternacion datos = new DatosInternacion();


            if (string.IsNullOrEmpty(txtId.Text.Trim())) // si esta vacia el texbox txtId es porque se va crear una nueva internación
            {
                // Verificar que le paciente no este internado
                if (!datos.isInternadoPaciente(internacion.id_paciente))
                {
                    if (datos.guardarInternacion(internacion))
                    {
                        (new DatosHabitacion()).ocuparCama(internacion.id_habitacion); //cuando se Guarda Actualiza la cama disponible en la tabla Habitaciones
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
                MessageBox.Show("Se va actualizar"  + internacion.ToString());

                /* verificar si hay cambio de camas  para liberar la cama
                 * verificar si cambio el estado y si el estado es "Alta", dar de alta al paciente
                 * cambiar la fecha y hora.
                 *  
                 */

                if (!(cmbHabitacion.SelectedIndex == -1)) // si es -1 es porque no se selecciono una nueva habitación
                {
                    //MessageBox.Show("cama actual: " + internacion.id_habitacion + " Cama anterior: " + this.habitacionId);
					(new DatosHabitacion()).ocuparCama(internacion.id_habitacion); //cuando se "Actualiza" Actualiza la cama disponible en la tabla Habitaciones
                    (new DatosHabitacion()).liberarCama(this.habitacionId); // libera cama anterior 
				}
                //else
                //{
                //    MessageBox.Show("No se selecciono una nueva habitacion no se hace nada");
                //    MessageBox.Show("cama actual: " + internacion.id_habitacion + " Cama anterior: " + this.habitacionId);
                //}

                if ((new DatosInternacion()).actualizarInternacion(internacion))
                {					
					MessageBox.Show("Internación Actualizada", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    					
				}
                else
                {
					MessageBox.Show("No se puedo realizar la Actualización", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}

                if (internacion.estado == "Alta") // si la actualización fue dar de alta hay que liberar la cama
                {
					(new DatosHabitacion()).liberarCama(internacion.id_habitacion);
                    (new DatosInternacion()).altaInternacion(internacion.idinternacion);
				}
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
				dateTimePickerFechaAlta.Value = DateTime.Now; // O puedes dejar que el usuario corrija la fecha
			}
		}
	}
}
