using Camiones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;
using Camiones.formMantenimientos;

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
            Mantenimiento m = new Mantenimiento();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaFactura CF = new ConsultaFactura();
            CF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
