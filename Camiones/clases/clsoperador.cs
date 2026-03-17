using System;
using System.Collections.Generic;
using System.Text;

namespace Camiones.clases
{
    class Clsoperador
    {
        public static void SubirDoumento(string idcliente)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos|*.pdf;*.docx;*.xlsx;*.jpg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                // PREGUNTAR SI QUIERE GUARDAR EL DOCUMENTO
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea guardar este documento?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    string rutaBase = Path.Combine(escritorio, "DocumentosClientes");

                    // crear carpeta principal
                    Directory.CreateDirectory(rutaBase);

                    // crear carpeta del cliente
                    string carpetaCliente = Path.Combine(rutaBase, idcliente);
                    Directory.CreateDirectory(carpetaCliente);

                    // nombre del archivo
                    string nombreArchivo = Path.GetFileName(abrir.FileName);

                    // destino final
                    string destino = Path.Combine(carpetaCliente, nombreArchivo);

                    // copiar archivo
                    File.Copy(abrir.FileName, destino, true);

                    MessageBox.Show("Documento guardado correctamente");
                }
            }

        }
        public static void SubirFoto2(string idcliente, PictureBox picFoto)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Imagenes|*.jpg;*.png;*.jpeg";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                // PREGUNTAR SI QUIERE GUARDAR EL DOCUMENTO
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea guardar este documento?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    string rutaBase = Path.Combine(escritorio, "DocumentosClientes");

                    // crear carpeta principal
                    Directory.CreateDirectory(rutaBase);

                    // crear carpeta del cliente
                    string carpetaCliente = Path.Combine(rutaBase, idcliente);
                    Directory.CreateDirectory(carpetaCliente);

                    // nombre fijo de la foto
                    string destino = Path.Combine(carpetaCliente, "foto.jpg");

                    // copiar foto a la carpeta del cliente
                    File.Copy(abrir.FileName, destino, true);

                    // mostrar la foto en el PictureBox
                    picFoto.Image = Image.FromFile(destino);
                }
            }
        }
        public static void SubirFoto(string idcliente, PictureBox picFoto)  //Reemplazar foto
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

                // SI YA EXISTE FOTO
                if (File.Exists(destino))
                {
                    DialogResult r = MessageBox.Show(
                        "Ya existe una foto para este cliente.\n¿Desea reemplazarla?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (r == DialogResult.No)
                    {
                        return;
                    }
                }

                // liberar imagen anterior
                if (picFoto.Image != null)
                {
                    picFoto.Image.Dispose();
                }

                File.Copy(abrir.FileName, destino, true);

                picFoto.Image = Image.FromFile(destino);
            }
        }
    }
}
