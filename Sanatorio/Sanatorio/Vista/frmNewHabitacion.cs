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
    public partial class frmNewHabitacion : Form
    {
        private Habitacion habitacion; 
        private ToolTip toolTip;
        public frmNewHabitacion()
        {
            InitializeComponent();
			// Crear instancia de
            toolTip = new ToolTip();
			
        }

        public frmNewHabitacion(Habitacion _habitacion)
        {
            InitializeComponent();
			// Crear instancia de
			toolTip = new ToolTip();
            this.txtId.Text = _habitacion.idHabitacion.ToString();
            this.txtNumero.Text = _habitacion.numero;
            this.txtPiso.Text = _habitacion.piso.ToString();
            this.txtCapacidad.Text = _habitacion.capacidad.ToString();
            this.cmbEstado.SelectedItem = _habitacion.estado;
            this.txtPrecio.Text = _habitacion.precio.ToString();
            this.txtComodidad.Text = _habitacion.comodidad;
            this.txtObservacion.Text = _habitacion.observacion;
            _habitacion.activo = true;
            habitacion = _habitacion;
            this.txtNumero.Focus();
		}

		#region "Mis Métodos"
		public void cargar_listBox_TipoHabitacion()
        {
            DatosTipoHabitacion tipo = new DatosTipoHabitacion();
            listBoxTipo.DataSource = tipo.listarTipoHabitacion("%");
            listBoxTipo.ValueMember = "idTipo";
            listBoxTipo.DisplayMember = "descripcion";  
            listBoxTipo.SelectedIndex = -1;
        }
        

        private void verificarIsNumeros(KeyPressEventArgs e) // controla que solo ingresen números 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el evento }
            }
        }
        private void verificarIsCaracteres(KeyPressEventArgs e) // controla que solo ingrese letras
        {
            // Permite solo letras y la tecla de retroceso y el espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento
            }

        }        

        private bool verificarControlesVacios() // verifica que los controles los txtbox no esten vacios
        {
            if ( string.IsNullOrEmpty(txtNumero.Text.Trim())) 
            {
                MessageBox.Show("El número de habitación es dato obligatorio","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNumero.Focus();
                return false;
            }            
            if (string.IsNullOrEmpty(txtCapacidad.Text.Trim()))
            {
                MessageBox.Show("El número de capas es obligatorio", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCapacidad.Focus();
                return false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado de la habitación", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbEstado.Focus();
                return false;
            }

            return true;
        }

		public bool EsHabitacionVacia(Habitacion habitacion) 
        { 
            if (habitacion == null) 
            { 
                return true; 
            } 
            if (habitacion.idHabitacion == 0 && 
                string.IsNullOrEmpty(habitacion.numero) && 
                habitacion.id_tipo == 0 && 
                habitacion.piso == 0 && 
                habitacion.capacidad == 0 && 
                string.IsNullOrEmpty(habitacion.estado) && 
                habitacion.precio == 0 && 
                string.IsNullOrEmpty(habitacion.comodidad) && 
                string.IsNullOrEmpty(habitacion.observacion) && 
                !habitacion.activo) 
            { 
                return true; 
            } 
            return false; 
        }

		#endregion
		private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            this.cargar_listBox_TipoHabitacion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!verificarControlesVacios())
            {
                return;
            }
            // MessageBox.Show("listo para guarar controles cargados");
            if (string.IsNullOrEmpty(txtId.Text.Trim())) // controlamos si se va crear una habitacion nueva
            {
                //MessageBox.Show("habitacion nnueva");

                if (!this.EsHabitacionVacia((new DatosHabitacion()).buscarHabitacionNumero(txtNumero.Text.Trim()))) // verificar si el numero de habitacion ya existe
                {
                    MessageBox.Show("La habitación ya existe!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Focus();
                }
                else // Sucede si la habitacion no existe crea la nueva 
                {

                    habitacion = new Habitacion();
                    habitacion.numero = txtNumero.Text.Trim();
					habitacion.id_tipo = listBoxTipo.SelectedIndex != -1 ? int.Parse(listBoxTipo.SelectedValue.ToString()) : 7;
					habitacion.piso = string.IsNullOrEmpty(txtPiso.Text.Trim()) ? 0 : int.Parse(txtPiso.Text.Trim());
                    habitacion.capacidad = int.Parse(txtCapacidad.Text.Trim());
                    habitacion.estado = cmbEstado.SelectedItem.ToString();
                    habitacion.precio = string.IsNullOrEmpty(txtPrecio.Text.Trim()) ? 0 : decimal.Parse(txtPrecio.Text.Trim());
                    habitacion.comodidad = string.IsNullOrEmpty(txtComodidad.Text.Trim()) ? "" : txtComodidad.Text.Trim();
                    habitacion.observacion = string.IsNullOrEmpty(txtObservacion.Text.Trim()) ? "" : txtObservacion.Text.Trim();
					DatosHabitacion datos = new DatosHabitacion();
                    //MessageBox.Show(habitacion.ToString());

                    if (datos.agregarHabitacion(habitacion))
                    {
                        MessageBox.Show("Se agrego con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    datos = null;
                }
            }
            else // sucede si se actualiaz la habitacion
                {
				//MessageBox.Show(habitacion.ToString());
				habitacion.numero = txtNumero.Text.Trim();
				habitacion.id_tipo = listBoxTipo.SelectedIndex != -1 ? int.Parse(listBoxTipo.SelectedValue.ToString()) : habitacion.id_tipo;
				habitacion.piso = string.IsNullOrEmpty(txtPiso.Text.Trim()) ? 0 : int.Parse(txtPiso.Text.Trim());
				habitacion.capacidad = int.Parse(txtCapacidad.Text.Trim());
				habitacion.estado = cmbEstado.SelectedItem.ToString();
				habitacion.precio = string.IsNullOrEmpty(txtPrecio.Text.Trim()) ? 0 : decimal.Parse(txtPrecio.Text.Trim());
				habitacion.comodidad = string.IsNullOrEmpty(txtComodidad.Text.Trim()) ? "" : txtComodidad.Text.Trim();
				habitacion.observacion = string.IsNullOrEmpty(txtObservacion.Text.Trim()) ? "" : txtObservacion.Text.Trim();
                DatosHabitacion datos = new DatosHabitacion();
				if (datos.actualizarHabitacion(habitacion))
				{
					MessageBox.Show("Se Actualizo con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Error al Actualizar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				datos = null;
			}
            habitacion = null;
            this.Close();
        }           

		private void listBoxTipo_MouseMove(object sender, MouseEventArgs e) // se utiliza para mostrar en el tooltipo el items
		{
			// Obtener el índice del ítem debajo del cursor
            int index = listBoxTipo.IndexFromPoint(e.Location); 
            if (index != ListBox.NoMatches) 
            { 
                // Obtener el ítem en el índice
                DataRowView dataRowView = (DataRowView)listBoxTipo.Items[index]; 
                string itemText = dataRowView["descripcion"].ToString(); // Reemplaza el nombre de la columna que deseas mostrar 
                // Mostrar el ToolTip con el texto del ítem
                toolTip.SetToolTip(listBoxTipo, itemText); 
            }
		}

		private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.verificarIsNumeros(e);
		}

		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
            this.verificarIsNumeros(e);
		}

		private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
		{
            this.verificarIsNumeros(e);
		}
	}
}
