using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Camiones.clases;

namespace Camiones
{
    public partial class MantenimientoCamiones : Base
    {
        public MantenimientoCamiones()
        {
            InitializeComponent();
        }
        // 🔥 AQUÍ DECLARAS EL MÉTODO
        decimal ObtenerValor(string texto)
        {
            decimal valor;
            if (decimal.TryParse(texto, out valor))
                return valor;
            else
                return 0;
        }

        // 🔥 FUNCIÓN DEL TOTAL
        decimal CalcularTotal()
        {
            decimal total = 0;

            total += ObtenerValor(txtLlantas.Text) * ObtenerValor(txtCostoLlantas.Text);
            total += ObtenerValor(txtRetenes.Text) * ObtenerValor(txtCostosRetenes.Text);
            total += ObtenerValor(txtFlechas.Text) * ObtenerValor(txtCostosFlechas.Text);
            total += ObtenerValor(txtTransmicion.Text) * ObtenerValor(txtCostoTransmicion.Text);
            total += ObtenerValor(txtCarroocerias.Text) * ObtenerValor(txtCostoCarrocerias.Text);
            total += ObtenerValor(txtParabrisas.Text) * ObtenerValor(txtCostoParabrisas.Text);
            total += ObtenerValor(txtSoldaduras.Text) * ObtenerValor(txtCostoSoldadura.Text);
            total += ObtenerValor(txtMotor.Text) * ObtenerValor(txtCostoMotor.Text);

            return total;
        }
        private void RecalcularTotal(object sender, EventArgs e)
        {
            txtTotal.Text = CalcularTotal().ToString("0.00");
        }

        // 🔥 BOTÓN FACTURA
        private void btnFactura_Click(object sender, EventArgs e)
        {
            try
            {
                int idMantenimiento = Convert.ToInt32(txtID.Text);

                string queryFactura = @"
        INSERT INTO factura (idmantenimiento, idoperador, fecha, total)
        VALUES (@idmantenimiento, @idoperador, @fecha, @total);
        ";

                var parametros = new Dictionary<string, object>()
        {
            { "@idmantenimiento", idMantenimiento },
            { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) },
            { "@fecha", DateTime.Now },
            { "@total", Convert.ToDecimal(txtTotal.Text) }
        };

                Consultas.Ejecutar(queryFactura, parametros);

                MessageBox.Show("Factura generada correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @"
        INSERT INTO dbo.mantenimiento
        (idcamion, placas, fecha, llantas, retenes, flechas, transmicion, motor, carrocerias, parabrisas, soldaduras, idoperador)
        VALUES
        (@idcamion, @placas, @fecha, @llantas, @retenes, @flechas, @transmicion, @motor, @carrocerias, @parabrisas, @soldaduras, @idoperador);

        SELECT SCOPE_IDENTITY();
        ";

                var parametros = new Dictionary<string, object>()
        {
            { "@idcamion", Convert.ToInt32(cmbCamion.SelectedValue) },
            { "@placas", txtPlacas.Text },
            { "@fecha", dtFecha.Value }, // luego te recomiendo usar DateTime
            { "@llantas", txtLlantas.Text },
            { "@retenes", txtRetenes.Text },
            { "@flechas", txtFlechas.Text },
            { "@transmicion", txtTransmicion.Text },
            { "@motor", txtMotor.Text },
            { "@carrocerias", txtCarroocerias.Text },
            { "@parabrisas", txtParabrisas.Text },
            { "@soldaduras", txtSoldaduras.Text },
            { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) }
        };



                object resultado = Consultas.EjecutarEscalar(query, parametros);

                if (resultado != null)
                {
                    int idGenerado = Convert.ToInt32(resultado);

                    txtID.Text = idGenerado.ToString();

                    MessageBox.Show($"Mantenimiento guardado correctamente. ID: {idGenerado}");

                    // 👉 AQUÍ YA PUEDES USAR EL ID PARA FACTURA
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID generado");
                }

                //  txtIDMantenimiento.Text = idGenerado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // txtIDMantenimiento.Enabled = false;
        }

        private void MantenimientoCamiones_Load(object sender, EventArgs e)
        {
            txtLlantas.TextChanged += RecalcularTotal;
            txtCostoLlantas.TextChanged += RecalcularTotal;

            txtRetenes.TextChanged += RecalcularTotal;
            txtCostosRetenes.TextChanged += RecalcularTotal;

            txtFlechas.TextChanged += RecalcularTotal;
            txtCostosFlechas.TextChanged += RecalcularTotal;

            txtTransmicion.TextChanged += RecalcularTotal;
            txtCostoTransmicion.TextChanged += RecalcularTotal;

            txtCarroocerias.TextChanged += RecalcularTotal;
            txtCostoCarrocerias.TextChanged += RecalcularTotal;

            txtParabrisas.TextChanged += RecalcularTotal;
            txtCostoParabrisas.TextChanged += RecalcularTotal;

            txtSoldaduras.TextChanged += RecalcularTotal;
            txtCostoSoldadura.TextChanged += RecalcularTotal;

            txtMotor.TextChanged += RecalcularTotal;
            txtCostoMotor.TextChanged += RecalcularTotal;


            // --- COMBO OPERADOR ---
            DataTable dtOperador = Camiones.clases.Operador.ObtenerOperadores();

            DataRow filaOperador = dtOperador.NewRow();
            filaOperador["idoperador"] = 0;
            filaOperador["NombreCompleto"] = "--Seleccione un operador--";
            dtOperador.Rows.InsertAt(filaOperador, 0);

            cmbOperador.DataSource = dtOperador;
            cmbOperador.DisplayMember = "NombreCompleto";
            cmbOperador.ValueMember = "idoperador";
            cmbOperador.SelectedIndex = 0;

            // --- COMBO CAMIÓN ---
            DataTable dtCamion = Camiones.clases.Operador.ObtenerCamiones();

            DataRow filaCamion = dtCamion.NewRow();
            filaCamion["idcamion"] = 0;
            filaCamion["tipocamion"] = "--Seleccione un camión--";
            dtCamion.Rows.InsertAt(filaCamion, 0);

            cmbCamion.DataSource = dtCamion;
            cmbCamion.DisplayMember = "tipocamion";
            cmbCamion.ValueMember = "idcamion";
            cmbCamion.SelectedIndex = 0;
        }
    }


}
