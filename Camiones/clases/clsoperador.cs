using System;
using System.Collections.Generic;
using System.Text;

namespace Camiones.clases
{
    class Clsoperador
    {
        public static void SubirDoumento(string idcliente, TextBox txtRuta)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos|*.pdf;*.docx;*.xlsx;*.jpg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea guardar este documento?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    string rutaBase = Path.Combine(escritorio, "DocumentosClientes");

                    Directory.CreateDirectory(rutaBase);

                    string carpetaCliente = Path.Combine(rutaBase, idcliente);
                    Directory.CreateDirectory(carpetaCliente);

                    string nombreArchivo = Path.GetFileName(abrir.FileName);

                    string destino = Path.Combine(carpetaCliente, nombreArchivo);

                    File.Copy(abrir.FileName, destino, true);

                    // GUARDAR LA RUTA EN EL TEXTBOX
                    txtRuta.Text = destino;

                    MessageBox.Show("Documento guardado correctamente");
                }
            }
        }
        public static void SubirFoto(string idcliente, PictureBox picFoto, TextBox txtRuta)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string rutaBase = Path.Combine(escritorio, "DocumentosClientes");
                Directory.CreateDirectory(rutaBase);

                string carpetaCliente = Path.Combine(rutaBase, idcliente);
                Directory.CreateDirectory(carpetaCliente);

                string destino = Path.Combine(carpetaCliente, "foto.jpg");

                if (File.Exists(destino))
                {
                    DialogResult r = MessageBox.Show(
                        "Ya existe una foto para este cliente.\n¿Desea reemplazarla?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (r == DialogResult.No)
                        return;
                }

                File.Copy(abrir.FileName, destino, true);

                // Cargar imagen sin bloquear el archivo
                picFoto.Image = Image.FromStream(
                    new MemoryStream(File.ReadAllBytes(destino))
                );

                picFoto.SizeMode = PictureBoxSizeMode.Zoom;

                txtRuta.Text = destino;
            }
        }
    }
    }
