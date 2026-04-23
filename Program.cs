using System;
using System.Windows.Forms;
using NutricionEnTusManos_1.Views;

namespace NutricionEnTusManos_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Solo esta línea para iniciar el programa:
            Application.Run(new VistaLogin());
        }
    }
}