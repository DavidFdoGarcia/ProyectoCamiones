using Camiones.clases;
using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;



namespace Camiones
{
    public partial class Operadores : Base
    {
        public Operadores()
        {
            InitializeComponent();
        }

        private void Operadores_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            txtID.TabStop = false;

            TXTcurp.CharacterCasing = CharacterCasing.Upper;

            // Si quieres iniciar deshabilitado el textbox de licencia
            txtLicencia.Enabled = false;
        }

        private bool ValidarFormulario()
        {
            bool valido = true;
            errorProvider1.Clear();

            // Nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }
            else if (txtNombre.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(txtNombre, "El nombre es demasiado corto.");
                valido = false;
            }
            else if (!SoloLetras(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre solo debe contener letras y espacios.");
                valido = false;
            }

            // Apellido paterno
            if (string.IsNullOrWhiteSpace(txtPaterno.Text))
            {
                errorProvider1.SetError(txtPaterno, "Ingrese el apellido paterno.");
                valido = false;
            }
            else if (!SoloLetras(txtPaterno.Text))
            {
                errorProvider1.SetError(txtPaterno, "Solo letras y espacios.");
                valido = false;
            }

            // Apellido materno
            if (string.IsNullOrWhiteSpace(txtMaterno.Text))
            {
                errorProvider1.SetError(txtMaterno, "Ingrese el apellido materno.");
                valido = false;
            }
            else if (!SoloLetras(txtMaterno.Text))
            {
                errorProvider1.SetError(txtMaterno, "Solo letras y espacios.");
                valido = false;
            }

            // Licencia: debe elegir SI o NO
            if (!rbLicenciaSI.Checked && !rbdlicenciNO.Checked)
            {
                errorProvider1.SetError(gbLicencia, "Seleccione si tiene licencia.");
                valido = false;
            }
            else if (rbLicenciaSI.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtLicencia.Text))
                {
                    errorProvider1.SetError(txtLicencia, "Ingrese el número de licencia.");
                    valido = false;
                }
                else if (txtLicencia.Text.Trim().Length < 5)
                {
                    errorProvider1.SetError(txtLicencia, "Número de licencia inválido.");
                    valido = false;
                }
            }

            // Apto médico
            if (!rbAptoSi.Checked && !rbdAptoNO.Checked)
            {
                errorProvider1.SetError(gbAptoMedico, "Seleccione una opción.");
                valido = false;
            }

            // Domicilio
            if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                errorProvider1.SetError(txtDomicilio, "Ingrese el domicilio.");
                valido = false;
            }
            else if (txtDomicilio.Text.Trim().Length < 10)
            {
                errorProvider1.SetError(txtDomicilio, "El domicilio es muy corto.");
                valido = false;
            }

            // INE
            if (string.IsNullOrWhiteSpace(txtINE.Text))
            {
                errorProvider1.SetError(txtINE, "Ingrese el dato de INE.");
                valido = false;
            }

            // CURP
            if (string.IsNullOrWhiteSpace(TXTcurp.Text))
            {
                errorProvider1.SetError(TXTcurp, "Ingrese la CURP.");
                valido = false;
            }
            else if (!ValidarCURP(TXTcurp.Text.Trim()))
            {
                errorProvider1.SetError(TXTcurp, "La CURP no tiene un formato válido.");
                valido = false;
            }

            // Antidoping
            if (!rbAntiSI.Checked && !rbAntiNO.Checked)
            {
                errorProvider1.SetError(gbAntidoping, "Seleccione una opción.");
                valido = false;
            }

            // Contrato laboral
            if (!rbContratoSI.Checked && !rbContratoNO.Checked)
            {
                errorProvider1.SetError(gbContrato, "Seleccione una opción.");
                valido = false;
            }

            return valido;
        }
        private bool SoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }
        private bool ValidarCURP(string curp)
        {
            curp = curp.Trim().ToUpper();

            string patron = @"^[A-Z][AEIOU][A-Z]{2}\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])[HM](AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d]\d$";

            return Regex.IsMatch(curp, patron);
        }
        private string LimpiarTexto(string texto)  //limpiar espacios extras
        {
            return System.Text.RegularExpressions.Regex.Replace(texto.Trim(), @"\s+", " ");
        }
        private void btnLicencia_Click(object sender, EventArgs e)
        {

        }


        private void btnApto_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtDomicilio);
        }

        private void btnINE_Click(object sender, EventArgs e)
        {
            Clsoperador.SubirDoumento(txtID.Text, txtINE);
        }

        private void btnCURP_Click(object sender, EventArgs e)
        {

        }

        private void btnAnti_Click(object sender, EventArgs e)
        {
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {

        }

        private void btnCapacitaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            // Clsoperador.SubirDoumento(txtID.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbAntiSI_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void rdbContratoSI_CheckedChanged(object sender, EventArgs e)
        {
            txtLicencia.Enabled = rbLicenciaSI.Checked;

            if (!rbLicenciaSI.Checked)
                txtLicencia.Clear();
        }





        private void rbLicenciaSI_CheckedChanged(object sender, EventArgs e)
        {
            txtLicencia.Enabled = rbLicenciaSI.Checked;

            if (!rbLicenciaSI.Checked)
                txtLicencia.Clear();
        }

        private void rbdAptoSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {

        }




        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }




        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)  //boton select
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                MessageBox.Show("Corrija los campos marcados.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = @"
        INSERT INTO dbo.operador 
        (nombreoperador,apellidomoperador,apellidopoperador,licencia,aptomedico,comprobantedomicilio,ine,curp,antidoping,contratolaboral) 
        VALUES 
        (@nombreoperador,@apellidomoperador,@apellidopoperador,@licencia,@aptomedico,@comprobantedomicilio,@ine,@curp,@antidoping,@contratolaboral);

        SELECT SCOPE_IDENTITY();
        ";

                bool apto = rbAptoSi.Checked;
                bool anti = rbAntiSI.Checked;
                bool contrato = rbContratoSI.Checked;

                var parametros = new Dictionary<string, object>()
        {
            { "@nombreoperador", txtNombre.Text },
            { "@apellidomoperador", txtMaterno.Text },
            { "@apellidopoperador", txtPaterno.Text },
            { "@licencia", txtLicencia.Text },
            { "@aptomedico", apto },
            { "@comprobantedomicilio", txtDomicilio.Text },
            { "@ine", txtINE.Text },
            { "@curp", TXTcurp.Text },
            { "@antidoping", anti },
            { "@contratolaboral", contrato },

        };

                // 🔥 AQUÍ obtienes el ID
                object resultado = Consultas.EjecutarEscalar(query, parametros);

                int idGenerado = Convert.ToInt32(resultado);

                // 👉 LO PONES EN EL TEXTBOX
                txtID.Text = idGenerado.ToString();


                // ✅ MENSAJE DE CONFIRMACIÓN
                MessageBox.Show("Operador insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtID.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }





        private void btnContrato_Click_1(object sender, EventArgs e)
        {

        }

        private void rbContratoSI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string id = txtID.Text; // o de donde lo tengas

            DocumentoOperador frm = new DocumentoOperador(id);
            frm.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }//Solo letras 

        private void txtPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtINE_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtINE_KeyPress(object sender, KeyPressEventArgs e) //Solo letras y numeros
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtLicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void TXTcurp_TextChanged(object sender, EventArgs e) //curp en mayusdculas
        {
            int posicion = TXTcurp.SelectionStart;
            TXTcurp.Text = TXTcurp.Text.ToUpper();
            TXTcurp.SelectionStart = posicion;
        }
    }
}




    

