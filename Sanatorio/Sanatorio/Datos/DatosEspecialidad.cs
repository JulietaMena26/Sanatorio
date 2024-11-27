using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.CryptoPro;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Datos
{
    public class DatosEspecialidad : IEspecialidad1
    {
		Conexion conexion = new Conexion();
		public bool actualizarEspecialidad(Especialidad _especialidad)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_especialidad", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", MySqlDbType.Int32).Value = _especialidad.idEspecialidad;
                command.Parameters.Add("especialidad", MySqlDbType.VarChar).Value = _especialidad.especialidad;
                command.Parameters.Add("_descripcion", MySqlDbType.VarChar).Value = _especialidad.descripcion;
                SQLdatos.Open();

                resultado = command.ExecuteNonQuery();
                if (resultado > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                //Funciones.Logs("actualizar_paciente", ex.ToString());
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

        public bool agregarEspecialidad(Especialidad _especialidad)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_pacientes", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
               // command.Parameters.Add("_id", MySqlDbType.VarChar).Value = _especialidad._id;
                command.Parameters.Add("_id_especialidad", MySqlDbType.VarChar).Value = _especialidad.especialidad;
                command.Parameters.Add("_id_medico", MySqlDbType.VarChar).Value = _especialidad.descripcion;
            
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

        public DataTable buscarEspecialidad(string Especialidad)
        {
            throw new NotImplementedException();
        }

        public Especialidad buscarEspecialidadId(int id)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            Especialidad esp = new Especialidad();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_especiadlidad_id", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", MySqlDbType.VarChar).Value = id;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                while (resultado.Read())
                {
                    esp.idEspecialidad = resultado.GetInt32(0);
                    esp.especialidad= resultado.GetString(1);
                    esp.descripcion = resultado.GetString(2);

                }


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
            return esp;
        }

        public void eliminarEspecialidad(int id)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_eliminar_especialidad", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", MySqlDbType.Int32).Value = id;
                SQLdatos.Open();

                resultado = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Funciones.Logs("actualizar_paciente", ex.ToString());
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

        public DataTable listarEspecialidad(string cTexto)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listar_especialidad", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
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
