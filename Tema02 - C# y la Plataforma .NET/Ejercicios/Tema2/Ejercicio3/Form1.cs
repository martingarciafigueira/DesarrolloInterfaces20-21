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
            string nombrePersona;
            int edadPersona;
            string dniPersona;
            string generoPersona;

            string mensajeCompleto;

            nombrePersona = txtNombre.Text;
            int.TryParse(txtEdad.Text, out edadPersona);
            dniPersona = txtDNI.Text;
            generoPersona = txtGenero.Text;

            mensajeCompleto = "Se introduce una persona con nombre: "+nombrePersona+", edad: "+edadPersona.ToString()+", DNI: "+dniPersona+" y género: "+generoPersona;

            MessageBox.Show(mensajeCompleto);

        }
    }
}
