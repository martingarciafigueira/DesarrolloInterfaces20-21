using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            double.TryParse(textBox1.Text, out numero1);
            double.TryParse(textBox2.Text, out numero2);

            resultado = numero1 + numero2;

            textBox3.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;

            double.TryParse(textBox1.Text, out numero1);
            double.TryParse(textBox2.Text, out numero2);

            resultado = numero1 - numero2;

            textBox3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
