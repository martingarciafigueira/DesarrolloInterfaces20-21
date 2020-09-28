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
            double nomina, cantidadTrasDeducciones, cantidadImpuestos;

            double.TryParse(txtNomina.Text, out nomina);

            cantidadTrasDeducciones = nomina * 0.85;

            cantidadImpuestos = nomina - cantidadTrasDeducciones;

            MessageBox.Show("La cantidad inicial es: " + nomina.ToString());
            MessageBox.Show("La cantidad después de deducciones es: " + cantidadTrasDeducciones.ToString());
            MessageBox.Show("La cantidad que se dedujo es: " + cantidadImpuestos.ToString());
        }
    }
}
