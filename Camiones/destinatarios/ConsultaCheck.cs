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
    public partial class ConsultaCheck : Base
    {
        public ConsultaCheck()
        {
            InitializeComponent();
        }

        private void ConsultaCheck_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarFiltros();
            CargarMantenimientos();
        }
        private void ConfigurarGrid()
        {
            dgConsultaChecklist.AllowUserToAddRows = false;
            dgConsultaChecklist.AllowUserToDeleteRows = false;
            dgConsultaChecklist.AllowUserToResizeRows = false;
            dgConsultaChecklist.ReadOnly = true;
            dgConsultaChecklist.MultiSelect = false;
            dgConsultaChecklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgConsultaChecklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgConsultaChecklist.RowHeadersVisible = false;
            dgConsultaChecklist.BackgroundColor = Color.White;
            dgConsultaChecklist.BorderStyle = BorderStyle.Fixed3D;
            dgConsultaChecklist.EnableHeadersVisualStyles = false;
            dgConsultaChecklist.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgConsultaChecklist.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgConsultaChecklist.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgConsultaChecklist.ColumnHeadersHeight = 35;
            dgConsultaChecklist.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgConsultaChecklist.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgConsultaChecklist.DefaultCellStyle.SelectionForeColor = Color.White;
            dgConsultaChecklist.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);
            dgConsultaChecklist.RowTemplate.Height = 28;
        }
        private void CargarFiltros()
        {
            DataTable dtOperadores = Consultas.Consultar(@"
SELECT 0 AS idoperador, 'TODOS' AS NombreCompleto
UNION ALL
SELECT idoperador, NombreCompleto
FROM vw_Operadores");

            cmbOperadorFiltro.DataSource = dtOperadores;
            cmbOperadorFiltro.DisplayMember = "NombreCompleto";
            cmbOperadorFiltro.ValueMember = "idoperador";

            DataTable dtCamiones = Consultas.Consultar(@"
SELECT 0 AS idcamion, 'TODOS' AS tipocamion
UNION ALL
SELECT idcamion, tipocamion
FROM camion");

            cmbCamionFiltro.DataSource = dtCamiones;
            cmbCamionFiltro.DisplayMember = "tipocamion";
            cmbCamionFiltro.ValueMember = "idcamion";

            cmbOperadorFiltro.SelectedIndex = 0;
            cmbCamionFiltro.SelectedIndex = 0;

            dtpInicio.Checked = false;
            dtpFin.Checked = false;
        }

        private void CargarMantenimientos()
        {
            string query = @"
SELECT 
    m.idmantenimiento,
    o.NombreCompleto,
    c.tipocamion,
    m.fecha,
    ISNULL(f.total, 0) AS total,
    CASE 
        WHEN EXISTS (
            SELECT 1 
            FROM checklist_detalle cd 
            WHERE cd.idmantenimiento = m.idmantenimiento
        ) THEN 'Sí'
        ELSE 'No'
    END AS TieneChecklist
FROM mantenimiento m
INNER JOIN vw_Operadores o ON m.idoperador = o.idoperador
INNER JOIN camion c ON m.idcamion = c.idcamion
LEFT JOIN factura f ON f.idmantenimiento = m.idmantenimiento
ORDER BY m.idmantenimiento DESC";

            dgConsultaChecklist.DataSource = Consultas.Consultar(query);
            FormatearColumnas();
        }

        private void FormatearColumnas()
        {
            if (dgConsultaChecklist.Columns.Count == 0)
                return;

            if (dgConsultaChecklist.Columns.Contains("idmantenimiento"))
                dgConsultaChecklist.Columns["idmantenimiento"].HeaderText = "ID";

            if (dgConsultaChecklist.Columns.Contains("NombreCompleto"))
                dgConsultaChecklist.Columns["NombreCompleto"].HeaderText = "Operador";

            if (dgConsultaChecklist.Columns.Contains("tipocamion"))
                dgConsultaChecklist.Columns["tipocamion"].HeaderText = "Camión";

            if (dgConsultaChecklist.Columns.Contains("fecha"))
                dgConsultaChecklist.Columns["fecha"].HeaderText = "Fecha";

            if (dgConsultaChecklist.Columns.Contains("total"))
            {
                dgConsultaChecklist.Columns["total"].HeaderText = "Total";
                dgConsultaChecklist.Columns["total"].DefaultCellStyle.Format = "N2";
            }

            if (dgConsultaChecklist.Columns.Contains("TieneChecklist"))
                dgConsultaChecklist.Columns["TieneChecklist"].HeaderText = "Checklist";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = @"
SELECT 
    m.idmantenimiento,
    o.NombreCompleto,
    c.tipocamion,
    m.fecha,
    ISNULL(f.total, 0) AS total,
    CASE 
        WHEN EXISTS (
            SELECT 1 
            FROM checklist_detalle cd 
            WHERE cd.idmantenimiento = m.idmantenimiento
        ) THEN 'Sí'
        ELSE 'No'
    END AS TieneChecklist
FROM mantenimiento m
INNER JOIN vw_Operadores o ON m.idoperador = o.idoperador
INNER JOIN camion c ON m.idcamion = c.idcamion
LEFT JOIN factura f ON f.idmantenimiento = m.idmantenimiento
WHERE 1 = 1
";

            var parametros = new Dictionary<string, object>();

            if (!string.IsNullOrWhiteSpace(txtIdMantenimiento.Text))
            {
                if (!int.TryParse(txtIdMantenimiento.Text.Trim(), out int idBuscado))
                {
                    MessageBox.Show("El ID de mantenimiento debe ser numérico");
                    return;
                }

                query += " AND m.idmantenimiento = @idmantenimiento ";
                parametros.Add("@idmantenimiento", idBuscado);
            }

            if (cmbOperadorFiltro.SelectedValue != null && Convert.ToInt32(cmbOperadorFiltro.SelectedValue) != 0)
            {
                query += " AND m.idoperador = @idoperador ";
                parametros.Add("@idoperador", Convert.ToInt32(cmbOperadorFiltro.SelectedValue));
            }

            if (cmbCamionFiltro.SelectedValue != null && Convert.ToInt32(cmbCamionFiltro.SelectedValue) != 0)
            {
                query += " AND m.idcamion = @idcamion ";
                parametros.Add("@idcamion", Convert.ToInt32(cmbCamionFiltro.SelectedValue));
            }

            if (dtpInicio.Checked)
            {
                query += " AND CAST(m.fecha AS DATE) >= @fechainicio ";
                parametros.Add("@fechainicio", dtpInicio.Value.Date);
            }

            if (dtpFin.Checked)
            {
                query += " AND CAST(m.fecha AS DATE) <= @fechafin ";
                parametros.Add("@fechafin", dtpFin.Value.Date);
            }

            if (chkSoloConChecklist.Checked)
            {
                query += @"
 AND EXISTS (
     SELECT 1
     FROM checklist_detalle cd
     WHERE cd.idmantenimiento = m.idmantenimiento
 )";
            }

            query += " ORDER BY m.idmantenimiento DESC";

            dgConsultaChecklist.DataSource = Consultas.Consultar(query, parametros);
            FormatearColumnas();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtIdMantenimiento.Clear();
            cmbOperadorFiltro.SelectedIndex = 0;
            cmbCamionFiltro.SelectedIndex = 0;
            dtpInicio.Checked = false;
            dtpFin.Checked = false;
            chkSoloConChecklist.Checked = false;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            btnLimpiarFiltros_Click(sender, e);
            CargarMantenimientos();
        }

        private void btnAbrirChecklist_Click(object sender, EventArgs e)
        {
            if (dgConsultaChecklist.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un mantenimiento");
                return;
            }

            int idMantenimiento = Convert.ToInt32(dgConsultaChecklist.CurrentRow.Cells["idmantenimiento"].Value);

            Checklist frm = new Checklist(idMantenimiento);
            frm.ShowDialog();
        }

        private void btnVerTicket_Click(object sender, EventArgs e)
        {
            if (dgConsultaChecklist.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un mantenimiento");
                return;
            }

            int idMantenimiento = Convert.ToInt32(dgConsultaChecklist.CurrentRow.Cells["idmantenimiento"].Value);

            Ticket frm = new Ticket(idMantenimiento);
            frm.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarMantenimientos();
        }
    }
}
