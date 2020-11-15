using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dineroExpendido;
            int billetesCinco, billetesDiez;

            int.TryParse(textBox1.Text, out dineroExpendido);

            CalcularBilletes(dineroExpendido, out billetesDiez, out billetesCinco);

            if (billetesDiez > 0 || billetesCinco > 0)
            {
                MessageBox.Show("La cantidad " + dineroExpendido.ToString() + " se puede expendir en " + billetesDiez.ToString() + " billetes de diez y " + billetesCinco.ToString() + " billetes de cinco"); 
            }
            else
            {
                MessageBox.Show("La cantidad introducida no se puede devolver en billetes de 5 y 10 euros");
            }
        }

        public void CalcularBilletes(int cantidad, out int billetesDiez, out int billetesCinco)
        {
            billetesDiez = 0;
            billetesCinco = 0;

            if (cantidad % 10 == 0)
            {
                billetesDiez = cantidad / 10;
            }
            else if (cantidad % 5 == 0)
            {
                billetesDiez = cantidad / 10;
                cantidad -= billetesDiez * 10;
                billetesCinco = cantidad / 5;
            }
        }
    }
}
