using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radio;

            int.TryParse(txtRadio.Text, out radio);

            MessageBox.Show("La circunferencia del círculo es: " + radio * 2 * Math.PI);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int radio;

            int.TryParse(txtRadio.Text, out radio);

            MessageBox.Show("El área del círculo es: " + radio * radio * Math.PI);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int radio;

            int.TryParse(txtRadio.Text, out radio);

            MessageBox.Show("El volumen de una esfera es: " + (4 / 3) * Math.PI * radio * radio * radio);
        }
    }
}
