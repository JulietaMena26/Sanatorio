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

namespace Sanatorio.Vista
{
    public partial class frmNewMedico : Form
    {
        private Medico medico;
        private ToolTip toolTip;
        public frmNewMedico()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		public frmNewMedico(Medico medico_)
        {
            this.medico = medico_;
            InitializeComponent();
            mensajestoolTip();

            txtId.Text = medico.idMedico.ToString();
            txtDNI.Text = medico.dni;
            txtCuil.Text = medico.cuil;
            txtApellido.Text = medico.apellido;
            txtNombre.Text = medico.nombre;
            txtCelular.Text = medico.celular;
            txtTelefono.Text = medico.telefono;
            txtDireccion.Text = medico.direccion;
            txtEmail.Text = medico.email;
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
			toolTip.SetToolTip(txtDNI, "Solo ingrese números sin los puntos");
			toolTip.SetToolTip(txtCuil, "Solo ingrese números sin los puntos");
            toolTip.SetToolTip(txtTelefono, "Solo ingrese números");
			toolTip.SetToolTip(txtCelular, "Solo ingrese números");
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
        private bool existeMedico(string dni_) // verifica si existe un medico
        { 
            medico = new Medico();
            DatosMedico datos = new DatosMedico();
            medico = datos.buscarMedicoDni(dni_);
          
            return !( 
                string.IsNullOrEmpty(medico.dni) &&
				string.IsNullOrEmpty(medico.cuil) &&
				string.IsNullOrEmpty(medico.apellido) &&
                string.IsNullOrEmpty(medico.nombre) &&
                string.IsNullOrEmpty(medico.celular) &&
                string.IsNullOrEmpty(medico.telefono) &&
                string.IsNullOrEmpty(medico.direccion) &&
                string.IsNullOrEmpty(medico.email)
                );
        }

        private bool verificarControlesVacios() // verifica que los controles los txtbox no esten vacios
        {
            if ( string.IsNullOrEmpty(txtDNI.Text.Trim())) 
            {
                MessageBox.Show("El DNI es dato obligatorio","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtDNI.Focus();
                return false;
            }
			if (string.IsNullOrEmpty(txtCuil.Text.Trim()))
			{
				MessageBox.Show("El CUIL es dato obligatorio", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCuil.Focus();
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

           if (string.IsNullOrEmpty(txtId.Text.Trim())) // Si el textBox no tiene datos entonces es un nuevo medico
             {
                
                if (this.existeMedico(txtDNI.Text.Trim())) // BUscar un medico si existe
                {
                    MessageBox.Show("El Medico ya existe!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCuil.Focus();
                }
                else 
                {                                        
                     medico = new Medico();
					 medico.dni = txtDNI.Text.Trim();
                     medico.cuil = txtCuil.Text.Trim();
                     medico.apellido = txtApellido.Text.Trim();
                     medico.nombre = txtNombre.Text.Trim();
                     medico.celular = txtCelular.Text.Trim();
                     medico.telefono = txtTelefono.Text.Trim();
                     medico.direccion = txtDireccion.Text.Trim();
                     medico.email = txtEmail.Text.Trim();
                     DatosMedico datos = new DatosMedico();

                     if (datos.agregarMedico(medico))
                     {
                        MessageBox.Show("Se agrego con exito!!","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     }
                     else
                     {
                        MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }                                          
                }                
            }
            else // sucede si se esta por actualizar un medico
            {
				medico = new Medico();
                medico.idMedico = int.Parse(txtId.Text.Trim());
				medico.dni = txtDNI.Text.Trim();
				medico.cuil = txtCuil.Text.Trim();
				medico.apellido = txtApellido.Text.Trim();
				medico.nombre = txtNombre.Text.Trim();
				medico.celular = txtCelular.Text.Trim();
				medico.telefono = txtTelefono.Text.Trim();
				medico.direccion = txtDireccion.Text.Trim();
				medico.email = txtEmail.Text.Trim();
				DatosMedico datos = new DatosMedico();

				if (datos.actualizarMedico(medico))
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

		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
            this.verificarIsNumeros(e);
		}

		private void txtCuil_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.verificarIsNumeros(e);
		}

		private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.verificarIsNumeros(e);
		}

		private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.verificarIsNumeros(e);
		}

		private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
		{
            this.verificarIsCaracteres(e);
		}

		private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.verificarIsCaracteres(e);
		}
	}
}
