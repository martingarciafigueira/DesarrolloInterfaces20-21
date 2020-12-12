using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DI_Tarea_5_NicolasEstevezPazos
{
    public partial class Form1 : Form, IParametrosVideClub
    {
        //Variable para almacenar los videoClubs
        private List<VideoClub> listaVideoClubs = new List<VideoClub> { };
        //Variable que contiene el videoClub actual
        private VideoClub videoClub;
        //Variable que contiene la lista de actores
        private List<Actor> listActores = new List<Actor> { };

        public Form1()
        {
            InitializeComponent();
        }

        #region Botones
        private void btnNuevaPelicula_Click(object sender, EventArgs e)
        {
            EditarPelicula formPelicula = new EditarPelicula(true);
            EditarPelicula.InterfazVideoClub = this;
            formPelicula.ShowDialog();
            RecargarListView();
        }
        private void btnEditarPelicula_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection listaSeleccion = listViewPeliculasVideoClub.SelectedItems;

            if (listaSeleccion.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista para poder editarlo.");
            }
            else
            {
                foreach (ListViewItem item in listaSeleccion)
                {
                    EditarPelicula formPelicula = new EditarPelicula(false);
                    EditarPelicula.InterfazVideoClub = this;
                    formPelicula.EstablecerModificacion(videoClub.ListaPeliculas[item.Index], true, item.Index);
                    formPelicula.ShowDialog();
                }
            }
            RecargarListView();
        }
        private void btnMostrarPelicula_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection listaSeleccion = listViewPeliculasVideoClub.SelectedItems;

            if (listaSeleccion.Count == 0)
            {
                MessageBox.Show("Seleccione un elemento de la lista para poder mostrarlo.");
            }
            else
            {
                foreach (ListViewItem item in listaSeleccion)
                {
                    EditarPelicula formPelicula = new EditarPelicula(false);
                    EditarPelicula.InterfazVideoClub = this;
                    formPelicula.EstablecerModificacion(videoClub.ListaPeliculas[item.Index], false, -1);
                    formPelicula.ShowDialog();
                }
            }
        }
        private void btnMostrarTodas_Click(object sender, EventArgs e)
        {
            foreach (Pelicula peli in videoClub.ListaPeliculas)
            {
                EditarPelicula formPelicula = new EditarPelicula(false);
                EditarPelicula.InterfazVideoClub = this;
                formPelicula.EstablecerModificacion(peli, false, -1);
                formPelicula.Show();
            }
        }
        #endregion

        #region Control Formulario
        /// <summary>
        /// Funcion para introducir los datos de prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Estos datos deberian de proceder de un TXT o base de datos
            //Listas predefinidas
            videoClub = new VideoClub("A123b");
            selectCodigoVideoClub.Text = "A123b";

            listaVideoClubs.Add(videoClub);

            //Creamos un par de actores
            listActores.Add(new Actor(new DateTime(2020, 12, 01), "Nicolas Estevez", "39487580F"));
            listActores.Add(new Actor(new DateTime(2019, 01, 01), "Martin Garcia", "12345678A"));
            listActores.Add(new Actor(new DateTime(2018, 01, 01), "Ramon Rios", "12345678B"));
            
            //Creamos los generos
            videoClub.AnhadirGenero(Generos.Accion);
            videoClub.AnhadirGenero(Generos.Aventuras);
            videoClub.AnhadirGenero(Generos.Belicas);
            videoClub.AnhadirGenero(Generos.Ciencia_ficcion);
            videoClub.AnhadirGenero(Generos.Comedias);
            videoClub.AnhadirGenero(Generos.Comica);
            videoClub.AnhadirGenero(Generos.Drama);
            videoClub.AnhadirGenero(Generos.Dramaticas);
            videoClub.AnhadirGenero(Generos.Musicales);
            videoClub.AnhadirGenero(Generos.Terror);

            //Creamos las peliculas
            /*Pelicula peliTemp1 = ;
            peliTemp1.Actor = listActores[0];*/
            Pelicula pelTemp;

            pelTemp = new Pelicula("Joker", "11111111", "Todd Philips");
            pelTemp.Actor = listActores[0];
            pelTemp.Estado = Estados.Disponible;
            videoClub.AnhadirPelicula(pelTemp);

            pelTemp = new Pelicula("Parasitos", "22222222", "Bong Joon-ho");
            pelTemp.Actor = listActores[1];
            pelTemp.Estado = Estados.Disponible;
            videoClub.AnhadirPelicula(pelTemp);

            pelTemp = new Pelicula("Erase una vez Hollywood", "33333333", "Quentin Tarantino");
            pelTemp.Actor = listActores[1];
            pelTemp.Estado = Estados.Disponible;
            videoClub.AnhadirPelicula(pelTemp);

            pelTemp = new Pelicula("1917", "44444444", "Sam Mendes");
            pelTemp.Actor = listActores[2];
            pelTemp.Estado = Estados.Disponible;
            videoClub.AnhadirPelicula(pelTemp);

            pelTemp = new Pelicula("El irlandes", "55555555", "Martin Scorsese");
            pelTemp.Actor = listActores[2];
            pelTemp.Estado = Estados.Disponible;
            videoClub.AnhadirPelicula(pelTemp);

            pelTemp = new Pelicula("Vengadores: Endgame", "66666666", "Anthony Russo");
            pelTemp.Actor = listActores[0];
            pelTemp.Estado = Estados.Disponible;
            videoClub.AnhadirPelicula(pelTemp);

            CargarDatosListBox();
        }
        /// <summary>
        /// Ponemos las peliculas del videoClub actual en la lista
        /// </summary>
        public void CargarDatosListBox()
        {
            foreach(Pelicula pel in videoClub.ListaPeliculas)
            {
                string[] data = pel.ArrayData();
                ListViewItem item = new ListViewItem(data[0]);
                for(int i=1; i < data.Length; i++)
                {
                    item.SubItems.Add(data[i]);
                }
                listViewPeliculasVideoClub.Items.Add(item);
            }
        }
        /// <summary>
        /// Lismpiamos la lista recargamos las peliculas
        /// </summary>
        public void RecargarListView()
        {
            listViewPeliculasVideoClub.Items.Clear();
            CargarDatosListBox();
        }
        /// <summary>
        /// Controlamos el codigo del videoClub
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectCodigoVideoClub_Paint(object sender, PaintEventArgs e)
        {
            bool nuevo = true;
            if (selectCodigoVideoClub.Text.Length == 5)
            {
                if (VideoClub.ComprobarCodigo(selectCodigoVideoClub.Text))
                {
                    if (selectCodigoVideoClub.Text == videoClub.Codigo)
                    {
                        RecargarListView();
                    }
                    else
                    {
                        foreach (VideoClub video in listaVideoClubs)
                        {
                            if (video.Codigo == selectCodigoVideoClub.Text)
                            {
                                videoClub = video;
                                RecargarListView();
                                nuevo = false;
                                break;
                            }
                        }
                        if (nuevo)
                        {
                            VideoClub nuevoVideoClub = new VideoClub(selectCodigoVideoClub.Text);
                            listaVideoClubs.Add(nuevoVideoClub);
                            videoClub = nuevoVideoClub;
                            RecargarListView();
                        }
                    }
                }
                else if (!VideoClub.ComprobarCodigo(selectCodigoVideoClub.Text))
                {
                    MessageBox.Show("Compruebe el codigo del VideoClub introducido.");
                }
            }
        }
        #endregion

        #region Implementacion interfaz
        /// <summary>
        /// Fuincion implementada de la interfaz entre formularios
        /// </summary>
        /// <param name="recVideoClub"></param>
        public void EstablecerCambiosPelicula(Pelicula recibidaPelicula, int indice)
        {
            if(indice != -1)
            {

                this.videoClub.ListaPeliculas[indice] = recibidaPelicula;
            }
            else
            {
                this.videoClub.ListaPeliculas.Add(recibidaPelicula);
            }
        }
        /// <summary>
        /// Funcion implementada de la interfaz entre formularios
        /// </summary>
        /// <returns></returns>
        public VideoClub RecuperarVideoclub()
        {
            return this.videoClub;
        }
        #endregion

    }
}

