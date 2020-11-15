using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int NUM_ENTRADAS = 5;
            double promedio = 0, suma = 0, numero1 = 0, numero2 = 0, numero3 = 0, numero4 = 0, numero5 = 0;

            double.TryParse(textBox1.Text, out numero1);
            double.TryParse(textBox2.Text, out numero2);
            double.TryParse(textBox3.Text, out numero3);
            double.TryParse(textBox4.Text, out numero4);
            double.TryParse(textBox5.Text, out numero5);

            suma = numero1 + numero2 + numero3 + numero4 + numero5;

            promedio = suma / NUM_ENTRADAS;

            textBox6.Text = promedio.ToString();
        }
    }
}
