using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Drawing.Printing;

using System.Text;
using System.Windows.Forms;

namespace Camiones.formMantenimientos
{
    public partial class Ticket : Form
    {
        int idMantenimiento;
        DataTable dtDetalle = new DataTable();
       PrintDocument printDoc = new PrintDocument();
        public Ticket()
        {
            InitializeComponent();
           printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("Ticket", 300, 600);
        }
        public Ticket(int id) : this()
        {
            idMantenimiento = id;
            MessageBox.Show("Constructor con id: " + idMantenimiento);
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Consolas", 10);
            Font fontTitulo = new Font("Consolas", 12, FontStyle.Bold);
            Font fontTotal = new Font("Consolas", 11, FontStyle.Bold);

            int y = 20;
            decimal total = 0;

            g.DrawString("TALLER MECÁNICO", fontTitulo, Brushes.Black, 20, y);
            y += 25;

            g.DrawString("Operador: " + lblOperador.Text, font, Brushes.Black, 20, y);
            y += 20;

            g.DrawString("Camión: " + lblCamion.Text, font, Brushes.Black, 20, y);
            y += 20;

            g.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), font, Brushes.Black, 20, y);
            y += 25;

            g.DrawString("--------------------------------", font, Brushes.Black, 20, y);
            y += 20;

            foreach (DataRow row in dtDetalle.Rows)
            {
                string servicio = row["nombre"].ToString();
                int cantidad = Convert.ToInt32(row["cantidad"]);
                decimal precio = Convert.ToDecimal(row["precio"]);
                decimal subtotal = Convert.ToDecimal(row["subtotal"]);

                total += subtotal;

                g.DrawString(servicio, font, Brushes.Black, 20, y);
                y += 20;

                g.DrawString($"  {cantidad} x ${precio:0.00} = ${subtotal:0.00}", font, Brushes.Black, 20, y);
                y += 20;
            }

            y += 10;
            g.DrawString("--------------------------------", font, Brushes.Black, 20, y);
            y += 20;

            g.DrawString("TOTAL: $" + total.ToString("0.00"), fontTotal, Brushes.Black, 20, y);
            y += 30;

            g.DrawString("Gracias por su preferencia", font, Brushes.Black, 20, y);
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ID recibido: " + idMantenimiento);

            string query = @"
SELECT 
    s.nombre,
    d.cantidad,
    s.precio,
    (d.cantidad * s.precio) AS subtotal,
    o.NombreCompleto,
    c.tipocamion
FROM detalle_mantenimiento d
INNER JOIN servicio s ON d.idservicio = s.idservicio
INNER JOIN mantenimiento m ON d.idmantenimiento = m.idmantenimiento
INNER JOIN vw_Operadores o ON m.idoperador = o.idoperador
INNER JOIN camion c ON m.idcamion = c.idcamion
WHERE d.idmantenimiento = @id
";

            var parametros = new Dictionary<string, object>()
            {
                { "@id", idMantenimiento }
            };

            dtDetalle = Consultas.Consultar(query, parametros);

            dgDetalle.DataSource = dtDetalle;

            if (dtDetalle.Rows.Count > 0)
            {
                lblOperador.Text = dtDetalle.Rows[0]["NombreCompleto"].ToString();
                lblCamion.Text = dtDetalle.Rows[0]["tipocamion"].ToString();
            }

            decimal total = 0;
            foreach (DataRow row in dtDetalle.Rows)
            {
                total += Convert.ToDecimal(row["subtotal"]);
            }

            lblTotal.Text = total.ToString("0.00");

            if (dgDetalle.Columns.Contains("NombreCompleto"))
                dgDetalle.Columns["NombreCompleto"].Visible = false;

            if (dgDetalle.Columns.Contains("tipocamion"))
                dgDetalle.Columns["tipocamion"].Visible = false;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vista = new PrintPreviewDialog();
            vista.Document = printDoc;
            vista.ShowDialog();

            // Si quieres imprimir directo:
            // printDoc.Print();
        }
    }

}
