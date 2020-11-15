using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero;

            double.TryParse(textBox1.Text, out numero);

            if (numero % 2 == 0)
            {
                label1.Text = "PAR";
            }
            else
            {
                label1.Text = "IMPAR";
            }

        }
    }
}
