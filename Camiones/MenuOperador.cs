using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones
{
    public partial class MenuOperador : Base
    {
        public MenuOperador()
        {
            InitializeComponent();
        }

        private void MenuOperador_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoOperador_Click(object sender, EventArgs e)
        {
            Operadores op = new Operadores();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        VerOperador vo = new VerOperador();
            vo.Show();
        }

        private void btnNuevaCapacitacion_Click(object sender, EventArgs e)
        {
            NuevaCapacitacion nc = new NuevaCapacitacion();
            nc.Show();
        }

        private void btnNuevoViaje_Click(object sender, EventArgs e)
        {
            NuevoViaje nv = new NuevoViaje();
            nv.Show();
        }
    }
}
