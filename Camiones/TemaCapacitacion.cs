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
    public partial class TemaCapacitacion : Base
    {
        public TemaCapacitacion()
        {
            InitializeComponent();
        }

        private void TemaCapacitacion_Load(object sender, EventArgs e)
        {
            txtIdtema.Enabled = false;
            txtDescripcion.Multiline = true;

            rbActivo.Checked = true;
            rbInactivo.Checked = false;
        }

        private void gbDatos_Enter(object sender, EventArgs e)
        {

        }

        // =========================
        // VALIDACIONES
        // =========================
        private bool ValidarCampos()
        {
            bool valido = true;
            errorProvider1.Clear();

            // Tema obligatorio
            if (string.IsNullOrWhiteSpace(txtTema.Text))
            {
                errorProvider1.SetError(txtTema, "Ingrese el tema.");
                valido = false;
            }
            else if (txtTema.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtTema, "Mínimo 3 caracteres.");
                valido = false;
            }
            else if (txtTema.Text.Trim().Length > 100)
            {
                errorProvider1.SetError(txtTema, "Máximo 100 caracteres.");
                valido = false;
            }

            // Descripción opcional
            if (!string.IsNullOrWhiteSpace(txtDescripcion.Text) &&
                txtDescripcion.Text.Trim().Length > 250)
            {
                errorProvider1.SetError(txtDescripcion, "Máximo 250 caracteres.");
                valido = false;
            }

            return valido;
        }

        // =========================
        // VALIDAR DUPLICADOS
        // =========================
        private bool ExisteTema(string tema)
        {
            try
            {
                string query = @"SELECT COUNT(*) FROM tema_capacitacion WHERE tema = @tema";

                var parametros = new Dictionary<string, object>()
                {
                    { "@tema", tema }
                };

                object resultado = Consultas.EjecutarEscalar(query, parametros);
                int count = Convert.ToInt32(resultado);

                return count > 0;
            }
            catch
            {
                return false;
            }
        }

        // =========================
        // LIMPIAR FORMULARIO
        // =========================
        private void LimpiarCampos()
        {
            txtIdtema.Text = "";
            txtTema.Clear();
            txtDescripcion.Clear();

            rbActivo.Checked = true;
            rbInactivo.Checked = false;

            errorProvider1.Clear();
            txtTema.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            if (ExisteTema(txtTema.Text.Trim()))
            {
                MessageBox.Show("Ese tema ya existe.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea guardar el tema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                string query = @"
INSERT INTO tema_capacitacion (tema, descripcion, activo)
VALUES (@tema, @descripcion, @activo);";

                var parametros = new Dictionary<string, object>()
                {
                    { "@tema", txtTema.Text.Trim() },
                    { "@descripcion", string.IsNullOrWhiteSpace(txtDescripcion.Text) ? (object)DBNull.Value : txtDescripcion.Text.Trim() },
                    { "@activo", rbActivo.Checked }
                };

                Consultas.Ejecutar(query, parametros);

                MessageBox.Show("Tema guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
