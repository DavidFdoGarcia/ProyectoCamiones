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
    public partial class RegistroFlete : Base
    {
        public RegistroFlete()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegistroFlete_Load(object sender, EventArgs e)
        {
            CargarViajes();
            CargarOperadores();
            CargarRegistros();
        }
        private void CargarViajes()
        {
            string query = @"
SELECT 
    idviajef,
    CAST(idviajef AS VARCHAR) + ' - ' + numeroremision + ' - ' + destino AS viaje
FROM viajef
ORDER BY idviajef DESC";

            cmbViaje.DataSource = Consultas.Consultar(query);
            cmbViaje.DisplayMember = "viaje";
            cmbViaje.ValueMember = "idviajef";
            cmbViaje.SelectedIndex = -1;
        }
        private void CargarOperadores()
        {
            string query = @"
SELECT
    idoperador,
    nombreoperador + ' ' + apellidopoperador + ' ' + apellidomoperador AS operador
FROM operador
WHERE activo = 1";

            cmbOperador.DataSource = Consultas.Consultar(query);
            cmbOperador.DisplayMember = "operador";
            cmbOperador.ValueMember = "idoperador";
            cmbOperador.SelectedIndex = -1;
        }
        private void CargarRegistros()
        {
            string query = @"
SELECT 
    r.idregistroviaje,
    vf.numeroremision,
    vf.destino,
    o.nombreoperador + ' ' + o.apellidomoperador AS operador,
    r.entradapatio,
    r.salidapatio,
    r.inicioviaje,
    r.terminoviaje,
    r.checklistext,
    r.checklistint,
    r.observaciones
FROM registrov r
INNER JOIN viajef vf ON r.idviajef = vf.idviajef
INNER JOIN operador o ON r.idoperador = o.idoperador
ORDER BY r.idregistroviaje DESC";

            dgvRegistros.DataSource = Consultas.Consultar(query);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbViaje.SelectedIndex == -1 || cmbOperador.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione viaje y operador");
                    return;
                }

                string query = @"
INSERT INTO registrov
(idoperador, idviajef, entradapatio, salidapatio, inicioviaje, terminoviaje, checklistext, checklistint, observaciones)
VALUES
(@idoperador, @idviajef, @entrada, @salida, @inicio, @termino, @ext, @int, @obs)";

                var parametros = new Dictionary<string, object>()
        {
            { "@idoperador", Convert.ToInt32(cmbOperador.SelectedValue) },
            { "@idviajef", Convert.ToInt32(cmbViaje.SelectedValue) },
            { "@entrada", dtEntradaPatio.Value },
            { "@salida", dtSalidaPatio.Value },
            { "@inicio", dtInicioViaje.Value },
            { "@termino", dtTerminoViaje.Value },
            { "@ext", chkExt.Checked },
            { "@int", chkInt.Checked },
            { "@obs", txtObservaciones.Text }
        };

                int filas = Consultas.Ejecutar(query, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("Registro guardado");
                    Limpiar();
                    CargarRegistros();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
            private void Limpiar()
        {
            cmbViaje.SelectedIndex = -1;
            cmbOperador.SelectedIndex = -1;
            txtObservaciones.Clear();

            chkExt.Checked = false;
            chkInt.Checked = false;
        }
    }

    }
