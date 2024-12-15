using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sanatorio.Datos;
using Sanatorio.Modelos;

namespace Sanatorio.Vista
{
    public partial class frmNewObrasocial : Form
    {
        private Conexion conexion = new Conexion();
        private ObraSocial obraSocial;
        public frmNewObrasocial()
        {
            InitializeComponent();
        }

		public frmNewObrasocial(ObraSocial _obraSocial)
		{
			InitializeComponent();
            this.obraSocial = _obraSocial;
            this.txtId.Text = _obraSocial.idSocial.ToString();
            this.txtCodigo.Text = _obraSocial.codigo;
            this.txtNombre.Text = _obraSocial.nombre;
            this.txtSigla.Text = _obraSocial.sigla;
            this.txtCodigo.Focus();
		}

		#region "Mis métodos"
		private bool verificarControlesVacios()
		{
			if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
				string.IsNullOrWhiteSpace(txtCodigo.Text))
			{
				MessageBox.Show("Por favor, complete todos los campos.");
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

            ObraSocial obraSocial = new ObraSocial();

            obraSocial.codigo =  txtCodigo.Text.Trim();
            obraSocial.nombre = txtNombre.Text.Trim();
            obraSocial.sigla = txtSigla.Text.Trim();

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                if ((new DatosObraSocial()).agregarObraSocial(obraSocial))
                {
                    MessageBox.Show("Obra Social Creada con Exito", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo crear la Obra Social", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                obraSocial.idSocial = int.Parse(txtId.Text.Trim());
				if ((new DatosObraSocial()).agregarObraSocial(obraSocial))
				{
					MessageBox.Show("Obra Social Actualizada con Exito", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("No se pudo Actualizar la Obra Social", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}           

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
