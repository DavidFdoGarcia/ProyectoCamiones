using Camiones.clases;
using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
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

    
          

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // 1️⃣ Convertir la imagen del PictureBox a byte[]
            byte[] imagenBytes = null;
            if (pictureBox1.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }
            }

            // 2️⃣ Crear PDF
            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(50);
                    page.Size(PageSizes.A4);

                    // Encabezado
                    page.Header().Text("Reporte de Camiones")
                        .FontSize(20)
                        .SemiBold()
                        .FontColor(Colors.Blue.Medium);

                    // Contenido
                    page.Content().Column(column =>
                    {
                        column.Item().Row(row =>
                        {
                            // Datos a la izquierda
                            row.RelativeItem().Column(innerColumn =>
                            {
                                innerColumn.Item().Text($"ID: {txtID.Text}");
                                innerColumn.Item().Text($"Nombre: {txtNombre.Text}");
                                innerColumn.Item().Text($"Apellido Paterno: {txtPaterno.Text}");
                                innerColumn.Item().Text($"Apellido Materno: {txtMaterno.Text}");
                            });
                              // Espacio entre columnas
                                    row.ConstantItem(20); // Esto crea un "espaciador" de 20 puntos entre datos y foto
                       
                            // Foto a la derecha    
                            if (imagenBytes != null)
                            {
                                row.ConstantItem(150).Element(container =>
                                {
                                    if (imagenBytes != null)
                                        container
                                            .AlignCenter()
                                            .MaxWidth(150)   // ancho máximo
                                            .MaxHeight(150)  // alto máximo
                                            .Image(imagenBytes, ImageScaling.FitArea);
                                });
                            }

                          
                                /*
                                // Antidoping con ✅/❌
                                string resultado = txtAntidoping.Text == "Aprobado" ? "✅ Aprobado" : "❌ No aprobado";
                                innerColumn.Item().Text($"Antidoping: {resultado}");

                                innerColumn.Item().Text($"Licencia: {txtLicencia.Text}");
                                innerColumn.Item().Text($"CURP: {TXTcurp.Text}");
                                innerColumn.Item().Text($"Comprobante Domicilio: {txtDomicilio.Text}");
                                innerColumn.Item().Text($"Contrato Laboral: {txtContrato.Text}");
                                innerColumn.Item().Text($"Condiciones: {txtCondiciones.Text}");
                                innerColumn.Item().Text($"Capacitaciones: {txtCapacitaciones.Text}");
                                innerColumn.Item().Text($"Viajes: {txtViajes.Text}"); */
                            });
                        });
                    

                    // Pie de página
                    page.Footer().AlignCenter().Text($"Fecha: {DateTime.Now.ToShortDateString()}");
                });
            });

            // 3️⃣ Guardar PDF en carpeta del escritorio usando ID
            string nombreArchivo = $"ReporteCamiones_{txtID.Text}.pdf";
            string carpeta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ReportesCamiones");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string rutaCompleta = Path.Combine(carpeta, nombreArchivo);
            documento.GeneratePdf(rutaCompleta);

            MessageBox.Show($"PDF generado correctamente en: {rutaCompleta}");
        }
    }
}



    

