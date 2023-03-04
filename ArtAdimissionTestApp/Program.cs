using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtAdimissionTestApp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ArtTestForm artTestForm = new ArtTestForm();
            RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
            ArtTestController artTestController = new ArtTestController(artTestForm, randomNumberGenerator);
            artTestController.Connect();
            Application.Run(artTestForm);    
            
        }     

    }
}
