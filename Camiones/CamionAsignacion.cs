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
    public partial class CamionAsignacion : Base
    {
        public CamionAsignacion()
        {
            InitializeComponent();
        }

        private void CamionAsignacion_Load(object sender, EventArgs e)
        {
            txtIdAsignacion.Enabled = false;
            txtObservaciones.Multiline = true;

            chkActivvo.Checked = true;
            chkSinFechaFin.Checked = true;
            dtpFechaFin.Enabled = false;

            CargarOperadores();
            CargarCamionesDetalle();
            ConsultarAsignaciones();
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

        private void CargarCamionesDetalle()
        {
            try
            {
                string query = @"
SELECT 
    cd.idcamiondetalle,
    c.tipocamion + ' - ' + cd.placas AS CamionAsignado
FROM camion_detalle cd
INNER JOIN camion c ON cd.idcamion = c.idcamion
WHERE cd.activo = 1
ORDER BY c.tipocamion, cd.placas";

                DataTable dt = Consultas.Consultar(query);

                cmbCamionDetalle.DataSource = dt;
                cmbCamionDetalle.DisplayMember = "CamionAsignado";
                cmbCamionDetalle.ValueMember = "idcamiondetalle";

                if (dt.Rows.Count > 0)
                    cmbCamionDetalle.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar camiones: " + ex.Message,
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

            if (cmbCamionDetalle.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCamionDetalle, "Seleccione un camión.");
                valido = false;
            }

            if (cmbOperador.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOperador, "Seleccione un operador.");
                valido = false;
            }

            if (dtpFechaAsignacion.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpFechaAsignacion, "La fecha de asignación no puede ser mayor a hoy.");
                valido = false;
            }

            if (!chkSinFechaFin.Checked)
            {
                if (dtpFechaFin.Value.Date < dtpFechaAsignacion.Value.Date)
                {
                    errorProvider1.SetError(dtpFechaFin, "La fecha fin no puede ser menor que la fecha de asignación.");
                    valido = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtObservaciones.Text) &&
                txtObservaciones.Text.Trim().Length > 300)
            {
                errorProvider1.SetError(txtObservaciones, "Máximo 300 caracteres.");
                valido = false;
            }

            return valido;
        }

        // =========================
        // LIMPIAR
        // =========================
        private void LimpiarCampos(bool limpiarCombos = true)
        {
            txtIdAsignacion.Clear();
            txtObservaciones.Clear();

            dtpFechaAsignacion.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            chkActivvo.Checked = true;
            chkSinFechaFin.Checked = true;
            dtpFechaFin.Enabled = false;

            if (limpiarCombos)
            {
                if (cmbCamionDetalle.Items.Count > 0)
                    cmbCamionDetalle.SelectedIndex = 0;

                if (cmbOperador.Items.Count > 0)
                    cmbOperador.SelectedIndex = 0;
            }

            errorProvider1.Clear();
        }

        // =========================
        // CONSULTAR GRID
        // =========================
        private void ConsultarAsignaciones()
        {
            try
            {
                string query = @"
SELECT 
    ca.idasignacion,
    cd.idcamiondetalle,
    c.tipocamion,
    cd.placas,
    o.idoperador,
    o.nombreoperador + ' ' + o.apellidopoperador + ' ' + o.apellidomoperador AS Operador,
    ca.fecha_asignacion,
    ca.fecha_fin,
    ca.observaciones,
    ca.activo
FROM camion_asignacion ca
INNER JOIN camion_detalle cd ON ca.idcamiondetalle = cd.idcamiondetalle
INNER JOIN camion c ON cd.idcamion = c.idcamion
INNER JOIN operador o ON ca.idoperador = o.idoperador
ORDER BY ca.idasignacion DESC";

                dgAsignaciones.DataSource = Consultas.Consultar(query);
                dgAsignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar asignaciones: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // CERRAR ASIGNACION ACTIVA
        // =========================
        private void CerrarAsignacionActivaSiExiste(int idCamionDetalle, DateTime fechaAsignacionNueva)
        {
            string query = @"
UPDATE camion_asignacion
SET fecha_fin = @fecha_fin,
    activo = 0
WHERE idcamiondetalle = @idcamiondetalle
AND activo = 1
AND fecha_fin IS NULL";

            var parametros = new Dictionary<string, object>()
            {
                { "@fecha_fin", fechaAsignacionNueva.Date.AddDays(-1) },
                { "@idcamiondetalle", idCamionDetalle }
            };

            Consultas.Ejecutar(query, parametros);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Corrija los campos marcados.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea guardar la asignación del camión?",
                "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                int idCamionDetalle = Convert.ToInt32(cmbCamionDetalle.SelectedValue);

                // Cierra la asignación activa anterior si existe
                CerrarAsignacionActivaSiExiste(idCamionDetalle, dtpFechaAsignacion.Value);

                string query = @"
INSERT INTO camion_asignacion
(
    idcamiondetalle,
    idoperador,
    fecha_asignacion,
    fecha_fin,
    observaciones,
    activo
)
VALUES
(
    @idcamiondetalle,
    @idoperador,
    @fecha_asignacion,
    @fecha_fin,
    @observaciones,
    @activo
);

SELECT SCOPE_IDENTITY();";

                var parametros = new Dictionary<string, object>()
                {
                    { "@idcamiondetalle", idCamionDetalle },
                    { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) },
                    { "@fecha_asignacion", dtpFechaAsignacion.Value.Date },
                    { "@fecha_fin", chkSinFechaFin.Checked ? (object)DBNull.Value : dtpFechaFin.Value.Date },
                    { "@observaciones", string.IsNullOrWhiteSpace(txtObservaciones.Text) ? (object)DBNull.Value : txtObservaciones.Text.Trim() },
                    { "@activo", chkActivvo.Checked }
                };

                object resultado = Consultas.EjecutarEscalar(query, parametros);
                int idGenerado = Convert.ToInt32(resultado);

                txtIdAsignacion.Text = idGenerado.ToString();

                MessageBox.Show("Asignación guardada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ConsultarAsignaciones();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la asignación: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSinFechaFin_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaFin.Enabled = !chkSinFechaFin.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarAsignaciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgAsignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAsignaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIdAsignacion.Text = dgAsignaciones.CurrentRow.Cells["idasignacion"].Value.ToString();
                cmbCamionDetalle.Text = dgAsignaciones.CurrentRow.Cells["tipocamion"].Value.ToString() + " - " +
                                        dgAsignaciones.CurrentRow.Cells["placas"].Value.ToString();
                cmbOperador.Text = dgAsignaciones.CurrentRow.Cells["Operador"].Value.ToString();
                dtpFechaAsignacion.Value = Convert.ToDateTime(dgAsignaciones.CurrentRow.Cells["fecha_asignacion"].Value);

                if (dgAsignaciones.CurrentRow.Cells["fecha_fin"].Value == DBNull.Value)
                {
                    chkSinFechaFin.Checked = true;
                }
                else
                {
                    chkSinFechaFin.Checked = false;
                    dtpFechaFin.Value = Convert.ToDateTime(dgAsignaciones.CurrentRow.Cells["fecha_fin"].Value);
                }

                txtObservaciones.Text = dgAsignaciones.CurrentRow.Cells["observaciones"].Value.ToString();
                chkActivvo.Checked = Convert.ToBoolean(dgAsignaciones.CurrentRow.Cells["activo"].Value);
            }
        }
    }
}
