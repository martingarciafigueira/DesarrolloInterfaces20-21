using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        int sumaNumeros = 0;
        double promedioNumeros = 0;
        int contadorNumeros = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerarNumero_Click(object sender, EventArgs e)
        {
            int numeroAleatorio;
            
            var numero = new Random();

            numeroAleatorio = numero.Next(200, 400);

            contadorNumeros++;
            sumaNumeros += numeroAleatorio;
            promedioNumeros = sumaNumeros / contadorNumeros;

            lblNumeroAleatorio.Text = numeroAleatorio.ToString();
            lblSuma.Text = sumaNumeros.ToString();
            lblPromedio.Text = promedioNumeros.ToString();
        }
    }
}
