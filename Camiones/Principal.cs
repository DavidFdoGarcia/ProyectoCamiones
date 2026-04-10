using Camiones.destinatarios;
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

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            AltaDestinatarios d = new AltaDestinatarios();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViajesFletes vf = new ViajesFletes();
            vf.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroFlete rf = new RegistroFlete();
            rf.Show();
        }

     

        private void btnConsultaChecklist_Click(object sender, EventArgs e)
        {
            ConsultaCheck cc = new ConsultaCheck();
            cc.Show();

        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            TemaCapacitacion tc = new TemaCapacitacion();
            tc.Show();
        }

        private void btnDetalleCamion_Click(object sender, EventArgs e)
        {
            CamionDetalle cd = new CamionDetalle();
            cd.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CamionAsignacion ca = new CamionAsignacion();
            ca.Show();
        }
    }
}
