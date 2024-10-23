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
using Sanatorio.Vista;

namespace Sanatorio
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

       

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente ventana = new frmPaciente();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
