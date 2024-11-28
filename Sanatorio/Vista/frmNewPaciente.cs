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

namespace Sanatorio.Vista
{
    public partial class frmNewPaciente : Form
    {
        private Paciente paciente;
        private ToolTip toolTip;
        public frmNewPaciente()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		public frmNewPaciente(Paciente paciente)
        {
            this.paciente = paciente;
            InitializeComponent();
            mensajestoolTip();
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
            toolTip.SetToolTip(txtDni, "Solo ingrese números sin los puntos");
            toolTip.SetToolTip(txtTelefono, "Solo ingrese números");           
        }
        public void cargar_combo_obraSocial()
        {
            DatosObraSocial datos = new DatosObraSocial();
            cmbObraSocial.DataSource = datos.listarObraSocial("%");
            cmbObraSocial.ValueMember = "idSocial";
            cmbObraSocial.DisplayMember = "nombre";            
        }

        private int CalcularEdad(DateTime fechaNacimiento) 
        { 
            int edad = DateTime.Now.Year - fechaNacimiento.Year; 
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear) 
            { 
                edad--; 
            } 
            return edad; 
        }

        private void verificarIsNumeros(KeyPressEventArgs e) // controla que solo ingresen números en dni y teléfono
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el evento }
            }
        }
        private void verificarIsCaracteres(KeyPressEventArgs e)
        {
            // Permite solo letras y la tecla de retroceso y el espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento
            }

        }
        private bool existePaciente(string dni_) // verifica si existe el paciente con el dni pasado como argumento.
        { 
            paciente = new Paciente();
            DatosPaciente datos = new DatosPaciente();
            paciente = datos.buscarPacienteDni(dni_);
          
            return !( 
                string.IsNullOrEmpty(paciente.dni) && 
                string.IsNullOrEmpty(paciente.apellido) &&
                string.IsNullOrEmpty(paciente.nombre) &&
                string.IsNullOrEmpty(paciente.domicilio) &&
                string.IsNullOrEmpty(paciente.telefono) &&
                string.IsNullOrEmpty(paciente.historiaClinica) &&
                string.IsNullOrEmpty(paciente.afiliado)
                );
        }

        private bool verificarControlesVacios() // verifica que los controles los txtbox no esten vacios
        {
            if ( string.IsNullOrEmpty(txtDni.Text.Trim())) 
            {
                MessageBox.Show("El DNI es dato obligatorio","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtDni.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                MessageBox.Show("El APELLIDO es dato obligatorio", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("El NOMBRE es dato obligatorio", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("El NOMBRE es dato obligatorio", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }

            // Validar la fecha
            if (dateTimePickerFechaNaci.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                dateTimePickerFechaNaci.Focus();
                return false;
            }

            if (cmbObraSocial.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Obra Social", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbObraSocial.Focus();
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
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (!verificarControlesVacios())
            {
                return ;
            }

           if (string.IsNullOrEmpty(txtId.Text.Trim()))
             {
                
                if (existePaciente(txtDni.Text.Trim()))
                {
                    MessageBox.Show("El paciente ya existe!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDni.Focus();
                }
                else 
                {                                        
                     paciente = new Paciente();
                     paciente.historiaClinica = txtHistoriClinica.Text.Trim(); 
                     paciente.dni = txtDni.Text.Trim();
                     paciente.apellido = txtApellido.Text.Trim();
                     paciente.nombre = txtNombre.Text.Trim();
                     paciente.fechaNaci = dateTimePickerFechaNaci.Value;
                     paciente.domicilio = txtDomicilio.Text.Trim();
                     paciente.telefono = txtTelefono.Text.Trim();
                     paciente.id_obraSocial = int.Parse(cmbObraSocial.SelectedValue.ToString());
                     paciente.afiliado = txtNunAfiliado.Text.Trim();
                     DatosPaciente datos = new DatosPaciente();

                     if (datos.agregarPaciente(paciente))
                     {
                        MessageBox.Show("Se agrego con exito!!","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     }
                     else
                     {
                        MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }                                          
                }                
            }
            else // sucede si se esta por actualizar un cliente
            {
				paciente = new Paciente();
                paciente.idPaciente = int.Parse(txtId.Text.Trim());
				paciente.historiaClinica = txtHistoriClinica.Text.Trim();
				paciente.dni = txtDni.Text.Trim();
				paciente.apellido = txtApellido.Text.Trim();
				paciente.nombre = txtNombre.Text.Trim();
				paciente.fechaNaci = dateTimePickerFechaNaci.Value;
				paciente.domicilio = txtDomicilio.Text.Trim();
				paciente.telefono = txtTelefono.Text.Trim();
				paciente.id_obraSocial = int.Parse(cmbObraSocial.SelectedValue.ToString());
				paciente.afiliado = txtNunAfiliado.Text.Trim();
				DatosPaciente datos = new DatosPaciente();

				if (datos.actualizarPaciente(paciente))
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

        private void cmbObraSocial_Click(object sender, EventArgs e)
        {
            cargar_combo_obraSocial();            
        }

        private void dateTimePickerFechaNaci_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateTimePickerFechaNaci.Value; 
            int edad = CalcularEdad(fechaNacimiento); 
            txtEdad.Text = edad.ToString();
            
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarIsNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarIsNumeros(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarIsCaracteres(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            verificarIsCaracteres(e);
        }
    }
}
