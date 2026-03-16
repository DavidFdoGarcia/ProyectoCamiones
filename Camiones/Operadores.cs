using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Camiones.clases;
using Microsoft.Data.SqlClient;


namespace Camiones
{
    public partial class Operadores : Base
    {
        public Operadores()
        {
            InitializeComponent();
        }

        private void Operadores_Load(object sender, EventArgs e)
        {

        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }


        private void btnApto_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnINE_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnCURP_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnAnti_Click(object sender, EventArgs e)
        {


            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnCondiciones_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAntiSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAntiSI.Checked)
            {
                btnAnti.Visible = true;
            }
            else
            {
                btnAnti.Visible = false;
            }
        }


        private void rdbContratoSI_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbContratoSI.Checked)
            {
                btnContrato.Visible = true;
            }
            else
            {
                btnContrato.Visible = false;
            }
        }

        private void rdbCondicionesSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCondicionesSI.Checked)
            {
                btnCondiciones.Visible = true;
            }
            else
            {
                btnCondiciones.Visible = false;
            }
        }

        private void rbdCapacitacionesSI_CheckedChanged(object sender, EventArgs e)
        {

            if (rbdCapacitacionesSI.Checked)
            {
                btnCapacitaciones.Visible = true;
            }
            else
            {
                btnCapacitaciones.Visible = false;
            }
        }

        private void rbdViajesSI_CheckedChanged(object sender, EventArgs e)
        {

            if (rbdViajesSI.Checked)
            {
                btnViajes.Visible = true;
                txtViajes.Visible = true;
            }
            else
            {
                btnViajes.Visible = false;
                txtViajes.Visible = true;
            }
        }

        private void rbLicenciaSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLicenciaSI.Checked)
            {
                btnLicencia.Visible = true;
            }
            else
            {
                btnLicencia.Visible = false;
            }
        }

        private void rbdAptoSI_CheckedChanged(object sender, EventArgs e)
        {
            if (pbOperador.Checked)
            {
                btnApto.Visible = true;
            }
            else
            {
                btnApto.Visible = false;
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirFoto(txtID.Text, pictureBox1);
        }
    


    //aqui empiezan los metodos del CRUD
    
        public static void Insertar(string idoperador, string nombreoperador, string apellidomoperador, string apellidopoperador, string licencia, string aptomedico, string comprobantedomicilio, string ine, string curp, string antidoping, string contratolaboral, string condiciones, string capacitaciones, string viajes, string fotooperador)
        {
            try
            {
                SqlConnection cn = Conexion.Conectar();

                string query = "INSERT INTO operador (idoperador,nombreoperador,apellidomoperador,apellidopoperador,licencia,aptomedico,comprobantedomicilio,ine,curp,antidoping,contratolaboral,condiciones,capacitaciones,viajes,fotooperador) VALUES (@idoperador,@nombreoperador,@apellidomoperador,@apellidopoperador,@licencia,@aptomedico,@comprobantedomicilio,@ine,@curp,@antidoping,@contratolaboral,@condiciones,@capacitaciones,@viajes,@fotooperador)";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@idoperador", idoperador);
                cmd.Parameters.AddWithValue("@nombreoperador", nombreoperador);
                cmd.Parameters.AddWithValue("@apellidomoperador", apellidomoperador);
                cmd.Parameters.AddWithValue("@apellidopoperador", apellidopoperador);
                cmd.Parameters.AddWithValue("@licencia", licencia);
                cmd.Parameters.AddWithValue("@aptomedico", aptomedico);
                cmd.Parameters.AddWithValue("@comprobantedomicilio", comprobantedomicilio);
                cmd.Parameters.AddWithValue("@ine", ine);
                cmd.Parameters.AddWithValue("@curp", curp);
                cmd.Parameters.AddWithValue("@antidoping", antidoping);
                cmd.Parameters.AddWithValue("@contratolaboral", contratolaboral);
                cmd.Parameters.AddWithValue("@condiciones", condiciones);
                cmd.Parameters.AddWithValue("@capacitaciones", capacitaciones);
                cmd.Parameters.AddWithValue("@viajes", viajes);
                cmd.Parameters.AddWithValue("@fotooperador", fotooperador);

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
