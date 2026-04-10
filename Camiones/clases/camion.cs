using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;



namespace Camiones.clases
{
    class CamionCRUD
    {

        public static void Insertar(string tipo)
        {
            try { 
            SqlConnection cn = Conexion.Conectar();

            string query = "INSERT INTO camion (tipocamion) VALUES (@tipo)";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@tipo", tipo);

            cmd.ExecuteNonQuery();
            cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el camión: " + ex.Message);

            }
        }

        


        public static DataTable Consultar()
        {
            SqlConnection cn = Conexion.Conectar();

            string query = "SELECT * FROM camion";

            SqlDataAdapter da = new SqlDataAdapter(query, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cn.Close();

            return dt;
        }


        public static void Eliminar(int id)
        {
            if (MessageBox.Show("¿Desea eliminar este camión?", "Confirmar eliminación",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    SqlConnection cn = Conexion.Conectar();

                    string query = "DELETE FROM camion WHERE idcamion=@id";

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el camión: " + ex.Message);
                }
            }
        }


        public static void Actualizar(int id, string tipo)
        {
            SqlConnection cn = Conexion.Conectar();

            string query = "UPDATE camion SET tipocamion=@tipo WHERE idcamion=@id";

            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            cn.Close();
        }

    }
}
