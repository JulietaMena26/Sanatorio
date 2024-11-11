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
    public partial class frmNewTipoHabitacion : Form
    {
        private TipoHabitacion tipo;
        private ToolTip toolTip;
        public frmNewTipoHabitacion()
        {
            InitializeComponent();
            mensajestoolTip();
        }

        public frmNewTipoHabitacion(TipoHabitacion _tipo)
        {
            this.tipo = _tipo;
            InitializeComponent();
            //mensajestoolTip();
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
            //toolTip.SetToolTip(txtDni, "Solo ingrese números sin los puntos");
            //toolTip.SetToolTip(txtTelefono, "Solo ingrese números");           
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
            //paciente = new Paciente();
            //DatosPaciente datos = new DatosPaciente();
            //paciente = datos.buscarPacienteDni(dni_);

            //return !( 
            //    string.IsNullOrEmpty(paciente.dni) && 
            //    string.IsNullOrEmpty(paciente.apellido) &&
            //    string.IsNullOrEmpty(paciente.nombre) &&
            //    string.IsNullOrEmpty(paciente.domicilio) &&
            //    string.IsNullOrEmpty(paciente.telefono) &&
            //    string.IsNullOrEmpty(paciente.historiaClinica) &&
            //    string.IsNullOrEmpty(paciente.afiliado)
            //    );

            return true;
        }

        private bool verificarControlesVacios() // verifica que los controles los txtbox no esten vacios
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                MessageBox.Show("Debe Ingresar una descripción", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
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
           
			if (verificarControlesVacios())
            {
				DatosTipoHabitacion tipo = new DatosTipoHabitacion();
				if (string.IsNullOrEmpty(txtId.Text.Trim())) // Si el textBox id esta vacio es nuevo
                {
					if (tipo.agregarHabitacion(new TipoHabitacion(txtDescripcion.Text.Trim())))
					{
						MessageBox.Show("Los Datos se Guardaron correctamente", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show("Los Datos NO Guardaron correctamente", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
					}
				}
                else // si hay dato en el txt id es actualizar
                {
					if (tipo.actualizarHabitacion(new TipoHabitacion(int.Parse(txtId.Text.Trim()),txtDescripcion.Text.Trim())))
					{
						MessageBox.Show("Los Datos se Actualizaron correctamente", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show("Los Datos NO se Actualizaron correctamente", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
					}
				}		
            }            
        }

        
    }
}
