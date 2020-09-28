using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "GOL";
            label2.Text = "GOL";
            label3.Text = "GOL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "NO GOL";
            button2.Text = "NO GOL";
            button3.Text = "NO GOL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "A";
            label2.Text = "B";
            label3.Text = "C";
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
        }
    }
}
