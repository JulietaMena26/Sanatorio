using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using MySqlX.XDevAPI;

namespace Sanatorio.Datos
{
     class Conexion
    {
        private readonly string bd = "bd_sanatorio";
        private readonly string servidor = "192.168.1.7";
        private readonly string puerto = "3306";
        private readonly string usuario = "emanuelunt";
        private readonly string pasword = "cancun";
        private string cadenaConexion;
        private MySqlConnection conn = null;

      
       public Conexion()
       {
            cadenaConexion = "Server=" + servidor + ";Database=" + bd + ";Uid=" + usuario + ";Pwd=" +pasword+ ";";
       }
        public MySqlConnection crearConexion()
        {
            try
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(cadenaConexion);
                }
            }
            catch (Exception error)
            {
                throw;
            }
            return conn;
        }
        

       
    }
}

