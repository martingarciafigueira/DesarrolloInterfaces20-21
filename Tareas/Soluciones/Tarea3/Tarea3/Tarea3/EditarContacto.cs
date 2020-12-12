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
    public partial class EditarContacto : Form
    {
        public EditarContacto()
        {
            InitializeComponent();
        }

        //Carga contactos al comboBox
        public void AñadirContactosCmb()
        {
            cmbContacto.Items.Clear();
            foreach (Contacto contacto in Program.lstContactos)
            {
                cmbContacto.Items.Add(contacto.Dni + " - " + contacto.Nombre);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbContacto.Text != "")
            {
                foreach (Contacto contacto in Program.lstContactos)
                {
                    if (contacto.Dni == cmbContacto.Text.Split('-')[0].Trim())
                    {
                        contacto.Nombre = txtNombre.Text;
                        contacto.Apellidos = txtApellidos.Text;
                        contacto.Telefono = txtTelefono.Text;
                        contacto.Dni = txtDni.Text;
                        contacto.Sexo = cmbSexo.Text;
                        contacto.Estudios = cmbNivelEstudios.Text;
                        contacto.Vicios = cmbVicios.Text;

                        AñadirContactosCmb();
                        MessageBox.Show("Editado Correctamente");
                        break;
                    }
                }
            }
        }

        private void EditarContacto_Load(object sender, EventArgs e)
        {
            AñadirContactosCmb();
        }

        private void cmbContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContacto.Text != "")
            {
                foreach (Contacto contacto in Program.lstContactos)
                {
                    if (contacto.Dni == cmbContacto.Text.Split('-')[0].Trim())
                    {
                        txtNombre.Text = contacto.Nombre;
                        txtApellidos.Text = contacto.Apellidos;
                        txtTelefono.Text = contacto.Telefono;
                        txtDni.Text = contacto.Dni;
                        cmbSexo.Text = contacto.Sexo;
                        cmbNivelEstudios.Text = contacto.Estudios;
                        cmbVicios.Text = contacto.Vicios;
                        break;
                    }
                }
            }
        }
    }
}
