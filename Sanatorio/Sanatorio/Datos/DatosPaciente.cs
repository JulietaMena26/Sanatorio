using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
       
        public bool actualizarPaciente(Paciente _paciente) // actualiza los datos de un cliente
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_actualizar_paciente", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("_id", MySqlDbType.Int32).Value = _paciente.idPaciente;
				command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = _paciente.dni;
				command.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = _paciente.apellido;
				command.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _paciente.nombre;
				command.Parameters.Add("_fechaNaci", MySqlDbType.Date).Value = _paciente.fechaNaci;
				command.Parameters.Add("_domicilio", MySqlDbType.VarChar).Value = _paciente.domicilio;
				command.Parameters.Add("_telefono", MySqlDbType.VarChar).Value = _paciente.telefono;
				command.Parameters.Add("_historiaClinica", MySqlDbType.VarChar).Value = _paciente.historiaClinica;
				command.Parameters.Add("_id_obraSocial", MySqlDbType.Int16).Value = _paciente.id_obraSocial;
				command.Parameters.Add("_afiliadoN", MySqlDbType.VarChar).Value = _paciente.afiliado;
				SQLdatos.Open();

				resultado = command.ExecuteNonQuery();
				if (resultado > 0)
					return true;
				else
					return false;

			}
			catch (Exception ex)
			{
				Funciones.Logs("actualizar_paciente", ex.ToString());
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

        public bool agregarPaciente(Paciente _paciente)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;          

            try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_pacientes", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = _paciente.dni;
                command.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = _paciente.apellido;
                command.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _paciente.nombre;
                command.Parameters.Add("_fechaNaci", MySqlDbType.Date).Value= _paciente.fechaNaci;
                command.Parameters.Add("_domicilio", MySqlDbType.VarChar).Value = _paciente.domicilio;
                command.Parameters.Add("_telefono", MySqlDbType.VarChar).Value = _paciente.telefono;
                command.Parameters.Add("_historiaClinica", MySqlDbType.VarChar).Value = _paciente.historiaClinica;
                command.Parameters.Add("_id_obraSocial", MySqlDbType.Int16).Value = _paciente.id_obraSocial;
                command.Parameters.Add("_afiliadoN", MySqlDbType.VarChar).Value = _paciente.afiliado;
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

        public Paciente buscarPacienteDni(string dni)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            Paciente paciente = new Paciente();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_paciente_dni", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = dni;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                while (resultado.Read()) 
                {
                    paciente.idPaciente = resultado.GetInt32(0);
                    paciente.dni = resultado.GetString(1);
                    paciente.apellido= resultado.GetString(2);
                    paciente.nombre= resultado.GetString(3);
                    paciente.fechaNaci = resultado.GetDateTime(4);
                    paciente.domicilio= resultado.GetString(5);
                    paciente.telefono= resultado.GetString(6);
                    paciente.historiaClinica= resultado.GetString(7);
                    paciente.id_obraSocial= resultado.GetInt32(8);
                    paciente.afiliado= resultado.GetString(9);
                    paciente.activo = resultado.GetBoolean(10);
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
            return paciente;
        }

        public Paciente buscarPacienteId(int idpaciente)
        {
            throw new NotImplementedException();
        }

        public void eliminarPacienteDni(string dni)
        {
            throw new NotImplementedException();
        }

        public void eliminarPaciente(int id)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_eliminar_paciente", SQLdatos);
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

        public DataTable listadoPacienteApellido(string apellido)
        {
            throw new NotImplementedException();
        }

        public DataTable listarPaciente(string cTexto)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command =  new MySqlCommand("psa_listado_pacientes", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cTexto",MySqlDbType.VarChar).Value=cTexto;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                table.Load(resultado);
                command.Dispose();
            }
            catch (Exception ex)
            {
                Funciones.Logs("Datos_metodolistpaciente", ex.ToString());
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

        public DataTable listarPacienteid_ObraSocial(int id_obraSocial)
        {
            throw new NotImplementedException();
        }

        public void eliminarPaciente(string dni)
        {
            throw new NotImplementedException();
        }
    }
}
