using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int salario;
            double impuestos;

            salario = trackBar1.Value;

            if (salario <= 10000)
            {
                impuestos = 0;
            }
            else if (salario > 10000 && salario <= 50000)
            {
                impuestos = salario * 0.2;
            }
            else
            {
                impuestos = salario * 0.9;
            }

            label2.Text = "Debes pagar " + impuestos + " euros en impuestos!";
        }
    }
}
