using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Camiones
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {


            DialogResult r = MessageBox.Show(
                "¿Seguro que deseas salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
    
