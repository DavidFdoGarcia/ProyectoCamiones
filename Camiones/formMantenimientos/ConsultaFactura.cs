using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones.formMantenimientos
{
    public partial class ConsultaFactura : Base
    {
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private void ConsultaFactura_Load(object sender, EventArgs e)
        {
            // --- COMBO OPERADOR ---
            DataTable dtOperador = Camiones.clases.Operador.ObtenerOperadores();

            // 🔥 Crear fila "Seleccione"
            DataRow filaOperador = dtOperador.NewRow();
            filaOperador["idoperador"] = 0;
            filaOperador["NombreCompleto"] = "--Seleccione un operador--";
            dtOperador.Rows.InsertAt(filaOperador, 0);

            // 👉 Combo nombre
            cmbNombre.DataSource = dtOperador;
            cmbNombre.DisplayMember = "NombreCompleto";
            cmbNombre.ValueMember = "idoperador";
            cmbNombre.SelectedIndex = 0;

        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedValue != null)
            {
                txtID.Text = cmbNombre.SelectedValue.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
