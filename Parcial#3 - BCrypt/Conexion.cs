using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Parcial_3___BCrypt
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadenaConexion = "Server=127.0.0.1;Database=SistemaLoginDB;Uid=root;Pwd=1234;";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
