using System;
using System.Collections.Generic;
using System.Data;
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


        public static void SubirCapacitacion(string idcliente, TextBox txtRuta)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos|*.pdf;*.docx;*.xlsx;*.jpg";
            abrir.Multiselect = true; // 🔥 permite varios archivos

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Desea guardar estos documentos?",
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

                    // 🔥 NUEVA SUBCARPETA
                    string carpetaCap = Path.Combine(carpetaCliente, "Capacitaciones");
                    Directory.CreateDirectory(carpetaCap);

                    StringBuilder rutas = new StringBuilder();

                    foreach (string archivo in abrir.FileNames)
                    {
                        string nombreArchivo = Path.GetFileName(archivo);
                        string destino = Path.Combine(carpetaCap, nombreArchivo);

                        File.Copy(archivo, destino, true);

                        rutas.AppendLine(destino);
                    }

                    // Guardas todas las rutas (opcional)
                    txtRuta.Text = rutas.ToString();

                    MessageBox.Show("Capacitaciones guardadas correctamente");
                }
            }
        }
        public static void GuardarCapacitacion(string idCliente, string rutaArchivoOrigen)
        { /*
            try
            {
                // Escritorio
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                // Carpeta base
                string rutaBase = Path.Combine(escritorio, "DocumentosClientes");

                // Carpeta del cliente
                string carpetaCliente = Path.Combine(rutaBase, idCliente);

                // Carpeta de capacitaciones
                string carpetaCapacitaciones = Path.Combine(carpetaCliente, "Capacitaciones");

                // Crear carpetas si no existen
                Directory.CreateDirectory(carpetaCapacitaciones);

                // Nombre original
                string nombreArchivo = Path.GetFileNameWithoutExtension(rutaArchivoOrigen);
                string extension = Path.GetExtension(rutaArchivoOrigen);

                // Nombre único (evita duplicados)
                string nuevoNombre = $"{nombreArchivo}_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";

                // Ruta final
                string destino = Path.Combine(carpetaCapacitaciones, nuevoNombre);

                // Copiar archivo
                File.Copy(rutaArchivoOrigen, destino, true);

                MessageBox.Show("Capacitación guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la capacitación: " + ex.Message);
            } */


        }

    }
    }
