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
    public class DatosHabitacion : IHabitacion1
    {
		Conexion conexion = new Conexion();

		public bool actualizarHabitacion(Habitacion habitacion) // Actualiza los datos de la habitación
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_actualizar_habitacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.VarChar).Value = habitacion.idHabitacion;
				command.Parameters.Add("_numero", MySqlDbType.VarChar).Value = habitacion.numero;
				command.Parameters.Add("_id_tipo", MySqlDbType.Int32).Value = habitacion.id_tipo;
				command.Parameters.Add("_piso", MySqlDbType.Int32).Value = habitacion.piso;
				command.Parameters.Add("_capacidad", MySqlDbType.Int32).Value = habitacion.capacidad;
				command.Parameters.Add("_estado", MySqlDbType.VarChar).Value = habitacion.estado;
				command.Parameters.Add("_precio", MySqlDbType.Decimal).Value = habitacion.precio;
				command.Parameters.Add("_comodidad", MySqlDbType.VarChar).Value = habitacion.comodidad;
				command.Parameters.Add("_observacion", MySqlDbType.VarChar).Value = habitacion.observacion;
				SQLdatos.Open();
				resultado = command.ExecuteNonQuery();
				command.Dispose();
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

		public bool agregarHabitacion(Habitacion habitacion) // crea una nueva habitacion en la base de datos
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;			

			try
			{
				MySqlCommand command = new MySqlCommand("psa_guardar_habitacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_numero", MySqlDbType.VarChar).Value = habitacion.numero ;
				command.Parameters.Add("_id_tipo", MySqlDbType.Int32).Value = habitacion.id_tipo;
				command.Parameters.Add("_piso", MySqlDbType.Int32).Value = habitacion.piso;
				command.Parameters.Add("_capacidad", MySqlDbType.Int32).Value = habitacion.capacidad;
				command.Parameters.Add("_estado", MySqlDbType.VarChar).Value = habitacion.estado;
				command.Parameters.Add("_precio", MySqlDbType.Decimal).Value = habitacion.precio;
				command.Parameters.Add("_comodidad", MySqlDbType.VarChar).Value = habitacion.comodidad;
				command.Parameters.Add("_observacion", MySqlDbType.VarChar).Value = habitacion.observacion;
				SQLdatos.Open();
				resultado = command.ExecuteNonQuery();
				command.Dispose();
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

		public Habitacion buscarHabitacionNumero(string numero)
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			Habitacion habitacion = new Habitacion();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_buscar_Habitacion_Numero", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_num", MySqlDbType.VarChar).Value = numero;
				SQLdatos.Open();
				resultado = command.ExecuteReader();
				while (resultado.Read()) 
				{
					habitacion.idHabitacion = resultado.GetInt16(0);
					habitacion.numero = resultado.GetString(1);
					habitacion.id_tipo = resultado.GetInt16(2);
					habitacion.piso = resultado.GetInt16(3);
					habitacion.capacidad = resultado.GetInt16(4);
					habitacion.estado = resultado.GetString(5);
					habitacion.precio = resultado.GetDecimal(6);
					habitacion.comodidad = resultado.GetString(7);
					habitacion.observacion = resultado.GetString(8);
					habitacion.activo = resultado.GetBoolean(9);
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
			return habitacion;
		}

		public Habitacion buscarHabitacionPiso(int piso)
		{
			throw new NotImplementedException();
		}

		public bool eliminar(int id_)
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_eliminar_habitacion", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int32).Value = id_;
				SQLdatos.Open();
				resultado = command.ExecuteNonQuery();
				command.Dispose();
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
		
		public List<Habitacion> listadoHabitacionTipo(int idHabitacion)
		{
			throw new NotImplementedException();
		}

		public DataTable listarHabitacion() // Devuelve todas la habitaciones activas
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listado_habitaciones", SQLdatos);
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

		public DataTable listarCamasDisponible() // retorna todas las habitaciones con cama disponible
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listar_habitacion_cama_disponible", SQLdatos);
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

		public void ocuparCama(int idHabitacion) // método que actualizar la camas disponibles, si es ocupada una cama.
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_actualizar_cama_disponible", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int32).Value = idHabitacion;				
				SQLdatos.Open();
				resultado = command.ExecuteNonQuery();
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
		}
		public void liberarCama(int idHabitacion) // método que libera una cama cuando es dado de alta paciente
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_actualizar_libera_cama", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int32).Value = idHabitacion;
				SQLdatos.Open();
				resultado = command.ExecuteNonQuery();
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
		}

        public Habitacion buscarHabitacionId(int idHabitacion)
        { // falta crear el procedimiento almacenado
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            Habitacion habitacion = new Habitacion();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_Habitacion_id", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", MySqlDbType.Int24).Value = idHabitacion;
                SQLdatos.Open();
                resultado = command.ExecuteReader();
                while (resultado.Read())
                {
                    habitacion.idHabitacion = resultado.GetInt16(0);
                    habitacion.numero = resultado.GetString(1);
                    habitacion.id_tipo = resultado.GetInt16(2);
                    habitacion.piso = resultado.GetInt16(3);
                    habitacion.capacidad = resultado.GetInt16(4);
                    habitacion.estado = resultado.GetString(5);
                    habitacion.precio = resultado.GetDecimal(6);
                    habitacion.comodidad = resultado.GetString(7);
                    habitacion.observacion = resultado.GetString(8);
                    habitacion.activo = resultado.GetBoolean(9);
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
            return habitacion;
        }
    }    
}
