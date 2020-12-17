using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8Electrodomesticos
{
    public partial class Form1 : Form
    {
        BindingList<Electrodomestico> listaElectrodomesticos;
        public Form1()
        {
            InitializeComponent();
            listaElectrodomesticos = new BindingList<Electrodomestico>();
            lstElectrodomesticos.DataSource = listaElectrodomesticos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string consumoEnergetico, anhoFabricacion;
            int carga;

            consumoEnergetico = textBox1.Text;
            anhoFabricacion = textBox2.Text;
            int.TryParse(textBox3.Text, out carga);

            Electrodomestico lavadora = new Lavadora(consumoEnergetico, anhoFabricacion, carga);
            listaElectrodomesticos.Add(lavadora);

            MessageBox.Show(lavadora.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string consumoEnergetico, anhoFabricacion;
            int temperatura;

            consumoEnergetico = textBox1.Text;
            anhoFabricacion = textBox2.Text;
            int.TryParse(textBox3.Text, out temperatura);

            Electrodomestico nevera = new Nevera(consumoEnergetico, anhoFabricacion, temperatura);
            listaElectrodomesticos.Add(nevera);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string consumoEnergetico, anhoFabricacion;
            int resolucion;

            consumoEnergetico = textBox1.Text;
            anhoFabricacion = textBox2.Text;
            int.TryParse(textBox3.Text, out resolucion);

            Electrodomestico television = new Television(consumoEnergetico, anhoFabricacion, resolucion);
            listaElectrodomesticos.Add(television);
        }
    }
}
