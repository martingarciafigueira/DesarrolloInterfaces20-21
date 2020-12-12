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
    public partial class BorrarContacto : Form
    {
        public BorrarContacto()
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

        private void BorrarContacto_Load(object sender, EventArgs e)
        {
            AñadirContactosCmb();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Program.lstContactos.Count; i++) 
            {
                if (cmbContacto.Text.Split('-')[0].Trim() == Program.lstContactos[i].Dni)
                {
                    Program.lstContactos.RemoveAt(i);
                    AñadirContactosCmb();
                    MessageBox.Show("Eliminado correctamente.");
                    break;
                }
                
            }

        }
    }
}
