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
    public class DatosRegistroClinico : IRegistroClinico1
    {
        Conexion conexion = new Conexion();

        public bool actualizarRegistro(Registro_Clinico registro)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_registrosclinico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_idRegisto", MySqlDbType.Int32).Value = registro.idRegistro;
                command.Parameters.Add("_id_paciente", MySqlDbType.Int32).Value = registro.id_paciente;
                command.Parameters.Add("_id_medico", MySqlDbType.Int32).Value = registro.id_medico;
                command.Parameters.Add("_fecha", MySqlDbType.Date).Value = registro.fecha;
                command.Parameters.Add("_hora", MySqlDbType.Time).Value = registro.hora;
                command.Parameters.Add("_motivo", MySqlDbType.VarChar).Value = registro.motivo;
                command.Parameters.Add("_diagnostico", MySqlDbType.VarChar).Value = registro.diagnostico;
                command.Parameters.Add("_tratamiento", MySqlDbType.VarChar).Value = registro.tratamiento;
                command.Parameters.Add("_proxima_visita", MySqlDbType.Date).Value = registro.proxima_visita;
                command.Parameters.Add("_observacion", MySqlDbType.VarChar).Value = registro.observacion;
                SQLdatos.Open();

                resultado = command.ExecuteNonQuery();
                if (resultado > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                Funciones.Logs("actualizar_registro", ex.ToString());
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

            try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_registros_clinicos", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_idRegisto", MySqlDbType.Int32).Value = registro.idRegistro;
                command.Parameters.Add("_id_paciente", MySqlDbType.Int32).Value = registro.id_paciente;
                command.Parameters.Add("_id_medico", MySqlDbType.Int32).Value = registro.id_medico;
                command.Parameters.Add("_fecha", MySqlDbType.Date).Value = registro.fecha;
                command.Parameters.Add("_hora", MySqlDbType.Time).Value = registro.hora;
                command.Parameters.Add("_motivo", MySqlDbType.VarChar).Value = registro.motivo;
                command.Parameters.Add("_diagnostico", MySqlDbType.VarChar).Value = registro.diagnostico;
                command.Parameters.Add("_tratamiento", MySqlDbType.VarChar).Value = registro.tratamiento;
                command.Parameters.Add("_proxima_visita", MySqlDbType.Date).Value = registro.proxima_visita;
                command.Parameters.Add("_observacion", MySqlDbType.VarChar).Value = registro.observacion;
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

        public void eliminarRegistroId(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable listarRegistros()
        {
            throw new NotImplementedException();
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