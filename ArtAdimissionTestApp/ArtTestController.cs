using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtAdimissionTestApp
{
    /// <summary>
    /// Clase para gestionar las conexiones entre el UI y RandomNumberGenerator
    /// </summary>
    internal class ArtTestController
    {
        private ArtTestForm artTestForm = null;
        private RandomNumberGenerator randomNumberGenerator = null;
        public ArtTestController(ArtTestForm artTestForm, RandomNumberGenerator randomNumberGenerator) {
            this.artTestForm = artTestForm;
            this.randomNumberGenerator = randomNumberGenerator;
        }


        // Eventos y event handlers para comunicación con ArtTestForm

        public event EventHandler<int> RandomNumberGenerated; // Este Evento envía el número aleatorio obtenido al GUI
        public event EventHandler<string> ReportGenerated; // Este Evento envía el test realizado al al GUI

        public void GenerateRandomNumberHandler(object sender, int calls)
        {
            randomNumberGenerator.Calls = calls;
            int randomNumber = randomNumberGenerator.GenerateRandom1To7();
            RandomNumberGenerated?.Invoke(this, randomNumber);
        }
        public void TestRequestHandle(object sender, List<int> data)
        {
            randomNumberGenerator.Calls = data[0]; // data[0] -> Numero de llamadas
            string report = randomNumberGenerator.RandonNumberTest(data[1]); // data[1] -> numero de trials para el test
            ReportGenerated?.Invoke(this, report);
        }

        /// <summary>
        /// Método para conectar los eventos y sus respectivos Handlers
        /// </summary>
        public void Connect()
        {
            artTestForm.GenerateRandomNumber += GenerateRandomNumberHandler;
            artTestForm.TestRequest += TestRequestHandle;
            RandomNumberGenerated += artTestForm.RandomNumberGeneratedHandle;
            ReportGenerated += artTestForm.ReportGeneratedHandle;
        }
    }
}
