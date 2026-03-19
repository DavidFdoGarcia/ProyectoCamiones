using Camiones.formMantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones
{
    public partial class Principal : Base
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            MenuOperador mo = new MenuOperador();
            mo.Show();
        }

        private void btnAltaCamiones_Click(object sender, EventArgs e)
        {
            AltaCamiones AC = new AltaCamiones();
            AC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuManteenimiento MM = new MenuManteenimiento();
            MM.Show();
        }
    }
}
