using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int gradosCelsius, gradosFahrenheit;

            gradosCelsius = trackBar1.Value;
            gradosFahrenheit = (gradosCelsius * 9) / 5 + 32;

            lblGradosFahrenheit.Text = gradosFahrenheit.ToString();
        }
    }
}
