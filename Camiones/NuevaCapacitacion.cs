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

                    // 🔥 1. CONSULTAR valor actual
                    string querySelect = "SELECT capacitaciones FROM operador WHERE idoperador = @id";

                    var parametrosSelect = new Dictionary<string, object>()
            {
                { "@id", id }
            };

                    DataTable dt = Consultas.Consultar(querySelect, parametrosSelect);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró el operador");
                        return;
                    }

                    int valorActual = 0;

                    if (dt.Rows[0]["capacitaciones"] != DBNull.Value)
                        valorActual = Convert.ToInt32(dt.Rows[0]["capacitaciones"]);

                    // 🔥 2. SUMAR +1
                    int nuevoValor = valorActual + 1;

                    // 🔥 3. MOSTRAR en textbox
                    txtCap.Text = nuevoValor.ToString();

                    // 🔥 4. ACTUALIZAR BD
                    string queryUpdate = @"UPDATE operador 
                                   SET capacitaciones = @capacitacion
                                   WHERE idoperador = @id";

                    var parametrosUpdate = new Dictionary<string, object>()
            {
                { "@capacitacion", nuevoValor },
                { "@id", id }
            };

                    int filas = Consultas.Ejecutar(queryUpdate, parametrosUpdate);

                    if (filas > 0)
                    {
                        MessageBox.Show("Capacitación actualizada correctamente 🔥");

                        // 🔥 5. GUARDAR ARCHIVOS
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
