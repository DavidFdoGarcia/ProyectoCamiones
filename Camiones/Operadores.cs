using Camiones.clases;
using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;



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
            
        }


        private void btnApto_Click(object sender, EventArgs e)
        {
   
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtDomicilio);
        }

        private void btnINE_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtINE);
        }

        private void btnCURP_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnti_Click(object sender, EventArgs e)
        {
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            // Clsoperador.SubirDoumento(txtID.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAntiSI_CheckedChanged(object sender, EventArgs e)
        {
        
        }


        private void rdbContratoSI_CheckedChanged(object sender, EventArgs e)
        {

        }

       



        private void rbLicenciaSI_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void rbdAptoSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }




        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }




        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

       

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)  //boton select
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
        INSERT INTO dbo.operador 
        (nombreoperador,apellidomoperador,apellidopoperador,licencia,aptomedico,comprobantedomicilio,ine,curp,antidoping,contratolaboral) 
        VALUES 
        (@nombreoperador,@apellidomoperador,@apellidopoperador,@licencia,@aptomedico,@comprobantedomicilio,@ine,@curp,@antidoping,@contratolaboral);

        SELECT SCOPE_IDENTITY();
        ";

                bool apto = rbAptoSi.Checked;
                bool anti = rbAntiSI.Checked;
                bool contrato = rbContratoSI.Checked;

                var parametros = new Dictionary<string, object>()
        {
            { "@nombreoperador", txtNombre.Text },
            { "@apellidomoperador", txtMaterno.Text },
            { "@apellidopoperador", txtPaterno.Text },
            { "@licencia", txtLicencia.Text },
            { "@aptomedico", apto },
            { "@comprobantedomicilio", txtDomicilio.Text },
            { "@ine", txtINE.Text },
            { "@curp", TXTcurp.Text },
            { "@antidoping", anti },
            { "@contratolaboral", contrato },
            
        };

                // 🔥 AQUÍ obtienes el ID
                object resultado = Consultas.EjecutarEscalar(query, parametros);

                int idGenerado = Convert.ToInt32(resultado);

                // 👉 LO PONES EN EL TEXTBOX
                txtID.Text = idGenerado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtID.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

    

       

        private void btnContrato_Click_1(object sender, EventArgs e)
        {

        }

        private void rbContratoSI_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string id = txtID.Text; // o de donde lo tengas

            DocumentoOperador frm = new DocumentoOperador(id);
            frm.Show();
        }
        
    }
}




    

