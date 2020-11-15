using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int numeroRecibido;

            int.TryParse(textBox1.Text, out numeroRecibido);

            switch (numeroRecibido)
            {
                case 1:
                    {
                        MessageBox.Show("Su palo es OROS");
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Su palo es BASTOS");
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Su palo es COPAS");
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Su palo es ESPADAS");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Introduzca un número entre 1 y 4");
                        break;
                    }
            }
        }
    }
}
