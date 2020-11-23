using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;

            edad = trackBar1.Value;

            if (edad < 5)
            {
                MessageBox.Show("Función gratis!");
            }
            else if (edad >=5 && edad <= 12)
            {
                MessageBox.Show("Mitad de tarifa");
            }
            else if (edad >= 13 && edad <= 64)
            {
                MessageBox.Show("Tarifa completa");
            }
            else
            {
                MessageBox.Show("Función gratis!");
            }
        }
    }
}
