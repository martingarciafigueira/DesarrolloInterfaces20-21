using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorMinimo, valorMaximo;

            int.TryParse(txtMinimo.Text, out valorMinimo);
            int.TryParse(txtMaximo.Text, out valorMaximo);

            tkbMaximoMinimo.Minimum = valorMinimo;
            tkbMaximoMinimo.Maximum = valorMaximo;

        }

        private void tkbMaximoMinimo_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El valor actual del Trackbar es: " + tkbMaximoMinimo.Value);
        }
    }
}
