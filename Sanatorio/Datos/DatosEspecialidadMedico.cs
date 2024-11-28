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
    public class DatosEspecialidadMedico : IEspecialidadMedico1
    {
		Conexion conexion = new Conexion();
		public bool actualizarEspecialidaMedico(EspecialidadMedico especialidad)
        {
            throw new NotImplementedException();
        }

        public EspecialidadMedico buscarIdMedico(int id)
        {
            throw new NotImplementedException();
        }

        public EspecialidadMedico buscarMatricula(string matricula)
        {
            throw new NotImplementedException();
        }

        public void eliminarEspecialiad(int id)
        {
            throw new NotImplementedException();
        }

        public bool guardarEspecialidaMedico(EspecialidadMedico especialidad)
        {
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			int resultado;

			try
			{
				MySqlCommand command = new MySqlCommand("psa_guardar_especialidad_medico", SQLdatos);
				command.CommandType = CommandType.StoredProcedure;
				command.Parameters.Add("id_especialidad_", MySqlDbType.Int32).Value =  especialidad.id_especialidad;
				command.Parameters.Add("id_medico_", MySqlDbType.Int32).Value = especialidad.id_medico;
				command.Parameters.Add("matricula_", MySqlDbType.VarChar).Value = especialidad.matricula;
				
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

        public DataTable listarEspecialidadMedico()
        {
            throw new NotImplementedException();
        }
    }
}
