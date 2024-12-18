﻿using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Sanatorio.Interfaz;
using Sanatorio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Sanatorio.Datos;

namespace Sanatorio.Datos
{
    public class DatosRegistroClinico : IRegistroClinico1
    {
        Conexion conexion = new Conexion();

        public bool actualizarRegistro(Registro_Clinico registro)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;
			TimeSpan hora = registro.hora.TimeOfDay;

			try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_registrosclinico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", MySqlDbType.Int32).Value = registro.idRegistro;
               // command.Parameters.Add("id_paciente_", MySqlDbType.Int32).Value = registro.id_paciente;
               // command.Parameters.Add("id_medico_", MySqlDbType.Int32).Value = registro.id_medico;
                command.Parameters.Add("fecha_", MySqlDbType.Date).Value = registro.fecha.ToString("yyyy-MM-dd");
                command.Parameters.Add("hora_", MySqlDbType.Time).Value = hora;
                command.Parameters.Add("motivo_", MySqlDbType.VarChar).Value = registro.motivo;
                command.Parameters.Add("diagnostico_", MySqlDbType.VarChar).Value = registro.diagnostico;
                command.Parameters.Add("tratamiento_", MySqlDbType.VarChar).Value = registro.tratamiento;
                command.Parameters.Add("proxima_visita_", MySqlDbType.Date).Value = registro.proxima_visita.ToString("yyyy-MM-dd");
                command.Parameters.Add("observacion_", MySqlDbType.VarChar).Value = registro.observacion;
                SQLdatos.Open();

                resultado = command.ExecuteNonQuery();
                if (resultado > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                //Funciones.Logs("actualizar_registro", ex.ToString());
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

        public bool agregarRegistro(Registro_Clinico registro)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

			TimeSpan hora = registro.hora.TimeOfDay;

			try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_registro_clinico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("id_paciente_", MySqlDbType.Int32).Value = registro.id_paciente;
                command.Parameters.Add("id_medico_", MySqlDbType.Int32).Value = registro.id_medico;
                command.Parameters.Add("fecha_", MySqlDbType.Date).Value = registro.fecha.ToString("yyyy-MM-dd");
                command.Parameters.Add("hora_", MySqlDbType.Time).Value = hora;
                command.Parameters.Add("motivo_", MySqlDbType.VarChar).Value = registro.motivo;
                command.Parameters.Add("diagnostico_", MySqlDbType.VarChar).Value = registro.diagnostico;
                command.Parameters.Add("tratamiento_", MySqlDbType.VarChar).Value = registro.tratamiento;
                command.Parameters.Add("proxima_visita_", MySqlDbType.Date).Value = registro.proxima_visita.ToString("yyyy-MM-dd");
                command.Parameters.Add("observacion_", MySqlDbType.VarChar).Value = registro.observacion;
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

        public DataTable buscarRegistroFecha(DateTime inicial, DateTime final)
        {
            throw new NotImplementedException();
        }


        public DataTable buscarRegistroIdMedico(int id_medico)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarRegistroIdPaciente(int id_paciente)
        {
            throw new NotImplementedException();
        }

        public void eliminarRegistroId(int idRegistroClinico)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_eliminar_registroClinico", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_", MySqlDbType.Int32).Value = idRegistroClinico;
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

        public DataTable listarRegistros(string cTexto) // retorna una tabla con todo los registros clinicos activos
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listado_registro_clinico", SQLdatos);
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

        public DataTable buscarRegistroId(int id_paciente)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            DataTable tablaRegistros = new DataTable();
            MySqlDataReader resultado;
            Registro_Clinico registro = new Registro_Clinico();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_registroclinico_id_paciente", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id_paciente", MySqlDbType.VarChar).Value = id_paciente;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                while (resultado.Read())
                {
                    registro.idRegistro = resultado.GetInt32(0);
                    registro.id_paciente = resultado.GetInt32(1);
                    registro.id_medico = resultado.GetInt32(2);
                    registro.fecha = resultado.GetDateTime(3);
                    registro.hora = resultado.GetDateTime(4);
                    registro.motivo = resultado.GetString(5);
                    registro.diagnostico = resultado.GetString(6);
                    registro.tratamiento = resultado.GetString(7);
                    registro.proxima_visita = resultado.GetDateTime(8);
                    registro.observacion = resultado.GetString(9);
                }
                tablaRegistros.Load(resultado);
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
            return tablaRegistros;
        }


      
    }
}