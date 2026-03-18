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
            Clsoperador.SubirDoumento(txtID.Text, txtURLlicencia);
        }


        private void btnApto_Click(object sender, EventArgs e)
        {
            // Clsoperador.SubirDoumento(txtID.Text,txtapto);
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
            Clsoperador.SubirDoumento(txtID.Text, txtURLcurp);
        }

        private void btnAnti_Click(object sender, EventArgs e)
        {


            // Clsoperador.SubirDoumento(txtID.Text);
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
            // Clsoperador.SubirDoumento(txtID.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAntiSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAntiSI.Checked)
            {
                btnContrato.Visible = true;
            }
            else
            {
                btnContrato.Visible = false;
            }
        }


        private void rdbContratoSI_CheckedChanged(object sender, EventArgs e)
        {

            /*if (rbContratoSI.Checked)
            {
                btnContrato.Visible = true;
            }
            else
            {
                btnContrato.Visible = false;
            }*/
        }

        private void rdbCondicionesSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContratoSI.Checked)
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

            if (rbCapacitacionesSI.Checked)
            {
                btnCapacitaciones.Visible = true;
                txtNumeroCapacitaciones.Visible = true;
            }
            else
            {
                btnCapacitaciones.Visible = false;
                txtNumeroCapacitaciones.Visible = false;
            }
        }

        private void rbdViajesSI_CheckedChanged(object sender, EventArgs e)
        {

            if (rbViajesSI.Checked)
            {
                btnViajes.Visible = true;
                txtViajes.Visible = true;
            }
            else
            {
                btnViajes.Visible = false;
                txtViajes.Visible = false;
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
            if (rbAptoSi.Checked)
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

        }




        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void CargarFotoPorID(string id)
        {
            // Carpeta base donde están todas las carpetas de clientes
            string carpetaBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DocumentosClientes");

            // Carpeta del cliente específico
            string carpetaCliente = Path.Combine(carpetaBase, id);

            if (!Directory.Exists(carpetaCliente))
            {
                MessageBox.Show($"No se encontró la carpeta del cliente con ID {id}.");
                pictureBox1.Image = null;
                return;
            }

            // Buscar cualquier archivo de imagen dentro de la carpeta del cliente
            string[] imagenes = Directory.GetFiles(carpetaCliente)
                .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                            f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                            f.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                .ToArray();

            if (imagenes.Length > 0)
            {
                // Cargar la primera imagen encontrada en el PictureBox
                pictureBox1.Image = System.Drawing.Image.FromFile(imagenes[0]);
            }
            else
            {
                MessageBox.Show($"No se encontró ninguna foto en la carpeta del cliente con ID {id}.");
                pictureBox1.Image = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog())
            {
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    Clsoperador.GuardarCapacitacion(txtID.Text, abrir.FileName);
                }
            }
            string query = @"UPDATE dbo.operador
                         SET capacitaciones = @capacitacion
                         WHERE idoperador = @id";

            var parametros = new Dictionary<string, object>()
        {
            { "@capacitacion", txtNumeroCapacitaciones.Text },
            { "@id", txtID.Text }
        };

            int filas = Consultas.Ejecutar(query, parametros);

            if (filas > 0)
            {
                MessageBox.Show("Registro actualizado correctamente");

            }
        }

        private void button1_Click(object sender, EventArgs e)  //boton select
        {
            string query = "SELECT * FROM operador WHERE idoperador = @id";

            Dictionary<string, object> parametros = new Dictionary<string, object>()
    {
        { "@id", txtID.Text }
    };

            DataTable dt = Consultas.Consultar(query, parametros);

            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[0]["nombreoperador"].ToString();
                txtPaterno.Text = dt.Rows[0]["apellidopoperador"].ToString();
                txtMaterno.Text = dt.Rows[0]["apellidomoperador"].ToString();
                txtLicencia.Text = dt.Rows[0]["licencia"].ToString();
                txtINE.Text = dt.Rows[0]["ine"].ToString();
                TXTcurp.Text = dt.Rows[0]["curp"].ToString();
                txtDomicilio.Text = dt.Rows[0]["comprobantedomicilio"].ToString();
                bool apto = Convert.ToBoolean(dt.Rows[0]["aptomedico"]); //Asegúrate de que el campo "aptomedico" en la BD sea bit 
                rbAptoSi.Checked = apto;
                rbdAptoNO.Checked = !apto;
                bool anti = Convert.ToBoolean(dt.Rows[0]["antidoping"]);
                rbAntiSI.Checked = anti;
                rbAntiNO.Checked = !anti;
                bool contrato = Convert.ToBoolean(dt.Rows[0]["contratolaboral"]);
                rbContratoSI.Checked = contrato;
                rbContratoNO.Checked = !contrato;
                bool capacitaciones = Convert.ToBoolean(dt.Rows[0]["capacitaciones"]);
                rbCapacitacionesSI.Checked = contrato;
                rbCapacitacionesNO.Checked = !contrato;
                txtViajes.Text = dt.Rows[0]["viajes"].ToString();
                txtURLimagen.Text = dt.Rows[0]["fotooperador"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el registro.");
            }
            CargarFotoPorID(txtID.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO dbo.operador (nombreoperador,apellidomoperador,apellidopoperador,licencia,aptomedico,comprobantedomicilio,ine,curp,antidoping,contratolaboral,capacitaciones,viajes,fotooperador) VALUES (@nombreoperador,@apellidomoperador,@apellidopoperador,@licencia,@aptomedico,@comprobantedomicilio,@ine,@curp,@antidoping,@contratolaboral,@capacitaciones,@viajes,@fotooperador)";

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
            { "@capacitaciones", txtNumeroCapacitaciones.Text },
            { "@viajes", txtViajes.Text },
            { "@fotooperador", txtURLimagen.Text }
        };

                Consultas.Ejecutar(query, parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnConsultar.Enabled = false;
            txtID.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnConsultar.Enabled = true;
            txtID.Enabled = true;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // 1️⃣ Convertir imagen a byte[]
            byte[] imagenBytes = null;
            if (pictureBox1.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imagenBytes = ms.ToArray();
                }
            }

            // Resultado antidoping
            string resultadoAntidoping = rbAntiSI.Checked ? "✅ Aprobado" : "❌ No aprobado";

            string resultadoContrato = rbContratoSI.Checked ? "✅ Aprobado" : "❌ No aprobado";

            // 2️⃣ Crear documento PDF
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
                            row.RelativeItem().Column(innerColumn =>
                            {
                                innerColumn.Item().Text($"ID: {txtID.Text}");
                                innerColumn.Item().Text($"Nombre: {txtNombre.Text}");
                                innerColumn.Item().Text($"Apellido Paterno: {txtPaterno.Text}");
                                innerColumn.Item().Text($"Apellido Materno: {txtMaterno.Text}");
                                innerColumn.Item().Text($"Domicilio: {txtDomicilio.Text}");
                                innerColumn.Item().Text($"INE: {txtINE.Text}");
                                innerColumn.Item().Text($"CURP: {TXTcurp.Text}");
                                innerColumn.Item().Text($"Licencia: {txtLicencia.Text}");
                                innerColumn.Item().Text($"Antidoping: {resultadoAntidoping}");
                                innerColumn.Item().Text($"Contrato Laboral: {resultadoContrato}");
                                innerColumn.Item().Text($"Capacitaciones: {txtNumeroCapacitaciones.Text}");
                                innerColumn.Item().Text($"Viajes: {txtViajes.Text}");
                            });

                            row.ConstantItem(20);

                            if (imagenBytes != null)
                            {
                                row.ConstantItem(150).Element(container =>
                                {
                                    container.AlignCenter()
                                             .MaxWidth(150)
                                             .MaxHeight(150)
                                             .Image(imagenBytes, ImageScaling.FitArea);
                                });
                            }
                        });
                    });

                    page.Footer().AlignCenter().Text($"Fecha: {DateTime.Now.ToShortDateString()}");
                });
            });

            // 3️⃣ Preparar carpetas
            string idCliente = txtID.Text;
            string rutaBase = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DocumentosClientes");
            string carpetaCliente = Path.Combine(rutaBase, idCliente);
            string carpetaReportes = Path.Combine(carpetaCliente, "Reportes");

            Directory.CreateDirectory(carpetaCliente);
            Directory.CreateDirectory(carpetaReportes);

            string nombreArchivo = "Reporte.pdf";
            string rutaPDF = Path.Combine(carpetaReportes, nombreArchivo);

            // 4️⃣ Verificar si el PDF ya existe
            if (File.Exists(rutaPDF))
            {
                DialogResult resultado = MessageBox.Show(
                    "El reporte ya existe. ¿Deseas sobrescribirlo?",
                    "Confirmar sobrescritura",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                    return; // cancelar
            }

            // 5️⃣ Guardar PDF (¡usar el documento ya creado!)
            documento.GeneratePdf(rutaPDF);

            MessageBox.Show("Reporte guardado correctamente en: " + rutaPDF);
        }
    }
}




    

