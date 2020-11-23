using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random lanzadorDados = new Random();
            int resultadoUno, resultadoDos, resultadoTres;

            resultadoUno = lanzadorDados.Next(1, 6);
            resultadoDos = lanzadorDados.Next(1, 6);
            resultadoTres = lanzadorDados.Next(1, 6);

            if (resultadoUno == 6 && resultadoDos == 6 && resultadoTres == 6)
            {
                MessageBox.Show("Ha ganado 20€!!");
            }
            else if (resultadoUno == resultadoDos && resultadoDos == resultadoTres)
            {
                MessageBox.Show("Ha ganado 10€!!");
            }
            else if (resultadoUno == resultadoDos || resultadoDos == resultadoTres || resultadoUno == resultadoTres)
            {
                MessageBox.Show("Ha ganado 5€!!");
            }
            else
            {
                MessageBox.Show("No has ganado nada");
            }

        }
    }
}
