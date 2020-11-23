using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = "";
            int numeroTabla;

            int.TryParse(textBox1.Text, out numeroTabla);

            texto += "\t";

            for (int i = 1; i <= numeroTabla; i++)
            {
                texto += i + "\t";
            }
            texto +="\r\n";
            for (int i = 1; i <= numeroTabla; i++)
            {
                texto += i + "\t";
                for (int j = 1; j <= numeroTabla; j++)
                {
                    texto += (i * j) + "\t";
                }
                texto += "\r\n";
            }

            textBox2.Text = texto;
        }
    }
}
