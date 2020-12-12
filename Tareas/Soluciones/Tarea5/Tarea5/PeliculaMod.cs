using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Tarea_5_NicolasEstevezPazos
{
    public partial class EditarPelicula : Form
    {
        internal static IParametrosVideClub InterfazVideoClub { get; set; }

        //VARIABLES
        Pelicula peliculaModificar;
        int indice = -1;
        public EditarPelicula(bool nuevo)
        {
            InitializeComponent();
            foreach(Estados i in Enum.GetValues(typeof(Estados)))
            {
                cBoxEstado.Items.Add(i.ToString());
            }
            if (nuevo)
            {
                peliculaModificar = new Pelicula();
            }
        }
        public void EstablecerModificacion(Pelicula pel, bool acceso, int indice)
        {
            this.peliculaModificar = pel;
            this.indice = indice;
            ModificacionAccesoControles(acceso);
            CargarDatos();
        }

        public void ModificacionAccesoControles(bool acceso)
        {
            //Controles pelicula
            txtBoxTitulo.Enabled = acceso;
            txtBoxCodigo.Enabled = acceso;
            txtBoxDirector.Enabled = acceso;
            cBoxEstado.Enabled = acceso;
            dateFechaDevolucion.Enabled = acceso;
            //Controles Actor
            txtBoxNombre.Enabled = acceso;
            dateFechaNacimiento.Enabled = acceso;
            txtBoxNIF.Enabled = acceso;
            //Boton
            btnGuardarCambios.Enabled = acceso;
        }

        public void CargarDatos()
        {
            //Controles pelicula
            txtBoxTitulo.Text = peliculaModificar.Titulo;
            txtBoxCodigo.Text = peliculaModificar.Codigo;
            txtBoxDirector.Text = peliculaModificar.Director;
            //txtBoxEstado.Text = peliculaModificar.Estado.ToString();
            cBoxEstado.SelectedItem = peliculaModificar.Estado.ToString();
            //txtBoxFechaDevolucion.Text = peliculaModificar.FechaDevolucion.ToString();
            dateFechaDevolucion.Value = peliculaModificar.FechaDevolucion;
            //Controles Actor
            if (peliculaModificar.Actor == null)
            {
                txtBoxNombre.Text = "";
                //txtBoxFechaNacimiento.Text = "";
                dateFechaNacimiento.Value = new DateTime();
                txtBoxEdad.Text = "";
                txtBoxNIF.Text = "";
            }
            else
            {
                txtBoxNombre.Text = peliculaModificar.Actor.Nombre;
                //txtBoxFechaNacimiento.Text = peliculaModificar.Actor.FechaNacimiento.ToString();
                dateFechaNacimiento.Value = peliculaModificar.Actor.FechaNacimiento;
                txtBoxEdad.Text = peliculaModificar.Actor.Edad.ToString();
                txtBoxNIF.Text = peliculaModificar.Actor.Nif;
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            bool guardarCambios = true;

            bool ressult = Enum.GetNames(typeof(Estados)).Contains(cBoxEstado.Text);
            if (!ressult)
            {
                //Si el estado introducido no coincide no guardamos
                MessageBox.Show("Revise el estado introducido ya que no es correcto");
                guardarCambios = false;
            }

            if (Actor.ComprobarNIF(txtBoxNIF.Text) == false)
            {
                MessageBox.Show("Revise el NIF del Autor");
                guardarCambios = false;
            }
            else if (txtBoxNombre.Text == "" || txtBoxNombre.Text == " " ||
                txtBoxTitulo.Text == "" || txtBoxTitulo.Text == " " ||
                txtBoxCodigo.Text == "" || txtBoxCodigo.Text == " " ||
                txtBoxDirector.Text == "" || txtBoxDirector.Text == " ")
            {
                MessageBox.Show("Revise los campos ninguno de ellos puede estar vacio.");
                guardarCambios = false;
            }

            if (guardarCambios)
            {
                Guardar();
            }
        }

        public void Guardar()
        {
            //Controles pelicula
            peliculaModificar.Titulo = txtBoxTitulo.Text;
            peliculaModificar.Codigo = txtBoxCodigo.Text;
            peliculaModificar.Director = txtBoxDirector.Text;
            string valor = cBoxEstado.Items[cBoxEstado.SelectedIndex].ToString();
            Estados estadoGuardar;
            bool conversion = Enum.TryParse<Estados>(valor, out estadoGuardar);
            if (conversion)
            {
                peliculaModificar.Estado = estadoGuardar;
            }
            peliculaModificar.FechaDevolucion = dateFechaDevolucion.Value;
            //Controles Actor
            peliculaModificar.Actor = new Actor(dateFechaNacimiento.Value, txtBoxNombre.Text, txtBoxNIF.Text);

            InterfazVideoClub.EstablecerCambiosPelicula(peliculaModificar, indice);
            MessageBox.Show("Datos guardados correctamente, cierre el formulario para que se actualicen en la tabla principal");
        }
    }
}
