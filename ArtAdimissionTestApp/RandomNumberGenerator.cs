using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private Random numberGenerator = new Random(); // objeto random para la generacion de números aleatorios

        // miembros publicos
        public int Calls { get; set; } = 7;// Propiedad con la información del número de llamadas de  GenerateRandom1To7 a   GenerateRandom1To5

        // métodos publicos
        private int GenerateRandom1To5()
        {
            return numberGenerator.Next(1, 6);
        }

        /// <summary>
        /// Funcion que genera un numero aleatorio entre 1-7 haciendo uso de función que genera número aleatorio uniforme entre 1 y 5 (GenerateRandom1To5())
        /// </summary>
        /// <returns>Un valor entero aleatorio entre 1 y 7</returns>
        public int GenerateRandom1To7()
        {
            int acumNumber = 0;
            for (int i = 0; i < Calls; i++)
                acumNumber += GenerateRandom1To5();
            return (acumNumber % 7) + 1;
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
            }; // Diccionario que almaceana el número de sucesos de cada número
            for (int i = 0; i < test; i++)
            {
                testNumbers[GenerateRandom1To7()] += 1; // se incrementa en uno cada suceso
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
