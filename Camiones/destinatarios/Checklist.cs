using Camiones.clases;
using Camiones.formMantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones.destinatarios
{
    public partial class Checklist : Base
    {
        int idMantenimiento;

        public Checklist()
        {
            InitializeComponent();

        }
        public Checklist(int id) : this()
        {
            idMantenimiento = id;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Checklist_Load(object sender, EventArgs e)
        {
            if (idMantenimiento == 0)
            {
                MessageBox.Show("No se recibió el id del mantenimiento");
                return;
            }

            CargarConceptosBase();


        }
        private void CargarConceptosBase()
        {
            dgvInterior.Rows.Clear();
            dgvExterior.Rows.Clear();

            // INTERIOR
            dgvInterior.Rows.Add("VOLANTE BUEN ESTADO", "", "", "");
            dgvInterior.Rows.Add("CRISTALES PUERTAS", "", "", "");
            dgvInterior.Rows.Add("APARATOS TABLERO", "", "", "");
            dgvInterior.Rows.Add("LUCES INTERIOR", "", "", "");
            dgvInterior.Rows.Add("PARO DE MOTOR", "", "", "");
            dgvInterior.Rows.Add("BOTON DE PANICO", "", "", "");

            // EXTERIOR
            dgvExterior.Rows.Add("LUCES DELANTERAS", "", "", "");
            dgvExterior.Rows.Add("DIRECCIONES", "", "", "");
            dgvExterior.Rows.Add("ESPEJOS RETROVISORES", "", "", "");
            dgvExterior.Rows.Add("PARABRISAS", "", "", "");
            dgvExterior.Rows.Add("DEFENSA", "", "", "");
            dgvExterior.Rows.Add("TANQUE DIESEL DER.", "", "", "");
            dgvExterior.Rows.Add("TANQUE DIESEL IZQ.", "", "", "");
            dgvExterior.Rows.Add("LUCES TRASERAS", "", "", "");
            dgvExterior.Rows.Add("REVERSORES", "", "", "");
            dgvExterior.Rows.Add("LLANTAS DELANTERAS DER.", "", "", "");
            dgvExterior.Rows.Add("LLANTAS DELANTERAS IZQ.", "", "", "");
            dgvExterior.Rows.Add("LLANTAS TRASERAS DER.", "", "", "");
            dgvExterior.Rows.Add("LLANTAS TRASERAS IZQ.", "", "", "");
            dgvExterior.Rows.Add("QUINTA RUEDA", "", "", "");
            dgvExterior.Rows.Add("TANQUE DE AIRE", "", "", "");

            CargarChecklistGuardado();
        }

        private int ObtenerIdOperador()
        {
            string query = "SELECT idoperador FROM mantenimiento WHERE idmantenimiento = @id";

            var parametros = new Dictionary<string, object>()
    {
        { "@id", idMantenimiento }
    };

            object resultado = Consultas.EjecutarEscalar(query, parametros);
            return Convert.ToInt32(resultado);
        }
        private void SubirEvidencia(DataGridView grid, string tipoCarpeta)
        {
            if (grid.CurrentRow == null || grid.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona una fila");
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecciona evidencia";
                ofd.Filter = "Archivos permitidos|*.jpg;*.jpeg;*.png;*.pdf";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int idOperador = ObtenerIdOperador();

                    string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string carpetaBase = Path.Combine(escritorio, "DocumentosClientes");
                    string carpetaOperador = Path.Combine(carpetaBase, idOperador.ToString());
                    string carpetaChecklist = Path.Combine(carpetaOperador, "Checklist");
                    string carpetaTipo = Path.Combine(carpetaChecklist, tipoCarpeta);

                    if (!Directory.Exists(carpetaTipo))
                        Directory.CreateDirectory(carpetaTipo);

                    string extension = Path.GetExtension(ofd.FileName);
                    string concepto = grid.CurrentRow.Cells[0].Value?.ToString()?.Replace(" ", "_") ?? "evidencia";
                    string nombreArchivo = concepto + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + extension;

                    string rutaDestino = Path.Combine(carpetaTipo, nombreArchivo);
                    File.Copy(ofd.FileName, rutaDestino, true);

                    // Ruta relativa para guardar en BD
                    string rutaRelativa = Path.Combine(idOperador.ToString(), "Checklist", tipoCarpeta, nombreArchivo);

                    grid.CurrentRow.Cells[2].Value = rutaRelativa; // columna Evidencia
                    MessageBox.Show("Evidencia subida correctamente");
                }
            }
        }
        private void CargarChecklistGuardado()
        {
            string query = @"
SELECT tipo, concepto, comentario, evidencia, accion
FROM checklist_detalle
WHERE idmantenimiento = @id";

            var parametros = new Dictionary<string, object>()
            {
                { "@id", idMantenimiento }
            };

            DataTable dt = Consultas.Consultar(query, parametros);

            if (dt.Rows.Count == 0)
                return;

            foreach (DataRow dr in dt.Rows)
            {
                string tipo = dr["tipo"].ToString();
                string concepto = dr["concepto"].ToString();
                string comentario = dr["comentario"].ToString();
                string evidencia = dr["evidencia"].ToString();
                string accion = dr["accion"].ToString();

                DataGridView grid = tipo == "INTERIOR" ? dgvInterior : dgvExterior;

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    if ((row.Cells[0].Value?.ToString() ?? "") == concepto)
                    {
                        row.Cells[1].Value = comentario;
                        row.Cells[2].Value = evidencia;
                        row.Cells[3].Value = accion;
                        break;
                    }
                }
            }
        }
        private void dgvInterior_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvInterior.Columns[e.ColumnIndex].Name == "btnEvidencia1")
            {
                SubirEvidencia(dgvInterior, "Interior");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idMantenimiento == 0)
            {
                MessageBox.Show("Primero debes crear el mantenimiento");
                return;
            }

            // Borra lo anterior para no duplicar si vuelven a guardar
            string deleteQuery = "DELETE FROM checklist_detalle WHERE idmantenimiento = @id";
            var deleteParams = new Dictionary<string, object>()
            {
                { "@id", idMantenimiento }
            };
            Consultas.Ejecutar(deleteQuery, deleteParams);

            GuardarGrid(dgvInterior, "INTERIOR");
            GuardarGrid(dgvExterior, "EXTERIOR");

            MessageBox.Show("Checklist guardado correctamente");
        }

        private void GuardarGrid(DataGridView grid, string tipo)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                string concepto = row.Cells[0].Value?.ToString() ?? "";
                string comentario = row.Cells[1].Value?.ToString() ?? "";
                string evidencia = row.Cells[2].Value?.ToString() ?? "";
                string accion = row.Cells[3].Value?.ToString() ?? "";

                if (string.IsNullOrWhiteSpace(concepto))
                    continue;

                string query = @"
INSERT INTO checklist_detalle
(idmantenimiento, tipo, concepto, comentario, evidencia, accion)
VALUES
(@id, @tipo, @concepto, @comentario, @evidencia, @accion)";

                var parametros = new Dictionary<string, object>()
                {
                    { "@id", idMantenimiento },
                    { "@tipo", tipo },
                    { "@concepto", concepto },
                    { "@comentario", comentario },
                    { "@evidencia", evidencia },
                    { "@accion", accion }
                };

                Consultas.Ejecutar(query, parametros);
            }
        }

        private void dgvExterior_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvExterior.Columns[e.ColumnIndex].Name == "btnEvidencia2")
            {
                SubirEvidencia(dgvExterior, "Exterior");
            }
        }
    }

}
