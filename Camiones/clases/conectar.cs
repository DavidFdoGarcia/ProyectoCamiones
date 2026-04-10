using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camiones.clases
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            string ruta = @"C:\sistema\config.ini";

            Ini ini = new Ini(ruta);

            string server = ini.Leer("database", "server");
            string database = ini.Leer("database", "database");
            string user = ini.Leer("database", "user");
            string password = ini.Leer("database", "password");

            string cadena = $"Server={server};Database={database};Integrated Security=True;TrustServerCertificate=True;";


            SqlConnection cn = new SqlConnection(cadena);

            cn.Open();

            return cn;
        }
    }

}
