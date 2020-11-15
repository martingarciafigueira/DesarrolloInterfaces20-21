using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            int numVocales = 0;

            cadena = textBox1.Text.ToUpper();

            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];

                switch (caracter)
                {
                    case 'A':
                        {
                            numVocales++;
                            break;
                        }
                    case 'E':
                        {
                            numVocales++;
                            break;
                        }
                    case 'I':
                        {
                            numVocales++;
                            break;
                        }
                    case 'O':
                        {
                            numVocales++;
                            break;
                        }
                    case 'U':
                        {
                            numVocales++;
                            break;
                        }
                }

            }

            MessageBox.Show("Hay " + numVocales +" vocales");

        }
    }
}
