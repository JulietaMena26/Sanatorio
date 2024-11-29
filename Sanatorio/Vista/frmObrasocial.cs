using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sanatorio.Datos;

namespace Sanatorio.Vista
{
    public partial class frmObrasocial : Form
    {
        Conexion conexion = new Conexion();
        public frmObrasocial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MySqlCommand command = new MySqlCommand("psa_agregar_obrasocial", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("pCodigo", txtCodigo.Text.Trim());
                command.Parameters.AddWithValue("pNombre", txtNombre.Text.Trim());
                command.Parameters.AddWithValue("pActivo", 1); 

                command.ExecuteNonQuery();
                MessageBox.Show("Obra social agregada con éxito.", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
