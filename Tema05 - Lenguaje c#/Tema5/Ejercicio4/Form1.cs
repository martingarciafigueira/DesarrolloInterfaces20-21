using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int dado1, dado2, sumaDados;

            dado1 = trackBar1.Value;
            dado2 = trackBar2.Value;

            sumaDados = dado1 + dado2;

            if (sumaDados == 6)
            {
                textBox1.Text = "VICTORIA!";
            }
            else
            {
                textBox1.Text = "DERROTA";
            }
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            int dado1, dado2, sumaDados;

            dado1 = trackBar1.Value;
            dado2 = trackBar2.Value;

            sumaDados = dado1 + dado2;

            if (sumaDados == 6)
            {
                textBox1.Text = "VICTORIA!";
            }
            else
            {
                textBox1.Text = "DERROTA";
            }
        }
    }
}
