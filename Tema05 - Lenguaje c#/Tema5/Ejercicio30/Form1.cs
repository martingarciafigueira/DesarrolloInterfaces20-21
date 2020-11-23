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

        private void btnElegirCarta_Click(object sender, EventArgs e)
        {
            int paloAleatorio, numAleatorio;
            string palo="Oros", numero;

            Random generador = new Random();
            paloAleatorio = generador.Next(1, 4);
            numAleatorio = generador.Next(1, 12);

            switch (paloAleatorio)
            {
                case 1:
                    {
                        palo = "Espadas";
                        break;
                    }
                case 2:
                    {
                        palo = "Oros";
                        break;
                    }
                case 3:
                    {
                        palo = "Copas";
                        break;
                    }
                case 4:
                    {
                        palo = "Bastos";
                        break;
                    }
            }

            switch (numAleatorio)
            {
                case 1:
                    {
                        numero = "AS";
                        break;
                    }
                case 10:
                    {
                        numero = "Sota";
                        break;
                    }
                case 11:
                    {
                        numero = "Caballo";
                        break;
                    }
                case 12:
                    {
                        numero = "Rey";
                        break;
                    }

                default:
                    {
                        numero = numAleatorio.ToString();
                    }
                    break;
            }

            MessageBox.Show("Te ha salido el " + numero + " de " + palo);

        }
    }
}
