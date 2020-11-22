using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Form1 : Form
    {
        List<Persona> listaPersonas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevaPersona_Click(object sender, EventArgs e)
        {
            string nombre, apellidos, dni, estadoCivil;
            int edad;

            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;
            dni = txtDni.Text;
            estadoCivil = txtEstadoCivil.Text;

            int.TryParse(txtEdad.Text, out edad);

            Persona nuevaPersona = new Persona(nombre, apellidos, edad, dni, estadoCivil);

            listaPersonas.Add(nuevaPersona);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Persona persona in listaPersonas)
            {
                persona.describirPersona();
            }
        }
    }
}
