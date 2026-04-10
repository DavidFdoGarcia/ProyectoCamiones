using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Camiones
{
    public partial class NuevaCapacitacion : Base
    {
        public NuevaCapacitacion()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Corrija los campos marcados.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea guardar la capacitación?",
                "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                string query = @"
INSERT INTO capacitacion_operador
(
    idoperador,
    fecha,
    observaciones,
    activo,
    idtema
)
VALUES
(
    @idoperador,
    @fecha,
    @observaciones,
    @activo,
    @idtema
);

SELECT SCOPE_IDENTITY();";

                var parametros = new Dictionary<string, object>()
                {
                    { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) },
                    { "@fecha", dtpFecha.Value.Date },
                    { "@observaciones", string.IsNullOrWhiteSpace(txtObservaciones.Text) ? (object)DBNull.Value : txtObservaciones.Text.Trim() },
                    { "@activo", chkActivo.Checked },
                    { "@idtema", Convert.ToInt32(cmbTema.SelectedValue) }
                };

                object resultado = Consultas.EjecutarEscalar(query, parametros);
                int idGenerado = Convert.ToInt32(resultado);

                txtIdCapacitacion.Text = idGenerado.ToString();

                // OPCIONAL:
                // Si todavía sigues usando el contador "capacitaciones" en operador,
                // descomenta esto para mantenerlo actualizado.

                /*
                string queryActualizarOperador = @"
                    UPDATE operador
                    SET capacitaciones = ISNULL(capacitaciones, 0) + 1
                    WHERE idoperador = @idoperador";

                var parametrosOperador = new Dictionary<string, object>()
                {
                    { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) }
                };

                Consultas.Ejecutar(queryActualizarOperador, parametrosOperador);
                */

                MessageBox.Show("Capacitación guardada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la capacitación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NuevaCapacitacion_Load(object sender, EventArgs e)
        {
            txtIdCapacitacion.Enabled = false;
            txtRutaEvidencia.ReadOnly = true;
            txtObservaciones.Multiline = true;

            chkActivo.Checked = true;

            CargarOperadores();
            CargarTemas();
            LimpiarCampos(false);
        }
        // =========================
        // LIMPIAR
        // =========================
        private void LimpiarCampos(bool limpiarOperadorTema = true)
        {
            txtIdCapacitacion.Clear();
            txtObservaciones.Clear();
            txtRutaEvidencia.Clear();

            if (limpiarOperadorTema)
            {
                cmbOperador.SelectedIndex = -1;
                cmbTema.SelectedIndex = -1;
            }

            dtpFecha.Value = DateTime.Now;
            chkActivo.Checked = true;

            errorProvider1.Clear();
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
                cmbOperador.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar operadores: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTemas()
        {
            try
            {
                string query = @"
            SELECT idtema, tema
            FROM tema_capacitacion
            WHERE activo = 1
            ORDER BY tema ASC";

                DataTable dt = Consultas.Consultar(query);

                cmbTema.DataSource = dt;
                cmbTema.DisplayMember = "tema";
                cmbTema.ValueMember = "idtema";

                if (dt.Rows.Count > 0)
                    cmbTema.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar temas: " + ex.Message,
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

            if (cmbTema.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbTema, "Seleccione un tema.");
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

            return valido;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
            Clsoperador.SubirCapacitacion(idOperador, txtRutaEvidencia);
        }
    }
}
