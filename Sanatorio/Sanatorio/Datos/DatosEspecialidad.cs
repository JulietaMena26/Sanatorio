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
    public class DatosEspecialidad : IEspecialidad1
    {
		Conexion conexion = new Conexion();
		public bool actualizarEspecialidad(Especialidad especialidad)
        {
            throw new NotImplementedException();
        }

        public bool agregarEspecialidad(Especialidad especialidad)
        {
            throw new NotImplementedException();
        }

        public DataTable buscarEspecialidad(string Especialidad)
        {
            throw new NotImplementedException();
        }

        public Especialidad buscarEspecialidadId(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminarEspecialidad(string especialidad)
        {
            throw new NotImplementedException();
        }

        public DataTable listarEspecialidad(string cTexto)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listar_especialidad", SQLdatos);
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
