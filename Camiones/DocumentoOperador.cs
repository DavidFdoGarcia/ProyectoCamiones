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
    public partial class DocumentoOperador : Base
    {
        private string idCliente;
        public DocumentoOperador(string id)
        {
            InitializeComponent();
            idCliente = id;

            // Ejemplo: mostrarlo en un TextBox
            txtID.Text = idCliente;
        }

        private void Licencia_Click(object sender, EventArgs e)
        {

        }

        private void DocumentoOperador_Load(object sender, EventArgs e)
        {

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirFoto(txtID.Text, pictureBox1, txtURLimagen);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtDomicilio);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtURLapto);
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtURLlicencia);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtINE);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtURLcurp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtURLanti);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtContrato);
        }
    }
}
