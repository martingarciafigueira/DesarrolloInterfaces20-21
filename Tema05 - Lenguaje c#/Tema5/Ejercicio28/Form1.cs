using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, suma = 0;

            int.TryParse(textBox1.Text, out numero);

            for (int i = 0; i < numero; i++)
            {
                suma += i;
            }

            MessageBox.Show("La suma de los números que preceden al " + numero + " es: " + suma);
        }
    }
}
