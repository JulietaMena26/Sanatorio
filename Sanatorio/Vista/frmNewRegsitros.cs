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

namespace Sanatorio.Vista
{
    public partial class frmNewRegsitros : Form
    {
        Conexion conexion = new Conexion();
        public frmNewRegsitros()
        {
            InitializeComponent();
        }

        private void frmNewRegsitros_Load(object sender, EventArgs e)
        {

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
                MySqlCommand command = new MySqlCommand("psa_guardar_registros_clinicos", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;

               // command.Parameters.AddWithValue("pCodigo", txtCodigo.Text.Trim());
               // command.Parameters.AddWithValue("pNombre", txtNombre.Text.Trim());
                command.Parameters.AddWithValue("pActivo", 1);

                command.ExecuteNonQuery();
                MessageBox.Show("Registro clinico agregada con éxito.", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        private bool verificarControlesVacios()
        {
            //if (//string.IsNullOrWhiteSpace(txtNombre.Text) ||
               // string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
    }
}
