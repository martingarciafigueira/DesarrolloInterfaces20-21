using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dineroIngresado, precioArticulo, dineroRestante;
            int numMonedas = 0;

            double.TryParse(txtDineroIngresado.Text, out dineroIngresado);
            double.TryParse(txtPrecioArticulo.Text, out precioArticulo);

            //Lo pasamos a centimos
            dineroIngresado = dineroIngresado * 100;
            precioArticulo = precioArticulo * 100;
            dineroRestante = dineroIngresado - precioArticulo;

            //Calculo el numero de monedas
            numMonedas = (int)dineroRestante / 200;
            MessageBox.Show("La cantidad de monedas de 2€ es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 200);
            }
            numMonedas = (int)dineroRestante / 100;
            MessageBox.Show("La cantidad de monedas de 1€ es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 100);
            }
            numMonedas = (int)dineroRestante / 50;
            MessageBox.Show("La cantidad de monedas de 50ct es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 50);
            }
            numMonedas = (int)dineroRestante / 20;
            MessageBox.Show("La cantidad de monedas de 20ct es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 20);
            }
            numMonedas = (int)dineroRestante / 10;
            MessageBox.Show("La cantidad de monedas de 10ct es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 10);
            }
            numMonedas = (int)dineroRestante / 5;
            MessageBox.Show("La cantidad de monedas de 5ct es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 5);
            }
            numMonedas = (int)dineroRestante / 2;
            MessageBox.Show("La cantidad de monedas de 2ct es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - (numMonedas * 2);
            }
            numMonedas = (int)dineroRestante;
            MessageBox.Show("La cantidad de monedas de 1ct es " + numMonedas);
            if (numMonedas > 0)
            {
                dineroRestante = dineroRestante - numMonedas;
            }
        }
    }
}
