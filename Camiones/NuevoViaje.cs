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
    public partial class NuevoViaje : Base
    {
        public NuevoViaje()
        {
            InitializeComponent();
        }

        private void NuevoViaje_Load(object sender, EventArgs e)
        {
            txtIdViaje.Enabled = false;
            txtRutaEvidencia.ReadOnly = true;
            txtObservaciones.Multiline = true;
            chkActivo.Checked = true;

            CargarOperadores();
            CargarDestinatarios();
            LimpiarCampos(false);
        }
        // =========================
        // CARGAR COMBOS
        // =========================
        private void CargarOperadores()
        {
            try
            {
                cmbOperador.DataSource = Operador.ObtenerOperadores();
                cmbOperador.DisplayMember = "NombreOperador";
                cmbOperador.ValueMember = "idoperador";

                if (cmbOperador.Items.Count > 0)
                    cmbOperador.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operadores: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDestinatarios()
        {
            try
            {
                string query = @"
                    SELECT iddestinatario, nombre
                    FROM altadestinatario
                    WHERE activo = 1
                    ORDER BY nombre ASC";

                DataTable dt = Consultas.Consultar(query);

                cmbDestinatario.DataSource = dt;
                cmbDestinatario.DisplayMember = "nombre";
                cmbDestinatario.ValueMember = "iddestinatario";

                if (dt.Rows.Count > 0)
                    cmbDestinatario.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinatarios: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // VALIDAR
        // =========================
        private bool ValidarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (cmbOperador.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOperador, "Seleccione un operador.");
                valido = false;
            }

            if (cmbDestinatario.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDestinatario, "Seleccione un destinatario.");
                valido = false;
            }

            if (dtpFecha.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpFecha, "La fecha no puede ser mayor a hoy.");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtObservaciones.Text) &&
                txtObservaciones.Text.Trim().Length > 300)
            {
                errorProvider1.SetError(txtObservaciones, "Máximo 300 caracteres.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtRutaEvidencia.Text))
            {
                errorProvider1.SetError(txtRutaEvidencia, "Suba la evidencia del viaje.");
                valido = false;
            }

            return valido;
        }

        // =========================
        // LIMPIAR
        // =========================
        private void LimpiarCampos(bool limpiarCombos = true)
        {
            txtIdViaje.Clear();
            txtObservaciones.Clear();
            txtRutaEvidencia.Clear();

            dtpFecha.Value = DateTime.Now;
            chkActivo.Checked = true;

            if (limpiarCombos)
            {
                if (cmbOperador.Items.Count > 0)
                    cmbOperador.SelectedIndex = 0;

                if (cmbDestinatario.Items.Count > 0)
                    cmbDestinatario.SelectedIndex = 0;
            }

            errorProvider1.Clear();
        }

      

        private void btnSubirEvidencia_Click(object sender, EventArgs e)
        {
            if (cmbOperador.SelectedIndex == -1)
            {
                MessageBox.Show("Primero seleccione un operador.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbOperador.Focus();
                return;
            }

            string idOperador = cmbOperador.SelectedValue.ToString();
            Clsoperador.SubirViajes(idOperador, txtRutaEvidencia);
        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Corrija los campos marcados.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea guardar el viaje?",
                "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                string query = @"
INSERT INTO detalle_viaje
(
    idoperador,
    iddestinatario,
    fecha,
    observaciones,
    activo
)
VALUES
(
    @idoperador,
    @iddestinatario,
    @fecha,
    @observaciones,
    @activo
);

SELECT SCOPE_IDENTITY();";

                var parametros = new Dictionary<string, object>()
                {
                    { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) },
                    { "@iddestinatario", Convert.ToInt32(cmbDestinatario.SelectedValue) },
                    { "@fecha", dtpFecha.Value.Date },
                    { "@observaciones", string.IsNullOrWhiteSpace(txtObservaciones.Text) ? (object)DBNull.Value : txtObservaciones.Text.Trim() },
                    { "@activo", chkActivo.Checked }
                };

                object resultado = Consultas.EjecutarEscalar(query, parametros);
                int idGenerado = Convert.ToInt32(resultado);

                txtIdViaje.Text = idGenerado.ToString();

                MessageBox.Show("Viaje guardado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el viaje: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
