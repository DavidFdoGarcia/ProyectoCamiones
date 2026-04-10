using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Camiones.clases
{
    public static class Validaciones
    {
        public static bool Requerido(TextBox txt, ErrorProvider error, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                error.SetError(txt, mensaje);
                return false;
            }

            error.SetError(txt, "");
            return true;
        }

        public static bool LongitudMinima(TextBox txt, int minimo, ErrorProvider error, string mensaje)
        {
            if (txt.Text.Trim().Length < minimo)
            {
                error.SetError(txt, mensaje);
                return false;
            }

            error.SetError(txt, "");
            return true;
        }

        public static bool LongitudMaxima(TextBox txt, int maximo, ErrorProvider error, string mensaje)
        {
            if (txt.Text.Trim().Length > maximo)
            {
                error.SetError(txt, mensaje);
                return false;
            }

            error.SetError(txt, "");
            return true;
        }

        public static bool SoloLetras(TextBox txt, ErrorProvider error, string mensaje)
        {
            foreach (char c in txt.Text.Trim())
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    error.SetError(txt, mensaje);
                    return false;
                }
            }

            error.SetError(txt, "");
            return true;
        }

        public static bool SoloLetrasYNumeros(TextBox txt, ErrorProvider error, string mensaje)
        {
            foreach (char c in txt.Text.Trim())
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                {
                    error.SetError(txt, mensaje);
                    return false;
                }
            }

            error.SetError(txt, "");
            return true;
        }

        public static bool ValidarCURP(TextBox txt, ErrorProvider error)
        {
            string curp = txt.Text.Trim().ToUpper();

            string patron = @"^[A-Z][AEIOU][A-Z]{2}\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])[HM](AS|BC|BS|CC|CL|CM|CS|CH|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[A-Z\d]\d$";

            if (!Regex.IsMatch(curp, patron))
            {
                error.SetError(txt, "La CURP no tiene un formato válido.");
                return false;
            }

            error.SetError(txt, "");
            return true;
        }

        public static bool GrupoSeleccionado(GroupBox gb, RadioButton rbSi, RadioButton rbNo, ErrorProvider error, string mensaje)
        {
            if (!rbSi.Checked && !rbNo.Checked)
            {
                error.SetError(gb, mensaje);
                return false;
            }

            error.SetError(gb, "");
            return true;
        }

        public static string LimpiarEspacios(string texto)
        {
            return Regex.Replace(texto.Trim(), @"\s+", " ");
        }

        public static void SoloLetrasKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public static void SoloLetrasNumerosKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public static void ConvertirMayusculas(TextBox txt)
        {
            int posicion = txt.SelectionStart;
            txt.Text = txt.Text.ToUpper();
            txt.SelectionStart = posicion;
        }

    }
}
