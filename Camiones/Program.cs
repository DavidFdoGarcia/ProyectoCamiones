using QuestPDF.Infrastructure;

namespace Camiones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // LICENCIA DE QUESTPDF
            QuestPDF.Settings.License = LicenseType.Community;

            // Inicializa la configuración de la aplicación Windows Forms
            ApplicationConfiguration.Initialize();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }
}