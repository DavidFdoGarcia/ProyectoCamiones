using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones.destinatarios
{
    public partial class AltaDestinatarios : Base
    {
        int idDestinatario = 0;

        public AltaDestinatarios()
        {
            InitializeComponent();
        }

        private void AltaDestinatarios_Load(object sender, EventArgs e)
        {
            CargarDestinatarios();
            dgDestinatario.BackgroundColor = Color.White;
            dgDestinatario.DefaultCellStyle.BackColor = Color.White;
            dgDestinatario.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgDestinatario.EnableHeadersVisualStyles = false;
            dgDestinatario.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGray;
            dgDestinatario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarFormulario())
                {
                    MessageBox.Show("Corrija los campos marcados.",
                        "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "";

                var parametros = new Dictionary<string, object>()
                {
                    { "@nombre", txtNombre.Text.Trim() },
                    { "@planta", txtPlanta.Text.Trim() },
                    { "@estado", txtEstado.Text.Trim() },
                    { "@municipio", txtMunicipio.Text.Trim() },
                    { "@direccion", txtDireccion.Text.Trim() },
                    { "@telefono", txtTelefono.Text.Trim() },
                    { "@contacto", txtContacto.Text.Trim() },
                    { "@rfc", txtRFC.Text.Trim() }
                };

                if (idDestinatario == 0)
                {
                    query = @"
INSERT INTO dbo.altadestinatario
(nombre, planta, estado, municipio, direccion, telefono, contacto, rfc)
VALUES
(@nombre, @planta, @estado, @municipio, @direccion, @telefono, @contacto, @rfc)";
                }
                else
                {
                    query = @"
UPDATE dbo.altadestinatario
SET nombre = @nombre,
    planta = @planta,
    estado = @estado,
    municipio = @municipio,
    direccion = @direccion,
    telefono = @telefono,
    contacto = @contacto,
    rfc = @rfc
WHERE iddestinatario = @iddestinatario";

                    parametros.Add("@iddestinatario", idDestinatario);
                }

                int filas = Consultas.Ejecutar(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show(idDestinatario == 0
                        ? "Destinatario guardado correctamente"
                        : "Destinatario actualizado correctamente");

                    Limpiar();
                    CargarDestinatarios();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void CargarDestinatarios()
        {
            try
            {
                string query = @"
SELECT
    iddestinatario,
    nombre,
    planta,
    estado,
    municipio,
    direccion,
    telefono,
    contacto,
    rfc
FROM dbo.altadestinatario
ORDER BY iddestinatario DESC";

                dgDestinatario.DataSource = Consultas.Consultar(query);

                if (dgDestinatario.Columns.Contains("iddestinatario"))
                    dgDestinatario.Columns["iddestinatario"].HeaderText = "ID";

                if (dgDestinatario.Columns.Contains("nombre"))
                    dgDestinatario.Columns["nombre"].HeaderText = "Nombre";

                if (dgDestinatario.Columns.Contains("planta"))
                    dgDestinatario.Columns["planta"].HeaderText = "Planta";

                if (dgDestinatario.Columns.Contains("estado"))
                    dgDestinatario.Columns["estado"].HeaderText = "Estado";

                if (dgDestinatario.Columns.Contains("municipio"))
                    dgDestinatario.Columns["municipio"].HeaderText = "Municipio";

                if (dgDestinatario.Columns.Contains("direccion"))
                    dgDestinatario.Columns["direccion"].HeaderText = "Dirección";

                if (dgDestinatario.Columns.Contains("telefono"))
                    dgDestinatario.Columns["telefono"].HeaderText = "Teléfono";

                if (dgDestinatario.Columns.Contains("contacto"))
                    dgDestinatario.Columns["contacto"].HeaderText = "Contacto";

                if (dgDestinatario.Columns.Contains("rfc"))
                    dgDestinatario.Columns["rfc"].HeaderText = "RFC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinatarios: " + ex.Message);
            }
        }
        private bool ValidarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtPlanta.Text))
            {
                errorProvider1.SetError(txtPlanta, "Ingrese la planta.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                errorProvider1.SetError(txtEstado, "Ingrese el estado.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtMunicipio.Text))
            {
                errorProvider1.SetError(txtMunicipio, "Ingrese el municipio.");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                if (!long.TryParse(txtTelefono.Text, out _))
                {
                    errorProvider1.SetError(txtTelefono, "Solo números.");
                    valido = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtRFC.Text) && txtRFC.Text.Length < 10)
            {
                errorProvider1.SetError(txtRFC, "RFC inválido.");
                valido = false;
            }

            return valido;
        }
        private void Limpiar()
        {
            idDestinatario = 0;

            txtNombre.Clear();
            txtPlanta.Clear();
            txtEstado.Clear();
            txtMunicipio.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtContacto.Clear();
            txtRFC.Clear();

            txtNombre.Focus();
        }

        private void dgDestinatario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgDestinatario.Rows[e.RowIndex];

                    idDestinatario = Convert.ToInt32(fila.Cells["iddestinatario"].Value);
                    txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                    txtPlanta.Text = fila.Cells["planta"].Value.ToString();
                    txtEstado.Text = fila.Cells["estado"].Value.ToString();
                    txtMunicipio.Text = fila.Cells["municipio"].Value.ToString();
                    txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
                    txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                    txtContacto.Text = fila.Cells["contacto"].Value.ToString();
                    txtRFC.Text = fila.Cells["rfc"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idDestinatario == 0)
                {
                    MessageBox.Show("Seleccione un destinatario del listado");
                    return;
                }

                DialogResult resp = MessageBox.Show(
                    "¿Está seguro de eliminar este destinatario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    string query = "DELETE FROM dbo.altadestinatario WHERE iddestinatario = @iddestinatario";

                    var parametros = new Dictionary<string, object>()
            {
                { "@iddestinatario", idDestinatario }
            };

                    int filas = Consultas.Ejecutar(query, parametros);

                    if (filas > 0)
                    {
                        MessageBox.Show("Destinatario eliminado correctamente");
                        Limpiar();
                        CargarDestinatarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }
    }
}
