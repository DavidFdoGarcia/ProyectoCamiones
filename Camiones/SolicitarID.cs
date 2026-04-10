using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones
{
    public partial class SolicitarID : Base
    {
        public SolicitarID()
        {
            InitializeComponent();
        }

        private void SolicitarID_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text; // o de donde lo tengas

            DocumentoOperador frm = new DocumentoOperador(id);
            frm.Show();
        }
    }
}
