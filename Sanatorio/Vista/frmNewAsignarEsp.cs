using Sanatorio.Datos;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;
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

namespace Sanatorio.Vista
{
    public partial class frmNewAsignarEsp : Form
    {
        private Medico medico;
        private ToolTip toolTip;
        public frmNewAsignarEsp()
        {
            InitializeComponent();
            mensajestoolTip();
        }

		public frmNewAsignarEsp(Medico medico_)
        {
            this.medico = medico_;
            InitializeComponent();
            mensajestoolTip();
                     
        }

        #region "Mis Métodos"
        private void mensajestoolTip()
        {
            toolTip = new ToolTip();
			toolTip.SetToolTip(txtMatricula, "Ingrese la matricula");			
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
       

        private bool verificarControlesVacios() // verifica que los controles los txtbox no esten vacios
        {
            if (!(dataGridMedico.SelectedRows.Count > 0))
			{
				MessageBox.Show("Seleccione una Medico","Sistema Santa Rita",MessageBoxButtons.OK,MessageBoxIcon.Information);
      			return false;
			}

			if (!(dataGridEspecialidad.SelectedRows.Count > 0))
			{
				MessageBox.Show("Seleccione una Especialidad","Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (string.IsNullOrEmpty(txtMatricula.Text.Trim()))
			{
				MessageBox.Show("El número de matricula es dato obligatorio", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtMatricula.Focus();
				return false;
			}
			return true;
        }

		private void listar_Especialidad(string texto)
		{

			dataGridEspecialidad.Rows.Clear();
			try
			{
				DataTable tabla = new DataTable();
				tabla = (new DatosEspecialidad()).listarEspecialidad(texto);

				foreach (DataRow fila in tabla.Rows)
				{
					dataGridEspecialidad.Rows.Add(fila[0], fila[1], fila[2]);
				}
			}

			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + " " + ex.StackTrace);
				throw ex;
			}
			dataGridEspecialidad.ClearSelection();

		}

		private void listado_Medico()
		{
			dataGridMedico.Rows.Clear();
			try
			{
				DataTable tabla = new DataTable();
				tabla = (new DatosMedico()).listarMedico();

				foreach (DataRow fila in tabla.Rows)
				{
					dataGridMedico.Rows.Add(fila[0], fila[1], fila[3], fila[4]);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + " " + ex.StackTrace);
				// throw ex;
			}
			dataGridMedico.ClearSelection();
		}

		#endregion
		private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
			this.listar_Especialidad("%");
			this.listado_Medico();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (!verificarControlesVacios())
            {
                return ;
            }

			EspecialidadMedico especialidad = new EspecialidadMedico();
			especialidad.id_medico = int.Parse(dataGridMedico.CurrentRow.Cells[0].Value.ToString());
			especialidad.id_especialidad = int.Parse(dataGridEspecialidad.CurrentRow.Cells[0].Value.ToString());
			especialidad.matricula = txtMatricula.Text.Trim();

			DatosEspecialidadMedico datos = new DatosEspecialidadMedico();

			if (datos.guardarEspecialidaMedico(especialidad))
			{
				MessageBox.Show("Se agrego con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Close();
		}	
		
	}
}
