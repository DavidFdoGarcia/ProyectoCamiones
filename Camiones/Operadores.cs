using Camiones.clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // Clsoperador.SubirDoumento(txtID.Text);
        }


        private void btnApto_Click(object sender, EventArgs e)
        {
            // Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            // Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnINE_Click(object sender, EventArgs e)
        {
            // Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnCURP_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtURLcurp);
        }

        private void btnAnti_Click(object sender, EventArgs e)
        {


            //Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            //Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnCondiciones_Click(object sender, EventArgs e)
        {
            //Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {
            //Clsoperador.SubirDoumento(txtID.Text);
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            //Clsoperador.SubirDoumento(txtID.Text);
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
            Clsoperador.SubirFoto(txtID.Text, pictureBox1, txtURLimagen);
        }




        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO dbo.operador (nombreoperador,apellidomoperador,apellidopoperador,licencia,aptomedico,comprobantedomicilio,ine,curp,antidoping,contratolaboral,condiciones,capacitaciones,viajes,fotooperador) VALUES (@nombreoperador,@apellidomoperador,@apellidopoperador,@licencia,@aptomedico,@comprobantedomicilio,@ine,@curp,@antidoping,@contratolaboral,@condiciones,@capacitaciones,@viajes,@fotooperador)";

                var parametros = new Dictionary<string, object>()
        {
            { "@nombreoperador", txtNombre.Text },
            { "@apellidomoperador", txtMaterno.Text },
            { "@apellidopoperador", txtPaterno.Text },
            { "@licencia", txtURLlicencia.Text },
            { "@aptomedico", txtURLapto.Text },
            { "@comprobantedomicilio", txtDomicilio.Text },
            { "@ine", txtINE.Text },
            { "@curp", TXTcurp.Text },
            { "@antidoping", txtURLanti.Text },
            { "@contratolaboral", txtURLcontrato.Text },
            { "@condiciones", txtURLcondiciones.Text },
            { "@capacitaciones", txtURLcapacitaciones.Text },
            { "@viajes", txtURLviajes.Text },
            { "@fotooperador", txtURLimagen.Text }
        };

                Consultas.Ejecutar(query, parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }



    

