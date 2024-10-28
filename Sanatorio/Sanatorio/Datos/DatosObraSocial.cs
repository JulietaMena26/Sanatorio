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
        public bool actualizarObraSocial(ObraSocial obrasocial)
        {
            throw new NotImplementedException();
        }

        public bool agregarObraSocial(ObraSocial obrasocial)
        {
            throw new NotImplementedException();
        }

        public ObraSocial buscaridSocial(int idSocial)
        {
            throw new NotImplementedException();
        }

        public ObraSocial buscaridSocial(string codigo)
        {
            throw new NotImplementedException();
        }

        public void eliminarObraSocial(int id)
        {
            throw new NotImplementedException();
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
