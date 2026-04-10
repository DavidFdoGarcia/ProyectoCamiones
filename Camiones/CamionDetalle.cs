using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones
{
    public partial class CamionDetalle : Base
    {
        public CamionDetalle()
        {
            InitializeComponent();
        }

        private void CamionDetalle_Load(object sender, EventArgs e)
        {
            txtIdDetalle.Enabled = false;
            ChkActivo.Checked = true;

            CargarCamiones();
            LimpiarCampos(false);
        }
        // =========================
        // CARGAR CAMIONES
        // =========================
        private void CargarCamiones()
        {
            try
            {
                cmbCamion.DataSource = Operador.ObtenerCamiones();
                cmbCamion.DisplayMember = "tipocamion";
                cmbCamion.ValueMember = "idcamion";

                if (cmbCamion.Items.Count > 0)
                    cmbCamion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar camiones: " + ex.Message);
            }
        }

        // =========================
        // VALIDAR
        // =========================
        private bool ValidarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (cmbCamion.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCamion, "Seleccione un camión.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPlacas.Text))
            {
                errorProvider1.SetError(txtPlacas, "Ingrese las placas.");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                if (!int.TryParse(txtAnio.Text, out int anio))
                {
                    errorProvider1.SetError(txtAnio, "Ingrese un año válido.");
                    valido = false;
                }
            }

            if (txtSerie.Text.Length > 100)
            {
                errorProvider1.SetError(txtSerie, "Máximo 100 caracteres.");
                valido = false;
            }

            return valido;
        }

        // =========================
        // LIMPIAR
        // =========================
        private void LimpiarCampos(bool limpiarCombo = true)
        {
            txtIdDetalle.Clear();
            txtPlacas.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnio.Clear();
            txtColor.Clear();
            txtSerie.Clear();

            ChkActivo.Checked = true;

            if (limpiarCombo && cmbCamion.Items.Count > 0)
                cmbCamion.SelectedIndex = 0;

            errorProvider1.Clear();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Corrija los campos marcados.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea guardar el camión?",
                "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                string query = @"
INSERT INTO camion_detalle
(
    idcamion,
    placas,
    marca,
    modelo,
    anio,
    color,
    numSerie,
    activo
)
VALUES
(
    @idcamion,
    @placas,
    @marca,
    @modelo,
    @anio,
    @color,
    @numSerie,
    @activo
);

SELECT SCOPE_IDENTITY();";

                var parametros = new Dictionary<string, object>()
                {
                    { "@idcamion", Convert.ToInt32(cmbCamion.SelectedValue) },
                    { "@placas", txtPlacas.Text.Trim() },
                    { "@marca", string.IsNullOrWhiteSpace(txtMarca.Text) ? (object)DBNull.Value : txtMarca.Text.Trim() },
                    { "@modelo", string.IsNullOrWhiteSpace(txtModelo.Text) ? (object)DBNull.Value : txtModelo.Text.Trim() },
                    { "@anio", string.IsNullOrWhiteSpace(txtAnio.Text) ? (object)DBNull.Value : Convert.ToInt32(txtAnio.Text) },
                    { "@color", string.IsNullOrWhiteSpace(txtColor.Text) ? (object)DBNull.Value : txtColor.Text.Trim() },
                    { "@numSerie", string.IsNullOrWhiteSpace(txtSerie.Text) ? (object)DBNull.Value : txtSerie.Text.Trim() },
                    { "@activo", ChkActivo.Checked }
                };

                object resultado = Consultas.EjecutarEscalar(query, parametros);
                int idGenerado = Convert.ToInt32(resultado);

                txtIdDetalle.Text = idGenerado.ToString();

                MessageBox.Show("Camión guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
