using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                string cadena;
                int resultado;
                resultado = 2 * i;
                cadena = "2 x " + i + "= " + resultado;
                listBox1.Items.Add(cadena);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                string cadena;
                int resultado;
                resultado = 3 * i;
                cadena = "3 x " + i + "= " + resultado;
                listBox1.Items.Add(cadena);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 10; i >= 1; i--)
            {
                string cadena;
                int resultado;
                resultado = 5 * i;
                cadena = "5 x " + i + "= " + resultado;
                listBox1.Items.Add(cadena);
            }
        }
    }
}
