using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Camiones.clases
{
    public class Consultas
    {
        public static DataTable Consultar(string query, Dictionary<string, object> parametros = null)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, cn);

                if (parametros != null)
                {
                    foreach (var p in parametros)
                    {
                        cmd.Parameters.AddWithValue(p.Key, p.Value);
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        public static int Ejecutar(string query, Dictionary<string, object> parametros)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, cn);

                foreach (var p in parametros)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }

                return cmd.ExecuteNonQuery();
            }
        }
    }
}
