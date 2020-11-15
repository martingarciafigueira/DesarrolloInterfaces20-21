using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        int valorMinimo = int.MaxValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar1.Value < valorMinimo)
            {
                valorMinimo = trackBar1.Value; 
            }
            textBox1.Text = valorMinimo.ToString();
            int edad = 24;


            if (edad <= 16)
            {
                label1.Text = "Adolescente";
            }

        }
    }
}
