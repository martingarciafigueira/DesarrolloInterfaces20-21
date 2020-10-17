using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMoverElementoIZQDER_Click(object sender, EventArgs e)
        {
            if (lstTitulares.SelectedItem != null)
            {
                lstSuplentes.Items.Add(lstTitulares.SelectedItem);
                lstTitulares.Items.Remove(lstTitulares.SelectedItem);
            }
        }

        private void btnMoverElementoDERIZQ_Click_1(object sender, EventArgs e)
        {
            if (lstSuplentes.SelectedItem != null)
            {
                lstTitulares.Items.Add(lstSuplentes.SelectedItem);
                lstSuplentes.Items.Remove(lstSuplentes.SelectedItem);
            }
        }

        private void btnEliminarElementoTitulares_Click(object sender, EventArgs e)
        {
            if (lstTitulares.SelectedItem != null)
            {
                lstTitulares.Items.Remove(lstTitulares.SelectedItem);
            }
        }

        private void btnEliminarElementoSuplentes_Click(object sender, EventArgs e)
        {
            if (lstSuplentes.SelectedItem != null)
            {
                lstSuplentes.Items.Remove(lstSuplentes.SelectedItem);
            }
        }

        private void btnVaciarListaTitulares_Click(object sender, EventArgs e)
        {
            lstTitulares.Items.Clear();
        }

        private void btnVaciarListaSuplentes_Click(object sender, EventArgs e)
        {
            lstSuplentes.Items.Clear();
        }

    }
}
