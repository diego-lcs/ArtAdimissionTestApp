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
    public partial class ArtTestForm : Form
    {   
        public ArtTestForm()
        {
            InitializeComponent();
        }

        public void GenerateButtonClick(object sender, EventArgs e)
        {
            
            GenerateRandomNumber?.Invoke(this, (int)callNumberNumericUpDown.Value);
        }
        private void TestMetodButtonClick(object sender, EventArgs e)
        {
            int numberOfSamples = 0;
            if (int.TryParse(this.testNumberTextBox.Text, out numberOfSamples))
            {
                List <int> data = new List<int>();
                data.Add((int)this.callNumberNumericUpDown.Value); // Se inserta el numero de llamadas al Gen1To5
                data.Add(numberOfSamples); // Se inserta el número de trials para probar el metodo 
                TestRequest?.Invoke(this, data);
            }
                
            else
            {
                this.testResultTextBox.Text = "Valor no válido, trate de nuevo";
            }

        }


        // Eventos y  Event Hnadlers para comunicación con RandomNumberGenerator (a traves de ArtTestController)

        public event EventHandler<int> GenerateRandomNumber;
        public event EventHandler<List<int>> TestRequest;

        public void RandomNumberGeneratedHandle(object sender, int randomNumber)
        {
            this.randomNumberTextBox.Text = randomNumber.ToString();
        }

        

        public void ReportGeneratedHandle(object sender, string report)
        {
            this.testResultTextBox.Text = report;
        }
    }
}
