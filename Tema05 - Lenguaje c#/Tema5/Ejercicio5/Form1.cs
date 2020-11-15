using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int edad;

            int.TryParse(textBox1.Text, out edad);

            if (edad >= 16 && edad < 65)
            {
                label2.Text = "Puedes trabajar";
            }
            else
            {
                label2.Text = "No puedes trabajar";
            }
        }
    }
}
