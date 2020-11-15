using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2, valor3, maximo;

            valor1 = trackBar1.Value;
            valor2 = trackBar2.Value;
            valor3 = trackBar3.Value;

            if (valor1 >= valor2)
            {
                maximo = valor1;
                if (valor3 >= valor1)
                {
                    maximo = valor3;
                }
            }
            else
            {
                maximo = valor2;
                if (valor3 >= valor2)
                {
                    maximo = valor3;
                }
            }

            MessageBox.Show("El valor máximo es: " + maximo);

        }
    }
}
