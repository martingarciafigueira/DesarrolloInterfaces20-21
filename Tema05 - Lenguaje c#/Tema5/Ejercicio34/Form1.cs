using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio34
{
    public partial class Form1 : Form
    {
        public string combinacion = "";
        public string combinacionCorrecta;
        public Form1()
        {
            InitializeComponent();
            EstablecerCombinacion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            combinacion = "";
            combinacionCorrecta = "";

            EstablecerCombinacion();
        }

        public void EstablecerCombinacion()
        {
            Random generador = new Random();
            StringBuilder creadorCadena = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                creadorCadena.Append(generador.Next(1, 4));
            }

            combinacionCorrecta = creadorCadena.ToString();
        }

        public void comprobarCombinacion()
        {
            if (combinacion == combinacionCorrecta)
            {
                MessageBox.Show("COMBINACIÓN CORRECTA!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combinacion += "1";
            comprobarCombinacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            combinacion += "2";
            comprobarCombinacion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            combinacion += "3";
            comprobarCombinacion();
        }
    }
}
