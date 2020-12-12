using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Estadisticas : Form
    {
      
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
           lblTiradaActual.Text = Dado.intTiradaActual.ToString();
           lblSumaTiradas.Text = Dado.intSumaTiradas.ToString();
           lblTiradaFrecuente.Text = Dado.tiradaFrecuente().ToString();
        }
    }
}
