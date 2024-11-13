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

namespace Sanatorio.Datos
{
    public class DatosInternacion : IInternacion1
    {
        public bool actualizarInternacion(Internacion internacion)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_internacion", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_idInternacion", MySqlDbType.Int32).Value = _internacion.idInternacion;
                command.Parameters.Add("_fechaIngreso", MySqlDbType.Date).Value = _internacion.fechaIngreso;
                command.Parameters.Add("_horaIngreso", MySqlDbType.Time).Value = _internacion.horaEgreso;
                command.Parameters.Add("_id_medico", MySqlDbType.Int32).Value = _internacion.id_medico;
                command.Parameters.Add("_id_paciente", MySqlDbType.Int32).Value = _internacion.id_paciente;
                command.Parameters.Add("_id_habitacion", MySqlDbType.Int32).Value = _internacion.id_habitacion;
                command.Parameters.Add("_motivoInternacion", MySqlDbType.VarChar).Value = _internacion.motivoInternacion;
                command.Parameters.Add("_diagnostico", MySqlDbType.VarChar).Value = _interncion.diagnostico;
                command.Parameters.Add("_deuda", MySqlDbType.).Value = _internacion.deuda;
                command.Parameters.Add("_estado", MySqlDbType.VarChar).Value = _internacion.estado;
                command.Parameters.Add("_fechaEgreso", MySqlDbType.Date).Value = _internacion.fechaEgreso;
                command.Parameters.Add("_horaEgreso", MySqlDbType.Time).Value = _internacion.horaEgreso;
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

        public DataTable buscarMedico(int id)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            Medico Medico = new Medico();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_apellid", MySqlDbType.VarChar).Value = apellido;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                while (resultado.Read())
                {
                    Internacion.idInternacion = resultado.GetInt32(0);
                    Internacion.fechaIngreso = resultado.GetDateTime(1);
                    Internacion.horaIngreso = resultado.GetDateTime(2);
                    Internacion.id_medico = resultado.GetInt32(3);
                    Internacion.id_paciente = resultado.GetInt32(4);
                    Internacion.id_habitacion = resultado.GetInt32(5);
                    Internacion.motivoInternacion = resultado.GetString(6);
                    Internacion.diagnostico = resultado.GetString(7);
                    Internacion.deuda = resultado.GetInt32(8);
                    Internacion.estado = resultado.GetString(9);
                    Internacion.fechaEgreso = resultado.GetDateTime(10);
                    Internacion.horaEgreso = resultado.GetDateTime(11);
                    Internacion.activo = resultado.GetBoolean(12);
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
            return Internacion;
        }
    }

        public DataTable buscarPaciente(int id)
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
                Internacion.idInternacion = resultado.GetInt32(0);
                Internacion.fechaIngreso = resultado.GetDateTime(1);
                Internacion.horaIngreso = resultado.GetDateTime(2);
                Internacion.id_medico = resultado.GetInt32(3);
                Internacion.id_paciente = resultado.GetInt32(4);
                Internacion.id_habitacion = resultado.GetInt32(5);
                Internacion.motivoInternacion = resultado.GetString(6);
                Internacion.diagnostico = resultado.GetString(7);
                Internacion.deuda = resultado.GetInt32(8);
                Internacion.estado = resultado.GetString(9);
                Internacion.fechaEgreso = resultado.GetDateTime(10);
                Internacion.horaEgreso = resultado.GetDateTime(11);
                Internacion.activo = resultado.GetBoolean(12);
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
}

        public void eliminarInternacion(int id)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_eliminar_internacion", SQLdatos);
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

        public bool guardarInternacion(Internacion internacion)
        {
            throw new NotImplementedException();
        }

        public DataTable listarInternacion()
        {
            throw new NotImplementedException();
        }
    }
}

