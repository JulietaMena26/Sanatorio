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

        #region 
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (!verificarControlesVacios())
            {
                return;
            }

            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {

                if (Registro_Clinico(txtId.Trim()))
                {
                    MessageBox.Show("El registro ya existe!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Focus();
                }
                else
                {
                    Registro_Clinico = new Registro_Clinico();
                    Registro_Clinico.IdRegistro = txtIdRegristro.text.trim();
                    Registro_Clinico.id_paciente = int.Parse(cmbPaciente.SelectedValues.ToString());
                    Registro_Clinico.id_medico = int.Parse(cmbPaciente.SelectedValues.ToString());
                    Registro_Clinico.fecha = dateTimePickerfecha();
                    Registro_Clinico.hora = datetimePickerhora();
                    Registro_Clinico.motivo = txtmotivo();
                    Registro_Clinico.diagnostico = txtdiagnostico();
                    Registro_Clinico.tratamiento = txttratamiento();
                    Registro_Clinico.proxima_visita = txtproxima_visita();
                    Registro_Clinico.observacion = txtobservacion();
                    DatosRegistroClinico datos = DatosRegistroClinico();
                    

                    if (datos.agregarRegistro(Registro_Clinico))
                    {
                        MessageBox.Show("Se agrego con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else // sucede si se esta por actualizar un cliente
            {
                Registro_Clinico = new Registro_Clinico();
                Registro_Clinico.IdRegistro = txtIdRegristro.text.trim();
                Registro_Clinico.id_paciente = int.Parse(cmbPaciente.SelectedValues.ToString());
                Registro_Clinico.id_medico = int.Parse(cmbPaciente.SelectedValues.ToString());
                Registro_Clinico.fecha = dateTimePickerfecha();
                Registro_Clinico.hora = datetimePickerhora();
                Registro_Clinico.motivo = txtmotivo();
                Registro_Clinico.diagnostico = txtdiagnostico();
                Registro_Clinico.tratamiento = txttratamiento();
                Registro_Clinico.proxima_visita = txtproxima_visita();
                Registro_Clinico.observacion = txtobservacion();
                DatosRegistroClinico datos = DatosRegistroClinico();


                if (datos.actualizarRegistro(Registro_Clinico))
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
    }
}

