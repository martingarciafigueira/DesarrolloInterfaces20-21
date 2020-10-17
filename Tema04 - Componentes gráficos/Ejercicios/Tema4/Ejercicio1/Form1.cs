using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1=0, numero2=0, resultado;

            double.TryParse(txtNumero1.Text, out numero1);
            double.TryParse(txtNumero2.Text, out numero2);

            resultado = numero1 + numero2;

            txtResultado.Text = resultado.ToString();
        }
    }
}
