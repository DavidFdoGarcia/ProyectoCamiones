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
    public partial class ViajesFletes : Base
    {
        public ViajesFletes()
        {
            InitializeComponent();
        }

        private void ViajesFletes_Load(object sender, EventArgs e)
        {
            CargarCamiones();
            CargarDestinatarios();
            CargarViajes();
        }
        private void CargarCamiones()
        {
            string query = @"
SELECT 
    cd.idcamiondetalle,
    cd.placas + ' - ' + c.tipoCamion AS camion
FROM camion_detalle cd
INNER JOIN camion c ON cd.idcamion = c.idcamion
WHERE cd.activo = 1";

            cmbCamion.DataSource = Consultas.Consultar(query);
            cmbCamion.DisplayMember = "camion";
            cmbCamion.ValueMember = "idcamiondetalle";
            cmbCamion.SelectedIndex = -1;
        }
        private void CargarDestinatarios()
        {
            string query = @"
SELECT 
    iddestinatario,
    nombre + ' - ' + planta AS destinatario
FROM altadestinatario
WHERE activo = 1";

            cmbDestinatario.DataSource = Consultas.Consultar(query);
            cmbDestinatario.DisplayMember = "destinatario";
            cmbDestinatario.ValueMember = "iddestinatario";
            cmbDestinatario.SelectedIndex = -1;
        }
        private bool ValidarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (cmbCamion.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbCamion, "Seleccione un camión.");
                valido = false;
            }

            if (cmbDestinatario.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDestinatario, "Seleccione un destinatario.");
                valido = false;
            }

            if (dtFecha.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dtFecha, "La fecha no puede ser mayor a hoy.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroRemision.Text))
            {
                errorProvider1.SetError(txtNumeroRemision, "Ingrese el número de remisión.");
                valido = false;
            }
            else if (txtNumeroRemision.Text.Trim().Length > 20)
            {
                errorProvider1.SetError(txtNumeroRemision, "Máximo 20 caracteres.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtOrigen.Text))
            {
                errorProvider1.SetError(txtOrigen, "Ingrese el origen.");
                valido = false;
            }
            else if (txtOrigen.Text.Trim().Length > 100)
            {
                errorProvider1.SetError(txtOrigen, "Máximo 100 caracteres.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                errorProvider1.SetError(txtDestino, "Ingrese el destino.");
                valido = false;
            }
            else if (txtDestino.Text.Trim().Length > 100)
            {
                errorProvider1.SetError(txtDestino, "Máximo 100 caracteres.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCartaPorte.Text))
            {
                errorProvider1.SetError(txtCartaPorte, "Ingrese la carta porte.");
                valido = false;
            }
            else if (txtCartaPorte.Text.Trim().Length > 50)
            {
                errorProvider1.SetError(txtCartaPorte, "Máximo 50 caracteres.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtRegistroViaje.Text))
            {
                errorProvider1.SetError(txtRegistroViaje, "Ingrese el registro de viaje.");
                valido = false;
            }
            else if (txtRegistroViaje.Text.Trim().Length > 50)
            {
                errorProvider1.SetError(txtRegistroViaje, "Máximo 50 caracteres.");
                valido = false;
            }

            return valido;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCamion.SelectedIndex == -1 || cmbDestinatario.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione camión y destinatario");
                    return;
                }

                string query = @"
INSERT INTO dbo.viajef
(idcamiondetalle, iddestinatario, fecha, numeroremision, origen, destino, numeracartaporte, registroviaje)
VALUES
(@idcamiondetalle, @iddestinatario, @fecha, @numeroremision, @origen, @destino, @numeracartaporte, @registroviaje)";

                var parametros = new Dictionary<string, object>()
                {
                    { "@idcamiondetalle", Convert.ToInt32(cmbCamion.SelectedValue) },
                    { "@iddestinatario", Convert.ToInt32(cmbDestinatario.SelectedValue) },
                    { "@fecha", Convert.ToDateTime(dtFecha.Text) },
                    { "@numeroremision", txtNumeroRemision.Text },
                    { "@origen", txtOrigen.Text },
                    { "@destino", txtDestino.Text },
                    { "@numeracartaporte", txtCartaPorte.Text },
                    { "@registroviaje", txtRegistroViaje.Text }
                };

                int filas = Consultas.Ejecutar(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Viaje guardado correctamente");
                    Limpiar();
                    CargarViajes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarViajes()
        {
            string query = @"
SELECT 
    vf.idviajef,
    cd.placas + ' - ' + c.tipoCamion AS camion,
    d.nombre + ' - ' + d.planta AS destinatario,
    vf.fecha,
    vf.numeroremision,
    vf.origen,
    vf.destino,
    vf.numeracartaporte,
    vf.registroviaje
FROM viajef vf
INNER JOIN camion_detalle cd ON vf.idcamiondetalle = cd.idcamiondetalle
INNER JOIN camion c ON cd.idcamion = c.idcamion
INNER JOIN altadestinatario d ON vf.iddestinatario = d.iddestinatario
ORDER BY vf.idviajef DESC";

            dgvViajes.DataSource = Consultas.Consultar(query);
        }

        private void Limpiar()
        {
            cmbCamion.SelectedIndex = -1;
            cmbDestinatario.SelectedIndex = -1;

            
            txtNumeroRemision.Clear();
            txtOrigen.Clear();
            txtDestino.Clear();
            txtCartaPorte.Clear();
            txtRegistroViaje.Clear();
        }
    }
}
