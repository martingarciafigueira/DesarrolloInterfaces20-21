using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2, rFinal;
            string tipoResistencia;

            double.TryParse(txtR1.Text, out r1);
            double.TryParse(txtR2.Text, out r2);

            if (rbSerie.Checked == true)
            {
                rFinal = r1 + r2;
                tipoResistencia = "serie";
            }
            else
            {
                rFinal = r1 * r2 / (r1 + r2);
                tipoResistencia = "paralelo";
            }

            MessageBox.Show("La resistencia final es en " + tipoResistencia + " y su valor es: " + rFinal.ToString()); ;
        }
    }
}
