using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sanatorio.Datos;
using Sanatorio.Modelos;

namespace Sanatorio.Vista
{
    public partial class frmNewRegistros : Form
    {
        Conexion conexion = new Conexion();
        public frmNewRegistros()
        {
            InitializeComponent();
        }

        private void frmNewRegsitros_Load(object sender, EventArgs e)
        {

        }

        #region "MIs metodos"

        private bool verificarControlesVacios()
        {

            return true;


        }


        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (!verificarControlesVacios())
            {
                return;
            }

            //if (string.IsNullOrEmpty(txtId.Text.Trim()))
            //{

            //    if (Registro_Clinico(txtId.Trim()))
            //    {
            //        MessageBox.Show("El registro ya existe!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtId.Focus();
            //    }
            //    else
            //    {
            Registro_Clinico registro = new Registro_Clinico();
            registro.idRegistro = int.Parse(txtIdRegistro.Text.Trim());
            registro.id_paciente = int.Parse(txtIdPaciente.Text.Trim());
            registro.id_medico = int.Parse(txtIdPaciente.Text.Trim());
            registro.fecha = dateTimePickerFechaNaci.Value;
            registro.hora = dateTimePicker1.Value;
            registro.motivo = txtMotivo.Text.Trim();
            registro.diagnostico = txtdiagnostico.Text.Trim();
            registro.tratamiento = txttratamiento.Text.Trim();
            registro.proxima_visita = txtproxima_visita.Value;
            registro.observacion = cmbObservacion.Text.Trim();
            DatosRegistroClinico datos = new DatosRegistroClinico();


            if (datos.agregarRegistro(registro))
            {
                MessageBox.Show("Se agrego con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //    }
            //}
            //else // sucede si se esta por actualizar un cliente
            //{
              Registro_Clinico registros = new Registro_Clinico();
              registros.idRegistro = int.Parse(txtIdRegistro.Text.Trim());
              registros.id_paciente = int.Parse(txtIdPaciente.Text.Trim());
              registros.id_medico = int.Parse(txtIdPaciente.Text.Trim());
              registros.fecha = dateTimePickerFechaNaci.Value;
              registros.hora = dateTimePicker1.Value;
              registros.motivo = txtMotivo.Text.Trim();
              registros.diagnostico = txtdiagnostico.Text.Trim();
              registros.tratamiento = txttratamiento.Text.Trim();
              registros.proxima_visita = txtproxima_visita.Value;
              registros.observacion = cmbObservacion.Text.Trim();
              DatosRegistroClinico Datos = new DatosRegistroClinico();


             if (datos.actualizarRegistro(registros))
                {
                    MessageBox.Show("Se actualizo con exito!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al Actualizar!!", "Sistema Santa Rita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
