using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dia;
            if (listBox1.SelectedItem != null)
            {
                dia = listBox1.SelectedItem.ToString().Split(':')[1];
                MessageBox.Show("Ha elegido el: " + dia); 
            }
        }
    }
}
