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

        private void MantenimientoCamiones_Load(object sender, EventArgs e)
        {
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

                int idGenerado = Convert.ToInt32(resultado);

              //  txtIDMantenimiento.Text = idGenerado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           // txtIDMantenimiento.Enabled = false;
        }
    }
    
}
