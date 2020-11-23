using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbBarrasSeguimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBarrasSeguimiento.Checked)
            {
                grpBarrasSeguimiento.Enabled = true;
                grpCajasTexto.Enabled = false;
            }
            else
            {
                grpBarrasSeguimiento.Enabled = false;
                grpCajasTexto.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (grpBarrasSeguimiento.Enabled)
            {
                List<int> listaValores = new List<int>();

                listaValores.Add(trackBar1.Value);
                listaValores.Add(trackBar2.Value);
                listaValores.Add(trackBar3.Value);
                listaValores.Sort();

                MessageBox.Show("Los valores recibidos son:");
                foreach (int valor in listaValores)
                {
                    MessageBox.Show(valor.ToString());
                }
            }
            else
            {
                List<int> listaValores = new List<int>();
                int numero;

                int.TryParse(textBox1.Text, out numero);
                listaValores.Add(numero);
                int.TryParse(textBox2.Text, out numero);
                listaValores.Add(numero);
                int.TryParse(textBox3.Text, out numero);
                listaValores.Add(numero);
                listaValores.Sort();

                MessageBox.Show("Los valores recibidos son:");
                foreach (int valor in listaValores)
                {
                    MessageBox.Show(valor.ToString());
                }
            }
        }
    }
}
