using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3
{
    public partial class AgregarContacto : Form
    {
        public AgregarContacto()
        {
            InitializeComponent();
        }

        public static bool AñadirContacto()
        {
            bool creado = false;
          
            return creado;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtApellidos.Text != "" && txtTelefono.Text != "" && txtDni.Text != "" && cmbSexo.Text != "")
            {
                if (!Contacto.ExisteDni(txtDni.Text, Program.lstContactos)) {
                    Contacto nuevoContacto = new Contacto(txtNombre.Text, txtApellidos.Text, txtTelefono.Text, txtDni.Text, cmbSexo.Text, cmbNivelEstudios.Text, cmbVicios.Text);
                    Program.lstContactos.Add(nuevoContacto);
                    MessageBox.Show("Creado correctamente");
                }
                else
                {
                    MessageBox.Show("Ya existe un contacto con ese DNI.");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos restantes.");
            }
        }

    }
}
