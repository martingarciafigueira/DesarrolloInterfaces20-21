using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gradosFahrenheit, gradosCelsius;

            double.TryParse(txtGrados.Text, out gradosCelsius);

            gradosFahrenheit = (gradosCelsius * 9 / 5) + 32;

            MessageBox.Show(gradosCelsius.ToString() + " grados Celsius son " + gradosFahrenheit.ToString() + " grados Fahrenheit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double gradosFahrenheit, gradosCelsius;

            double.TryParse(txtGrados.Text, out gradosFahrenheit);

            gradosCelsius = (gradosFahrenheit - 32) * 5 / 9;

            MessageBox.Show(gradosFahrenheit.ToString() + " grados Fahrenheit son " + gradosCelsius.ToString() + " grados Celsius");
        }
    }
}
