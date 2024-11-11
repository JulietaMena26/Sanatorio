using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;

namespace Sanatorio.Datos
{
    class DatosMedico : IMedico1
    {
        Conexion conexion = new Conexion();
        public bool actualizarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public bool agregarMedico(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Medico buscarMedicoDni(string dni)
        {
            throw new NotImplementedException();
        }

        public Medico buscarMedicoId(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarMedico(string dni)
        {
            throw new NotImplementedException();
        }

        public DataTable listadoMedicoApellido(string apellido)
        {
            throw new NotImplementedException();
        }

        public DataTable listarMedico( string texto)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listar_medicos", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = texto;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                table.Load(resultado);
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Funciones.Logs("Datos_metodolistpaciente", ex.ToString());
                throw ex;
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

        public DataTable listarMedicoXespecialidad(string especialidad)
        {
            throw new NotImplementedException();
        }
    }
}
