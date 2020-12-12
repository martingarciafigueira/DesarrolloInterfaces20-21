using Dado.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dado
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzarDado_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroRandom = random.Next(1,7);
            picDado.Load(@"..\..\Resources\dado"+numeroRandom+".PNG");
            Dado.intTiradaActual = numeroRandom;
            Dado.intSumaTiradas += numeroRandom;
            Dado.tiradas.Add(numeroRandom);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas estadisticas = new Estadisticas();
            estadisticas.ShowDialog();      
        }
    }
}
