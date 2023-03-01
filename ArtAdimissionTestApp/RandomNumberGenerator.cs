using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtAdimissionTestApp
{
    /// <summary>
    /// Clase diseñada para la generación de números aleatorios de 1 a 7, utilizando método que genera números aleatorios de 1 a 5
    /// </summary>
    internal class RandomNumberGenerator
    {
        // miembros privados
        private int[] randomNumber = { 1, 2, 3, 4, 5, 6, 7 }; // arreglo con las posibles opciones
        private Random numberGenerator = new Random(); // objeto random para la generacion de números aleatorios
        private int AcumulatedNumber { get; set; } = DateTime.Now.Second;
        /// <summary>
        /// Método publico para la genreación de números aleatorios entre 1 y 7
        /// Parámetros de entrada: Sin parámetros
        /// Retorna: int
        /// </summary>
        public int GenerateRandomNumber()
        {
            int oneToFiveNumber = numberGenerator.Next(1, 6); // Se genera un numero aleatorio de 1 a 5
            
            // Se atiende la posible excepción de overflow de variable tipo int
            try
            {
                AcumulatedNumber += oneToFiveNumber; //Se suma el valor generado entre 1 y 5  al numero acumulado
            }
            catch (OverflowException)
            {
                AcumulatedNumber = DateTime.Now.Second; // Se reinicia AcumulatedNumber con el numero de segundos de la hora actual

            }

            return randomNumber[AcumulatedNumber % 7]; // se obtiene un numero aleatorio entre 1 y 7
        }
        /// <summary>
        /// Método para probar el generador de números aleatorios
        /// Se prueba el método "test" veces y entrega un sting con el reporte de la ocurrencia de cada número
        /// </summary>
        /// <param name="test"></param>
        /// <returns></returns>
        public string RandonNumberTest(int test = 100)
        {
            Dictionary<int, int> testNumbers = new Dictionary<int, int> {
                {1,0}, {2,0}, {3,0}, {4,0}, {5,0}, {6,0}, {7,0}
            };
            for (int i = 0; i < test; i++)
            {
                testNumbers[GenerateRandomNumber()] += 1;
            }
            string result = String.Format($"Prueba generador de números Aleatorios.\nMuestras:{test}\n");
            result += "-----------------------------------------------------------------------------\n";
            foreach (int i in testNumbers.Keys)
            {
                result += String.Format($"Número {i}, repeticiones: {testNumbers[i]}, porcentaje: {100.0 * testNumbers[i] / test:0.00}%.\n");
            }
            return result;
        }
    }
}
