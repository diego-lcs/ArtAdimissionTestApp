using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtAdimissionTestApp
{
    public partial class artTestForm : Form
    {   
        public artTestForm()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int GenerateRandom1To5()
        {           
            return random.Next(1, 6);
        }

        int GenerateRandom1To7()
        {
            int numberOfCalls = (int)callNumberNumericUpDown.Value;
            int acumNumber = 0;
            for(int i = 0; i < numberOfCalls; i++)
                acumNumber += GenerateRandom1To5();            
            return (acumNumber % 7) + 1;
        }

        public string RandonNumberTest(int test = 100)
        {
            Dictionary<int, int> testNumbers = new Dictionary<int, int> {
                { 0,0}, {1,0}, {2,0}, {3,0}, {4,0}, {5,0}, {6,0}, {7,0}
            }; // Diccionario que almacena el número de sucesos de cada número
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

        private void GenerateButtonClick(object sender, EventArgs e)
        {
            this.randomNumberTextBox.Text = GenerateRandom1To7().ToString();
        }               

        private void TestMetodButtonClick(object sender, EventArgs e)
        {
            string textResult = "";
            int numberOfSamples = 0;
            /* Si el valor en testNumberTextBox es un int, valido, se ejecuta el test del generador
            de numeros aleatorios implementado. El valor de cada opción debería estar entre 1 y 7
            */
            if (int.TryParse(this.testNumberTextBox.Text, out numberOfSamples))
                textResult = RandonNumberTest(numberOfSamples);
            else
            {
                textResult = "Valor no válido, trate de nuevo";
            }

            
            this.testResultTextBox.Text = textResult;

        }

      
    }
}
