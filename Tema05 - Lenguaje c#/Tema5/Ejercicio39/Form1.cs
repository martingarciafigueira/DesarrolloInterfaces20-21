using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            for (int i = 1; i < 5; i++)
            {
                texto += calcularS(i);
                texto += "\r\n";
            }
            textBox1.Text = texto;
        }

        public string calcularS(int numeroEses)
        {
            string eses = "";
            for (int i = 0; i < numeroEses; i++)
            {
                eses += "S";
            }
            return eses;
        }
    }
}
