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
		Conexion conexion = new Conexion();

		public bool actualizarInternacion(Internacion internacion)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public DataTable buscarPaciente(int id)
		{
			throw new NotImplementedException();
		}

		public void eliminarInternacion(int id)
		{
			throw new NotImplementedException();
		}

		public bool guardarInternacion(Internacion internacion)
		{
			throw new NotImplementedException();
		}

		public DataTable listarInternacion() // retorna todo los pacientes que esten internado
		{
			MySqlConnection SQLdatos = new MySqlConnection();
			SQLdatos = conexion.crearConexion();
			MySqlDataReader resultado;
			DataTable table = new DataTable();

			try
			{
				MySqlCommand command = new MySqlCommand("psa_listar_internados", SQLdatos);
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
	}
}

