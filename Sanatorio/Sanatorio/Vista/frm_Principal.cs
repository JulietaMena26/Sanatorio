using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanatorio.Vista;
using System.Runtime.InteropServices;

namespace Sanatorio
{
    public partial class frm_Principal : Form
    {
        private ToolTip toolTip;
        public frm_Principal()
        {
            InitializeComponent();
            // Crear instancia de ToolTip ToolTip
            toolTip = new ToolTip(); 
            // Configurar mensaje del ToolTip para un botón
            toolTip.SetToolTip(btnPaciente, "Precione F9");
        }

        #region "Mis métodos"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg,int wparam,int lparam);

        private void abrirFormEnPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form ventana = formHijo as Form;
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(ventana);
            this.panelContenedor.Tag = ventana;
            ventana.Show(); 
            ventana.Focus();

        }



        #endregion

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 250)
            {
                panelMenuVertical.Width = 70;
            }
            else
            {
                panelMenuVertical.Width = 250;
            }
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);            
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new frmPaciente());
        }

        private void frm_Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                this.btnPaciente_Click(sender,e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new frmTipoHabitacion());
        }

		private void button2_Click(object sender, EventArgs e)
		{
			abrirFormEnPanel(new frmHabitaciones());
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void btnMedico_Click(object sender, EventArgs e)
        {
            abrirFormEnPanel(new frmMedicos());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
