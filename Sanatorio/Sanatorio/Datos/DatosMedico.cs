using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
        public bool actualizarMedico(Medico _medico)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("id_", MySqlDbType.Int32).Value = _medico.idMedico;
                command.Parameters.Add("dni_", MySqlDbType.VarChar).Value = _medico.dni;
				command.Parameters.Add("cuil_", MySqlDbType.VarChar).Value = _medico.cuil;
				command.Parameters.Add("apellido_", MySqlDbType.VarChar).Value = _medico.apellido;
                command.Parameters.Add("nombre_", MySqlDbType.VarChar).Value = _medico.nombre;
				command.Parameters.Add("celular_", MySqlDbType.VarChar).Value = _medico.celular;
				command.Parameters.Add("telefono_", MySqlDbType.VarChar).Value = _medico.telefono;
				command.Parameters.Add("direccion_", MySqlDbType.VarChar).Value = _medico.direccion;
				command.Parameters.Add("email_", MySqlDbType.VarChar).Value = _medico.email;

				SQLdatos.Open();
                resultado = command.ExecuteNonQuery();
                if (resultado > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Funciones.Logs("actualizar_medico", ex.ToString());
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

        public bool agregarMedico(Medico _medico)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("dni_", MySqlDbType.VarChar).Value = _medico.dni;
				command.Parameters.Add("cuil_", MySqlDbType.VarChar).Value = _medico.cuil;
				command.Parameters.Add("apellido_", MySqlDbType.VarChar).Value = _medico.apellido;
                command.Parameters.Add("nombre_", MySqlDbType.VarChar).Value = _medico.nombre;
                command.Parameters.Add("celular_", MySqlDbType.VarChar).Value = _medico.celular;
                command.Parameters.Add("telefono_", MySqlDbType.VarChar).Value = _medico.telefono;
                command.Parameters.Add("direccion_", MySqlDbType.VarChar).Value = _medico.direccion;
                command.Parameters.Add("email_", MySqlDbType.VarChar).Value = _medico.email;
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

        public Medico buscarMedicoDni(string dni)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            Medico medico = new Medico();
			try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_medico_dni", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = dni;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                while (resultado.Read())
                {
                   
					medico.idMedico = resultado.GetInt32(0);
					medico.dni = resultado.GetString(1);
					medico.cuil = resultado.GetString(2);
					medico.apellido = resultado.GetString(3);
					medico.nombre = resultado.GetString(4);
					medico.celular = resultado.GetString(5);
					medico.telefono = resultado.GetString(6);
					medico.direccion = resultado.GetString(7);
					medico.email = resultado.GetString(8);
                    medico.activo = true;
                 
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
            return medico;
        }   

        public Medico buscarMedicoId(int id)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			Medico medico = new Medico();
			try
			{
				MySqlCommand command = new MySqlCommand("psa_buscar_medico_id", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int32).Value = id;
				SQLdatos.Open();

				resultado = command.ExecuteReader();
				while (resultado.Read())
				{
                    medico.idMedico = resultado.GetInt32(0);
					medico.dni = resultado.GetString(1);
					medico.cuil = resultado.GetString(2);
					medico.apellido = resultado.GetString(3);
					medico.nombre = resultado.GetString(4);
					medico.celular = resultado.GetString(5);
					medico.telefono = resultado.GetString(6);
					medico.direccion = resultado.GetString(7);
					medico.email = resultado.GetString(8);
					medico.activo = true;
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
			return medico;
		}

        public void eliminarMedico(int id)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_eliminar_medico", SQLdatos);
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

        public DataTable listadoMedicoApellido(string apellido)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = apellido;
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
    
        public DataTable listarMedico(string texto)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listar_Medicos", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = texto;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                table.Load(resultado);
    //            int numero = table.Rows.Count;
				//Funciones.Logs("numerofilas", table.Rows.Count.ToString());
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

		public DataTable listarMedico() // Lista los medico sin especialidad
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listar_todos_Medicos", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;				
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
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = especialidad;
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
