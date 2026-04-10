using Camiones.clases;
using Camiones.destinatarios;
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
    public partial class Mantenimiento : Base
    {
        public Mantenimiento()
        {
            InitializeComponent();


        }

        // 🔥 VARIABLES GLOBALES
        int idMantenimiento = 0;
        DataTable dtDetalle; // 👈 ESTA LÍNEA ES CLAVE


        void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataRow row in dtDetalle.Rows)
            {
                total += Convert.ToDecimal(row["Subtotal"]);
            }
            txtTotal.Text = total.ToString("0.00");
        }
        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            dtDetalle = new DataTable();
            // 🔹 Cargar servicios
            cmbServicio.DataSource = Consultas.Consultar("SELECT idservicio, nombre, precio FROM servicio");
            cmbServicio.DisplayMember = "nombre";
            cmbServicio.ValueMember = "idservicio";

            cmbCamion.DataSource = Consultas.Consultar("SELECT idcamion, tipocamion FROM camion");
            cmbCamion.DisplayMember = "tipocamion";
            cmbCamion.ValueMember = "idcamion";

            cmbOperador.DataSource = Consultas.Consultar("SELECT idoperador, NombreCompleto FROM vw_Operadores");
            cmbOperador.DisplayMember = "NombreCompleto";
            cmbOperador.ValueMember = "idoperador";


            if (dtDetalle.Columns.Count == 0)
            {
                dtDetalle.Columns.Add("idservicio");
                dtDetalle.Columns.Add("Servicio");
                dtDetalle.Columns.Add("Cantidad", typeof(int));
                dtDetalle.Columns.Add("Precio", typeof(decimal));
                dtDetalle.Columns.Add("Subtotal", typeof(decimal));
            }

            // 🔥 ASIGNAR AL GRID (CORREGIDO)
            dgDetalle.DataSource = dtDetalle;
        }
        private bool ValidarCrearMantenimiento()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (cmbCamion.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCamion, "Seleccione un camión.");
                valido = false;
            }

            if (cmbOperador.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOperador, "Seleccione un operador.");
                valido = false;
            }

            return valido;
        }
        private bool ValidarAgregarServicio()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (idMantenimiento == 0)
            {
                MessageBox.Show("Primero crea el mantenimiento.");
                return false;
            }

            if (cmbServicio.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbServicio, "Seleccione un servicio.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                errorProvider1.SetError(txtCantidad, "Ingrese la cantidad.");
                valido = false;
            }
            else if (!int.TryParse(txtCantidad.Text.Trim(), out int cantidad))
            {
                errorProvider1.SetError(txtCantidad, "La cantidad debe ser numérica.");
                valido = false;
            }
            else if (cantidad <= 0)
            {
                errorProvider1.SetError(txtCantidad, "La cantidad debe ser mayor a 0.");
                valido = false;
            }

            return valido;
        }

        private bool ValidarGuardar()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (idMantenimiento == 0)
            {
                MessageBox.Show("Primero crea el mantenimiento.");
                return false;
            }

            if (dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agrega al menos un servicio.");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtTotal.Text) &&
                !decimal.TryParse(txtTotal.Text, out _))
            {
                errorProvider1.SetError(txtTotal, "El total no es válido.");
                valido = false;
            }

            return valido;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string query = @"
            INSERT INTO mantenimiento (idcamion, idoperador)
            VALUES (@idcamion, @idoperador);
            SELECT SCOPE_IDENTITY();
            ";

            var parametros = new Dictionary<string, object>()
            {
                { "@idcamion", Convert.ToInt32(cmbCamion.SelectedValue) },
                { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) }
            };

            idMantenimiento = Convert.ToInt32(Consultas.EjecutarEscalar(query, parametros));

            MessageBox.Show("Mantenimiento creado. ID: " + idMantenimiento);
        }

        private void btnnServicio_Click(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedValue == null || txtCantidad.Text == "")
            {
                MessageBox.Show("Selecciona servicio y cantidad");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            DataRowView fila = (DataRowView)cmbServicio.SelectedItem;

            int idServicio = Convert.ToInt32(fila["idservicio"]);
            string nombre = fila["nombre"].ToString();
            decimal precio = Convert.ToDecimal(fila["precio"]);

            // 🔥 VALIDAR SI YA EXISTE
            foreach (DataRow row in dtDetalle.Rows)
            {
                if (Convert.ToInt32(row["idservicio"]) == idServicio)
                {
                    row["Cantidad"] = Convert.ToInt32(row["Cantidad"]) + cantidad;
                    row["Subtotal"] = Convert.ToDecimal(row["Cantidad"]) * precio;

                    CalcularTotal();
                    txtCantidad.Clear();
                    return;
                }
            }

            decimal subtotal = cantidad * precio;

            dtDetalle.Rows.Add(idServicio, nombre, cantidad, precio, subtotal);

            CalcularTotal();

            txtCantidad.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idMantenimiento == 0)
            {
                MessageBox.Show("Primero crea el mantenimiento");
                return;
            }

            // 🔹 Guardar detalle
            foreach (DataRow row in dtDetalle.Rows)
            {
                string queryDetalle = @"
                INSERT INTO detalle_mantenimiento (idmantenimiento, idservicio, cantidad)
                VALUES (@idmantenimiento, @idservicio, @cantidad)";

                var parametros = new Dictionary<string, object>()
                {
                    { "@idmantenimiento", idMantenimiento },
                    { "@idservicio", Convert.ToInt32(row["idservicio"]) },
                    { "@cantidad", Convert.ToInt32(row["Cantidad"]) }
                };

                Consultas.Ejecutar(queryDetalle, parametros);
            }

            // 🔹 Guardar factura
            string queryFactura = @"
            INSERT INTO factura (idmantenimiento, idoperador, total)
            VALUES (@idmantenimiento, @idoperador, @total)";

            var parametrosFactura = new Dictionary<string, object>()
            {
                { "@idmantenimiento", idMantenimiento },
                { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) },
                { "@total", string.IsNullOrEmpty(txtTotal.Text) ? 0 : Convert.ToDecimal(txtTotal.Text) }
            };

            Consultas.Ejecutar(queryFactura, parametrosFactura);

            MessageBox.Show("Guardado correctamente");

            // Guardar el id real antes de limpiar
            int idMantenimientoFinal = idMantenimiento;

            // 🔥 LIMPIAR
            dtDetalle.Rows.Clear();
            txtTotal.Clear();
            idMantenimiento = 0;

            // Abrir ticket con el id correcto
            Ticket t = new Ticket(idMantenimientoFinal);
            t.ShowDialog();
        }


        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Consolas", 10);
            int y = 20;

            // 🧾 ENCABEZADO
            g.DrawString("TALLER MECÁNICO", new Font("Consolas", 12, FontStyle.Bold), Brushes.Black, 20, y);
            y += 25;

            g.DrawString("Fecha: " + DateTime.Now.ToShortDateString(), font, Brushes.Black, 20, y);
            y += 20;

            g.DrawString("Operador: " + cmbOperador.Text, font, Brushes.Black, 20, y);
            y += 20;

            g.DrawString("Camión: " + cmbCamion.Text, font, Brushes.Black, 20, y);
            y += 30;

            g.DrawString("--------------------------------", font, Brushes.Black, 20, y);
            y += 20;

            // 🧾 DETALLE
            foreach (DataGridViewRow row in dgDetalle.Rows)
            {
                if (row.IsNewRow) continue;

                string servicio = row.Cells["Servicio"].Value.ToString();
                string cantidad = row.Cells["Cantidad"].Value.ToString();
                string subtotal = row.Cells["Subtotal"].Value.ToString();

                string linea = $"{servicio} x{cantidad}  ${subtotal}";

                g.DrawString(linea, font, Brushes.Black, 20, y);
                y += 20;
            }

            y += 10;
            g.DrawString("--------------------------------", font, Brushes.Black, 20, y);
            y += 20;

            // 🧾 TOTAL
            g.DrawString("TOTAL: $" + txtTotal.Text, new Font("Consolas", 11, FontStyle.Bold), Brushes.Black, 20, y);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (idMantenimiento == 0)
            {
                MessageBox.Show("Primero crea el mantenimiento");
                return;
            }

            Checklist frm = new Checklist(idMantenimiento);
            frm.ShowDialog();
        }
    }

}
