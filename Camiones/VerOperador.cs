using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Windows.Forms;

namespace Camiones
{
    public partial class VerOperador : Base
    {
        public VerOperador()
        {
            InitializeComponent();
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
        private void VerOperador_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
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
                txtCURP.Text = dt.Rows[0]["curp"].ToString();
                txtDomicilio.Text = dt.Rows[0]["comprobantedomicilio"].ToString();
                bool apto = Convert.ToBoolean(dt.Rows[0]["aptomedico"]); //Asegúrate de que el campo "aptomedico" en la BD sea bit 
                rbAptoSi.Checked = apto;
                rbAptoNo.Checked = !apto;
                bool anti = Convert.ToBoolean(dt.Rows[0]["antidoping"]);
                rbAntiSi.Checked = anti;
                rbAntiNo.Checked = !anti;
                bool contrato = Convert.ToBoolean(dt.Rows[0]["contratolaboral"]);
                rbContratoSi.Checked = contrato;
                rbContratoNo.Checked = !contrato;


            }
            else
            {
                MessageBox.Show("No se encontró el registro.");
            }
            CargarFotoPorID(txtID.Text);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
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
            string resultadoAntidoping = rbAntiSi.Checked ? "✅ Aprobado" : "❌ No aprobado";

            string resultadoContrato = rbContratoSi.Checked ? "✅ Aprobado" : "❌ No aprobado";

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
                                innerColumn.Item().Text($"CURP: {txtCURP.Text}");
                                innerColumn.Item().Text($"Licencia: {txtLicencia.Text}");
                                innerColumn.Item().Text($"Antidoping: {resultadoAntidoping}");
                                innerColumn.Item().Text($"Contrato Laboral: {resultadoContrato}");

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

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

