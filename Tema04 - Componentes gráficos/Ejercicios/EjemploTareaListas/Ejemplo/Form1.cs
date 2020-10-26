using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        List<string> listaDnis;
        public Form1()
        {
            InitializeComponent();
            listaDnis = new List<string>();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lstSuplentes.SelectedItem != null)
            {
                lstTitulares.Items.Add(lstSuplentes.SelectedItem);

                lstSuplentes.Items.Remove(lstSuplentes.SelectedItem);
            }
        }

        private void btnRigth_Click(object sender, EventArgs e)
        {
            if (lstTitulares.SelectedItem != null)
            {
                lstSuplentes.Items.Add(lstTitulares.SelectedItem);

                lstTitulares.Items.Remove(lstTitulares.SelectedItem);
            }
        }

        private void btnVaciarListaTitulares_Click(object sender, EventArgs e)
        {
            string dni;
            foreach (string jugador in lstTitulares.Items)
            {
                if (jugador.Split('|').Length > 1)
                {
                    dni = jugador.Split('|')[1];
                    if (listaDnis.Contains(dni))
                    {
                        listaDnis.Remove(dni);
                    }
                }
            }

            lstTitulares.Items.Clear();
        }

        private void btnEliminarElementoTitulares_Click(object sender, EventArgs e)
        {
            string nombreCompleto, dni;
            if (lstTitulares.SelectedItem != null)
            {
                nombreCompleto = lstTitulares.SelectedItem.ToString();

                dni = nombreCompleto.Split('|')[1];

                if (listaDnis.Contains(dni))
                {
                    listaDnis.Remove(dni);
                }

                lstTitulares.Items.Remove(lstTitulares.SelectedItem);
            }
        }

        private void btnVaciarListaSuplentes_Click(object sender, EventArgs e)
        {
            string dni;
            foreach (string jugador in lstSuplentes.Items)
            {
                if (jugador.Split('|').Length > 1)
                {
                    dni = jugador.Split('|')[1];
                    if (listaDnis.Contains(dni))
                    {
                        listaDnis.Remove(dni);
                    }
                }
            }
            lstSuplentes.Items.Clear();
        }

        private void btnEliminarElementoSuplentes_Click(object sender, EventArgs e)
        {
            string nombreCompleto, dni;
            if (lstSuplentes.SelectedItem != null)
            {
                nombreCompleto = lstSuplentes.SelectedItem.ToString();

                dni = nombreCompleto.Split('|')[1];

                if (listaDnis.Contains(dni))
                {
                    listaDnis.Remove(dni);
                }

                lstSuplentes.Items.Remove(lstSuplentes.SelectedItem);
            }
        }

        private void btnPasarListaRigthLeft_Click(object sender, EventArgs e)
        {
            if (lstSuplentes.Items.Count > 0)
            {
                lstTitulares.Items.AddRange(lstSuplentes.Items);
                lstSuplentes.Items.Clear();
            }
        }

        private void btnPasarListaLeftRigth_Click(object sender, EventArgs e)
        {
            if (lstTitulares.Items.Count > 0)
            {
                lstSuplentes.Items.AddRange(lstTitulares.Items);
                lstTitulares.Items.Clear();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreApellidos;

            if (txtElementoBusqueda != null && txtElementoBusqueda.Text.Split('|').Length > 0)
            {
                nombreApellidos = txtElementoBusqueda.Text.Split('|')[0];

                if (nombreApellidos != "")
                {
                    if (lstTitulares.Items.Contains(nombreApellidos))
                    {
                        lblResultadoBusqueda.Text = "Es titular";
                    }
                    else if (lstSuplentes.Items.Contains(nombreApellidos))
                    {
                        lblResultadoBusqueda.Text = "Es suplente";
                    }
                    else
                    {
                        lblResultadoBusqueda.Text = "No juega";
                    }
                } 
            }
        }

        private void btnInsertarJugador_Click(object sender, EventArgs e)
        {
            string nombre, apellidos, dni, nombreApellidos;

            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;
            dni = txtDNI.Text;

            if (nombre != "" && apellidos != "" && dni != "")
            {
                nombreApellidos = nombre + " " + apellidos + '|' + dni;

                if (!listaDnis.Contains(dni))
                {
                    listaDnis.Add(dni);
                    lstSuplentes.Items.Add(nombreApellidos);
                    txtNombre.Text = "";
                    txtApellidos.Text = "";
                    txtDNI.Text = "";
                }
            }

        }

        private void btnRegistrarAlineacion_Click(object sender, EventArgs e)
        {
            string textoAlineacion;

            if (lstTitulares.Items.Count > 0)
            {
                textoAlineacion = "El día " + dtpDiaPartido.Value.ToShortDateString() + " han jugado los jugadores: ";

                foreach (string jugador in lstTitulares.Items)
                {
                    textoAlineacion = textoAlineacion + jugador.Split('|')[0] + ", ";
                }

                lstSuplentes.Items.AddRange(lstTitulares.Items);
                lstTitulares.Items.Clear();

                lstHistoricoAlineaciones.Items.Add(textoAlineacion);
            }
        }
    }
}
