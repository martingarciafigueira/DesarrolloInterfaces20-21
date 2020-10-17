using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje de información");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje de decisión", "Mensaje de decisión", MessageBoxButtons.YesNo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje de error", "Mensaje de error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
        }
    }
}
