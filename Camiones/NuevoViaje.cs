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
    public partial class NuevoViaje : Base
    {
        public NuevoViaje()
        {
            InitializeComponent();
        }

        private void NuevoViaje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea actualizar la capacitación?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtID.Text);

                    // 🔥 UPDATE directo (sin SELECT)
                    string query = @"UPDATE operador 
                             SET viajes = ISNULL(viajes, 0) + 1
                             WHERE idoperador = @id";

                    var parametros = new Dictionary<string, object>()
            {
                { "@id", id }
            };

                    int filas = Consultas.Ejecutar(query, parametros);

                    if (filas > 0)
                    {
                        MessageBox.Show("Viajes actualizada correctamente 🔥");

                        // 🔥 Mostrar el nuevo valor en el textbox (opcional pero recomendado)
                        string querySelect = "SELECT Viajes FROM operador WHERE idoperador = @id";

                        DataTable dt = Consultas.Consultar(querySelect, parametros);

                        if (dt.Rows.Count > 0)
                        {
                            txtNumero.Text = dt.Rows[0]["viajes"].ToString();
                        }

                        // 🔥 Subir archivo (UNA sola vez)
                        Clsoperador.SubirViajes(txtID.Text, txtViajes);
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
    }
}
