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
            if (MessageBox.Show("¿Desea actualizar la capacitación?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtID.Text);

                    // 🔥 UPDATE directo (sin SELECT)
                    string query = @"UPDATE operador 
                             SET capacitaciones = ISNULL(capacitaciones, 0) + 1
                             WHERE idoperador = @id";

                    var parametros = new Dictionary<string, object>()
            {
                { "@id", id }
            };

                    int filas = Consultas.Ejecutar(query, parametros);

                    if (filas > 0)
                    {
                        MessageBox.Show("Capacitación actualizada correctamente 🔥");

                        // 🔥 Mostrar el nuevo valor en el textbox (opcional pero recomendado)
                        string querySelect = "SELECT capacitaciones FROM operador WHERE idoperador = @id";

                        DataTable dt = Consultas.Consultar(querySelect, parametros);

                        if (dt.Rows.Count > 0)
                        {
                            txtNumero.Text = dt.Rows[0]["capacitaciones"].ToString();
                        }

                        // 🔥 Subir archivo (UNA sola vez)
                        Clsoperador.SubirCapacitacion(txtID.Text, txtCap);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void NuevaCapacitacion_Load(object sender, EventArgs e)
        {

        }
    }
}
