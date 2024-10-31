using MySql.Data.MySqlClient;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Datos
{
    public class DatosTipoHabitacion : ITipoHabitacion1
    {
        Conexion conexion = new Conexion();

        public bool actualizarHabitacion(TipoHabitacion habi)
        {
            throw new NotImplementedException();
        }

        public bool agregarHabitacion(TipoHabitacion habi)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_tipohabitacion", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_descripcion", MySqlDbType.VarChar).Value = habi.descripcion;

                SQLdatos.Open();

                resultado = command.ExecuteNonQuery();
                if (resultado > 0)
                    return true;
                else
                    return false;

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
        }

        public void eliminarHabitacion(int _id)
        {
            throw new NotImplementedException();
        }

        public DataTable listarTipoHabitacion()
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listado_tipoHabitacion", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
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
    }
}
