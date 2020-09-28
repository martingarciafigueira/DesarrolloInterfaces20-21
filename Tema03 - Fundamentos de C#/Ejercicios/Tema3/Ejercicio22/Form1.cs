using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int alto, longitud, ancho;

            int.TryParse(txtAlto.Text, out alto);
            int.TryParse(txtLongitud.Text, out longitud);
            int.TryParse(txtAncho.Text, out ancho);

            MessageBox.Show("El volumen es: " + longitud * ancho * alto);
        }
    }
}
