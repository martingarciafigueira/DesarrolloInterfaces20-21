using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int ancho = 5, largo = 20;
            double profundidadPromedio;
            double volumen;

            profundidadPromedio = (double) (tbExtremoMenosProfundo.Value + tbExtremoProfundo.Value) / 2;
            volumen = profundidadPromedio * ancho * largo;

            txtVolumenPiscina.Text = volumen.ToString();

        }

        private void tbExtremoMenosProfundo_ValueChanged(object sender, EventArgs e)
        {
            int ancho = 5, largo = 20;
            double profundidadPromedio;
            double volumen;

            profundidadPromedio = (double) (tbExtremoMenosProfundo.Value + tbExtremoProfundo.Value) / 2;
            volumen = profundidadPromedio * ancho * largo;

            txtVolumenPiscina.Text = volumen.ToString();
        }
    }
}
