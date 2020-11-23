using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio35
{
    public partial class Form1 : Form
    {
        public enum eleccion { piedra =1, papel = 2, tijeras = 3};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jugar(eleccion.piedra);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jugar(eleccion.papel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jugar(eleccion.tijeras);
        }

        public void jugar(eleccion eleccionUsuario)
        {
            Random generador = new Random();
            eleccion eleccionOrdenador = (eleccion) generador.Next(1, 4);

            if (eleccionUsuario == eleccion.piedra && eleccionOrdenador == eleccion.tijeras ||
                eleccionUsuario == eleccion.papel && eleccionOrdenador == eleccion.piedra ||
                eleccionUsuario == eleccion.tijeras && eleccionOrdenador == eleccion.papel)
            {
                MessageBox.Show("HAS GANADO!");
            }
            else if (eleccionUsuario == eleccionOrdenador)
            {
                MessageBox.Show("HAS EMPATADO");
            }
            else
            {
                MessageBox.Show("HAS PERDIDO");
            }
        }
    }
}
