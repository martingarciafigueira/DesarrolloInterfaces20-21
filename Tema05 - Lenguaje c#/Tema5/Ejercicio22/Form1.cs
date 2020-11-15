using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void pintaNumeroAleatorio()
        {
            int numero;

            Random nuevo = new Random();

            numero = nuevo.Next(1, 7);

            textBox1.Text = numero.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pintaNumeroAleatorio();
        }
    }
}
