using Camiones.clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Camiones
{
    public partial class AltaCamiones : Base
    {
        public AltaCamiones()
        {
            InitializeComponent();

        }

        private void AltaCamiones_Load(object sender, EventArgs e)
        {
            dgConsulta.AutoGenerateColumns = true;
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }
        private void txtTipo_KeyDown(object sender, KeyEventArgs e) //Evento que guarda al presionar enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInsertar_Click(sender, e);
                txtCamion.Clear();
                txtCamion.Focus();
                dgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }


        private void dgConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgConsulta.CurrentRow.Cells["idcamion"].Value.ToString();
                txtCamion.Text = dgConsulta.CurrentRow.Cells["tipocamion"].Value.ToString();
              //  btnBaja.Visible = true;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT * 
                         FROM dbo.camion
                         WHERE tipocamion LIKE @buscar";

                var parametros = new Dictionary<string, object>()
        {
            { "@buscar", "%" + txtBuscar.Text + "%" }
        };

                DataTable dt = Consultas.Consultar(query, parametros);

                dgConsulta.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM dbo.camion";

                DataTable dt = Consultas.Consultar(query);




                dgConsulta.DataSource = null;
                dgConsulta.DataSource = dt;
                dgConsulta.Visible = true;
                dgConsulta.BringToFront();

                dgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// Hace lla consulta a la tabla camiones

        private void btnInserta_Click(object sender, EventArgs e) //Inserta un nuevo registro a la tabla camiones
        {
            Evacio.Clear();

            if (txtCamion.Text.Trim() == "")
            {
                Evacio.SetError(txtCamion, "Ingrese el camión a agregar");
                txtCamion.Focus();
                return;
            }

            if (MessageBox.Show("Desea Insertar un nuevo Camión?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string query = "INSERT INTO dbo.Camion (tipocamion) VALUES (@tipo)";

                    var parametros = new Dictionary<string, object>()
        {
            { "@tipo", txtCamion.Text }
        };

                    Consultas.Ejecutar(query, parametros);

                    txtCamion.Text = "";

                    dgConsulta.DataSource = Consultas.Consultar("SELECT * FROM dbo.camion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnActualiza_Click(object sender, EventArgs e) //Actualiza el registro seleccionado en la tabla camiones
        {
            if (txtCamion.Text.Trim() == ""
 )
            {
                Evacio.SetError(txtCamion, "Ingrese el camión a actualizar");
                txtCamion.Focus();
                return;
            }
            if (MessageBox.Show("Decea Actualizar el camión seleccionado? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    string query = @"UPDATE dbo.camion 
                         SET tipocamion = @camion
                         WHERE idcamion = @id";

                    var parametros = new Dictionary<string, object>()
        {
            { "@camion", txtCamion.Text },
            { "@id", txtId.Text }
        };

                    int filas = Consultas.Ejecutar(query, parametros);

                    if (filas > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente");

                        dgConsulta.DataSource = Consultas.Consultar("SELECT * FROM dbo.Camion");

                        txtCamion.Text = "";
                        txtId.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtCamion.Text = "";
                dgConsulta.DataSource = Consultas.Consultar("SELECT * FROM dbo.camion");
            }

        }

        private void button1_Click(object sender, EventArgs e) //Elimina el registro seleccionado en la tabla camiones 
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione un registro para eliminar");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar el camión seleccionado?",
                "Aviso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM dbo.camion WHERE idcamion = @id";

                    var parametros = new Dictionary<string, object>()
            {
                { "@id", txtId.Text }
            };

                    int filas = Consultas.Ejecutar(query, parametros);

                    if (filas > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente");

                        dgConsulta.DataSource = Consultas.Consultar("SELECT * FROM dbo.camion");

                        txtId.Text = "";
                        txtCamion.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
