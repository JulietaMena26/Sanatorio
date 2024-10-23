using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;

namespace Sanatorio.Datos
{
    public class DatosPaciente : IPaciente1
    {
        Conexion conexion = new Conexion();
        public bool actualizarPaciente(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public bool agregarPaciente(Paciente _paciente)
        {
            throw new NotImplementedException();
        }

        public Paciente buscarPacienteDni(string dni)
        {
            throw new NotImplementedException();
        }

        public Paciente buscarPacienteId(int idpaciente)
        {
            throw new NotImplementedException();
        }

        public void eliminarPaciente(string dni)
        {
            throw new NotImplementedException();
        }

        public Paciente listadoPacienteApellido(string apellido)
        {
            throw new NotImplementedException();
        }

        public DataTable listarPaciente()
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command =  new MySqlCommand("psa_listadoPacientes" , SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                table.Load(resultado);
                command.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodolistpaciente", ex.ToString());
            }
            finally
            {
                if (SQLdatos.State == ConnectionState.Open)
                {
                    SQLdatos.Close();
                }
            }
            return table;
        }

        public List<Paciente> listarPacienteid_ObraSocial(int id_obraSocial)
        {
            throw new NotImplementedException();
        }
    }
}
