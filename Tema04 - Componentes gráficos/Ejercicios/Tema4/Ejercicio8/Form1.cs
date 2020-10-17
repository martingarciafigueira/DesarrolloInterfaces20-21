using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gradosCelsius, gradosFahrenheit;

            double.TryParse(txtGradosCelsius.Text, out gradosCelsius);

            gradosFahrenheit = (gradosCelsius * 9) / 5 + 32;

            lblGradosFahrenheit.Text = gradosFahrenheit.ToString();
        }
    }
}
