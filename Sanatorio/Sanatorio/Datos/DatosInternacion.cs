using MySql.Data.MySqlClient;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio.Datos
{
    public class DatosInternacion : IInternacion1
    {
		Conexion conexion = new Conexion();

		public bool actualizarInternacion(Internacion internacion)
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			// Obtener la fecha seleccionada en el DateTimePicker
			//DateTime fechaIngreso = internacion.fechaIngreso;
			// Obtener la hora seleccionada en el DateTimePicker
			//DateTime horaIngreso = internacion.horaIngreso.TimeOfDay;
			TimeSpan hora = internacion.horaEgreso.TimeOfDay;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_actualizar_internacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_", MySqlDbType.Int16).Value = internacion.idinternacion;
				command.Parameters.Add("_fechaIngreso", MySqlDbType.Date).Value = internacion.fechaIngreso.ToString("yyyy-MM-dd");
				command.Parameters.Add("_horaIngreso", MySqlDbType.Time).Value = internacion.horaIngreso.TimeOfDay;
				command.Parameters.Add("_id_medico", MySqlDbType.Int16).Value = internacion.id_medico;
				command.Parameters.Add("_id_paciente", MySqlDbType.Int16).Value = internacion.id_paciente;
				command.Parameters.Add("_id_habitacion", MySqlDbType.Int16).Value = internacion.id_habitacion;
				command.Parameters.Add("_motivoInternacion", MySqlDbType.VarChar).Value = internacion.motivoInternacion;
				command.Parameters.Add("_diagnostico", MySqlDbType.VarChar).Value = internacion.diagnostico;
				command.Parameters.Add("_deuda", MySqlDbType.Byte).Value = internacion.deuda;
				command.Parameters.Add("_estado", MySqlDbType.VarChar).Value = internacion.estado;
				
				command.Parameters.Add("_fechaEgreso", MySqlDbType.Date).Value = internacion.fechaEgreso;
				command.Parameters.Add("_horaEgreso", MySqlDbType.Time).Value = internacion.horaEgreso.TimeOfDay;
				command.Parameters.Add("_activo", MySqlDbType.Byte).Value = internacion.activo;
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

		public bool altaInternacion(int _idInternacion) // método utilizado para dar de alta una internación
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			DateTime fecha_ = DateTime.Now; // obtengo el dia del sistema
			TimeSpan hora_ = DateTime.Now.TimeOfDay; // obtengo la hora del sistema

			try
			{
				MySqlCommand command = new MySqlCommand("psa_alta_internacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_", MySqlDbType.Int16).Value = _idInternacion;
				command.Parameters.Add("fecha_", MySqlDbType.Date).Value = fecha_.ToString("yyyy-MM-dd");
				command.Parameters.Add("hora_", MySqlDbType.Time).Value = hora_;				
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

		public DataTable buscarFechaEgreso(DateTime fecha)
		{
			throw new NotImplementedException();
		}

		public DataTable buscarFechaIngreso(DateTime fecha)
		{
			throw new NotImplementedException();
		}

		public DataTable buscarFechaIngreso(DateTime ingreso, DateTime egreso)
		{
			throw new NotImplementedException();
		}

		public Internacion buscarInternacionId(int id) // Busca y devuelve una internación por el id
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			Internacion internacion = new Internacion();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_buscar_internacion_id", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int16).Value = id;
				SQLdatos.Open();
				resultado = command.ExecuteReader();
				while (resultado.Read())
				{
					internacion.idinternacion = resultado.GetInt16(0);
					string fechaString = resultado.GetString(1);
					internacion.fechaIngreso = resultado.GetDateTime(1); 
					string horaString = resultado.GetString(2);
					internacion.horaIngreso = DateTime.ParseExact(horaString, "HH:mm:ss", CultureInfo.InvariantCulture);
					internacion.id_medico = resultado.GetInt16(3);
					internacion.id_paciente = resultado.GetInt16(4);
					internacion.id_habitacion = resultado.GetInt16(5);
					internacion.motivoInternacion = resultado.GetString(6);
					internacion.diagnostico = resultado.GetString(7);
					internacion.deuda = resultado.GetBoolean(8);
					internacion.estado = resultado.GetString(9);

					if (!resultado.IsDBNull(resultado.GetOrdinal("fechaEgreso")))
					{
						internacion.fechaEgreso = resultado.GetDateTime(10);
					}
					else
					{
						internacion.fechaEgreso = new DateTime(2000, 1, 1); 
					}

					if (!resultado.IsDBNull(resultado.GetOrdinal("horaEgreso")))
					{
						horaString = resultado.GetString(11);
						internacion.horaEgreso = DateTime.ParseExact(horaString, "HH:mm:ss", CultureInfo.InvariantCulture);
					}
					else
					{
						internacion.horaEgreso = new DateTime(2000, 1, 1 , 0 , 0, 0);
					}					
					internacion.activo = resultado.GetBoolean(12);
					
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
			return internacion;
		}

		public DataTable buscarMedico(int id)
		{
			throw new NotImplementedException();
		}

		public DataTable buscarPaciente(int id)
		{
			throw new NotImplementedException();
		}

		public void eliminarInternacion(int idInternacion)
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;			

			try
			{
				MySqlCommand command = new MySqlCommand("psa_eliminar_internacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_", MySqlDbType.Int16).Value = idInternacion;				
				SQLdatos.Open();

				resultado = command.ExecuteNonQuery();
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
		public bool guardarInternacion(Internacion internacion)
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			// Obtener la fecha seleccionada en el DateTimePicker
			DateTime fechaIngreso = internacion.fechaIngreso;
			// Obtener la hora seleccionada en el DateTimePicker
			//DateTime horaIngreso = internacion.horaIngreso.TimeOfDay;
			TimeSpan hora = internacion.horaIngreso.TimeOfDay; 

			try
			{
				MySqlCommand command = new MySqlCommand("psa_guardar_internacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("fechaIngreso_", MySqlDbType.Date).Value = fechaIngreso.ToString("yyyy-MM-dd");
				command.Parameters.Add("horaIngreso_", MySqlDbType.Time).Value = hora;
				command.Parameters.Add("id_medico_", MySqlDbType.Int16).Value = internacion.id_medico;
				command.Parameters.Add("id_paciente_", MySqlDbType.Int16).Value = internacion.id_paciente;
				command.Parameters.Add("id_habitacion_", MySqlDbType.Int16).Value = internacion.id_habitacion;
				command.Parameters.Add("motivoInternacion_", MySqlDbType.VarChar).Value = internacion.motivoInternacion;
				command.Parameters.Add("diagnostico_", MySqlDbType.VarChar).Value = internacion.diagnostico;
				command.Parameters.Add("deuda_", MySqlDbType.Byte).Value = internacion.deuda;
				command.Parameters.Add("estado_", MySqlDbType.VarChar).Value = internacion.estado;
				command.Parameters.Add("fechaEgreso_", MySqlDbType.Date).Value = fechaIngreso.ToString("yyyy-MM-dd"); 
				command.Parameters.Add("horaEgreso_", MySqlDbType.Time).Value = hora;
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

		public bool isInternadoPaciente(int idPaciente) // método que busca un paciente, returna True si el paciente ya esta internado coso contrario retorna false
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			
			try
			{
				MySqlCommand command = new MySqlCommand("psa_buscar_paciente_internado", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int32).Value = idPaciente;
				SQLdatos.Open();

				resultado = command.ExecuteReader();
				while (resultado.Read())
				{
					return true; // retorna true si esta internado
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
			return false; // retorna false si no esta internado
		}

		public DataTable listarInternacion(string cTexto, string _estado) // retorna todo los pacientes que esten internado
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			DataTable table = new DataTable();
			MySqlDataReader resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listar_internados", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_estado", MySqlDbType.VarChar).Value = _estado;
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

