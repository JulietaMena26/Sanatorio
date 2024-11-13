using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public bool actualizarMedico(Medico medico)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_actualizar_Medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_id", MySqlDbType.Int32).Value = _medico.idPaciente;
                command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = _medico.dni;
                command.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = _medico.apellido;
                command.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _medico.nombre;
                command.Parameters.Add("_fechaNaci", MySqlDbType.Date).Value = _medico.fechaNaci;
                command.Parameters.Add("_domicilio", MySqlDbType.VarChar).Value = _medico.domicilio;
            
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

        public bool agregarMedico(Medico medico)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            int resultado;

            try
            {
                MySqlCommand command = new MySqlCommand("psa_guardar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = _medico.dni;
                command.Parameters.Add("_apellido", MySqlDbType.VarChar).Value = _medico.apellido;
                command.Parameters.Add("_nombre", MySqlDbType.VarChar).Value = _medico.nombre;
                command.Parameters.Add("_celular", MySqlDbType.Date).Value = _medico.celular;
                command.Parameters.Add("_telefono", MySqlDbType.VarChar).Value = _medico.telefono;
                command.Parameters.Add("_direccion", MySqlDbType.VarChar).Value = _medico.direccion;
                command.Parameters.Add("_email", MySqlDbType.Int16).Value = _medico.email;
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
            Paciente paciente = new Paciente();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_buscar_medico", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("_dni", MySqlDbType.VarChar).Value = dni;
                SQLdatos.Open();

                resultado = command.ExecuteReader();
                while (resultado.Read())
                {
                    paciente.idMedico = resultado.GetInt32(0);
                    paciente.dni = resultado.GetString(1);
                    paciente.cuil = resultado.GetString(2);
                    paciente.apellido = resultado.GetString(3);
                    paciente.nombre = resultado.GetString(4);
                    paciente.celular = resultado.GetString(5);
                    paciente.telefono = resultado.GetString(6);
                    paciente.domicilio = resultado.GetString(7);
                    paciente.email = resultado.GetInt32(8);
                 
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
            return Medico;
        }
    }

        public Medico buscarMedicoId(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarMedico(string dni)
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

        public DataTable listarMedico( string texto)
        {
            MySqlConnection SQLdatos = new MySqlConnection();
            SQLdatos = conexion.crearConexion();
            MySqlDataReader resultado;
            DataTable table = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("psa_listar_medicos", SQLdatos);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = texto;
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
