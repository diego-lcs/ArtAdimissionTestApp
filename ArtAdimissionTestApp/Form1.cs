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
        private RandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        public artTestForm()
        {
            InitializeComponent();
        }



        private void GenerateButtonClick(object sender, EventArgs e)
        {
            this.randomNumberTextBox.Text = randomNumberGenerator.GenerateRandomNumber().ToString();
        }
               

        private void TestMetodButtonClick(object sender, EventArgs e)
        {
            string textResult = "";
            int numberOfSamples = 0;
            /* Si el valor en testNumberTextBox es un int, valido, se ejecuta el test del generador
            de numeros aleatorios implementado. El valor de cada opción debería estar entre 1 y 7
            */
            if (int.TryParse(this.testNumberTextBox.Text, out numberOfSamples))
                textResult = randomNumberGenerator.RandonNumberTest(numberOfSamples);
            else
            {
                textResult = "Valor no válido, trate de nuevo";
            }

            
            this.testResultTextBox.Text = textResult;

        }

      
    }
}
