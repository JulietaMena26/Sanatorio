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
    public class DatosObraSocial : IObraSocial1
    {
        Conexion conexion = new Conexion();
        public bool actualizarObraSocial(ObraSocial _obrasocial)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_obrasocial", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("id_", MySqlDbType.Int32).Value = _obrasocial.idSocial;
				command.Parameters.Add("codigo_", MySqlDbType.VarChar).Value = _obrasocial.codigo;
				command.Parameters.Add("nombre_", MySqlDbType.VarChar).Value = _obrasocial.nombre;
				command.Parameters.Add("sigla_", MySqlDbType.VarChar).Value = _obrasocial.sigla;

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

        public bool agregarObraSocial(ObraSocial _obrasocial)
        {
                MySqlConnection SQLdatos = new MySqlConnection();
                SQLdatos = conexion.crearConexion();
                int resultado;

                try
                {
                    MySqlCommand command = new MySqlCommand("psa_guardar_obrasocial", SQLdatos);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("codigo_", MySqlDbType.VarChar).Value = _obrasocial.codigo;
                    command.Parameters.Add("nombre_", MySqlDbType.VarChar).Value = _obrasocial.nombre;
			     	command.Parameters.Add("sigla_", MySqlDbType.VarChar).Value = _obrasocial.sigla;
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

        public ObraSocial buscaridSocial(int idSocial)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			ObraSocial obrasocial = new ObraSocial();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_buscar_obrasocial_id", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_", MySqlDbType.VarChar).Value = idSocial;
				SQLdatos.Open();

				resultado = command.ExecuteReader();
				while (resultado.Read())
				{
					obrasocial.idSocial = resultado.GetInt32(0);
					obrasocial.codigo = resultado.GetString(1);
					obrasocial.nombre = resultado.GetString(2);
					obrasocial.activo = resultado.GetBoolean(3);
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
			return obrasocial;
		}

        public ObraSocial buscaridSocial(string codigo)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			ObraSocial obrasocial = new ObraSocial();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_buscar_obrasocial_codigo", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("codigo_", MySqlDbType.VarChar).Value = codigo;
				SQLdatos.Open();

				resultado = command.ExecuteReader();				
				while (resultado.Read())
				{
                    obrasocial.idSocial = resultado.GetInt32(0);
                    obrasocial.codigo = resultado.GetString(1);
                    obrasocial.nombre = resultado.GetString(2);
                    obrasocial.sigla = resultado.GetString(3);
                    obrasocial.activo = resultado.GetBoolean(3);
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
			return obrasocial;
		}

        public void eliminarObraSocial(int idObraSocial)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_eliminar_obrasocial", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_", MySqlDbType.Int32).Value = idObraSocial;				

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

        public DataTable listaNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public DataTable listarObraSocial()
        {
            throw new NotImplementedException();
        }

        public DataTable listarObraSocial(string cTexto)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listado_obra_sociales", SQLdatos);
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
