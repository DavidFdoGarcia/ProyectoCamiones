using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones.formMantenimientos
{
    public partial class MenuManteenimiento : Base
    {
        public MenuManteenimiento()
        {
            InitializeComponent();
        }

        private void MenuManteenimiento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantenimientoCamiones MC = new MantenimientoCamiones();
            MC.Show();
        }
    }
}
