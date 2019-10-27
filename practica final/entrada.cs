using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_final
{
    public partial class frmentrada : Form
    {
        public frmentrada()
        {
            InitializeComponent();
        }

        private void frmentrada_Load(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox1.Image;
            tabControl1.SelectedIndex = 1;
            uploadInfo();
            txtSala.Text = newSala[0].nombre;
            txtprecio.Text += newSala[0].peli.precio.ToString();
            txtResena.Text += newSala[0].peli.resena;
            txtDisponible.Text += newSala[0].cantUser.ToString();


        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox2.Image;
            tabControl1.SelectedIndex = 1;
            
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox3.Image;
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox4.Image;
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox5.Image;
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox6.Image;
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox7.Image;
            tabControl1.SelectedIndex = 1;
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox8.Image;
            tabControl1.SelectedIndex = 1;
        }

        void uploadInfo()
        {
            //Cargar peliculas
            listadoPelis = new List<Pelicula>()
            {
                new Pelicula(
                id: 1,
                nombre:"Interestelar",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                 new Pelicula(
                id: 2,
                nombre:"Im a Mother",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                  new Pelicula(
                id: 3,
                nombre:"Alita",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                   new Pelicula(
                id: 4,
                nombre:"Joker",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                    new Pelicula(
                id: 1,
                nombre:"Interestelar",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                 new Pelicula(
                id: 2,
                nombre:"Im a Mother",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                  new Pelicula(
                id: 3,
                nombre:"Alita",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),
                   new Pelicula(
                id: 4,
                nombre:"Joker",
                precio:235.00,
                resena:"Lorem Ipsum es simplemente el texto de relleno de las imprentas y archivos de texto. Lorem Ipsum ha sido el texto de relleno estándar de las industrias desde el año 1500, cuando un impresor (N. del T. persona que se dedica a la imprenta) desconocido usó una galería de textos y los mezcló de tal manera que logró hacer un libro de textos especimen. No sólo sobrevivió 500 años, sino que tambien ingresó como texto de relleno en documentos electrónicos, quedando esencialmente igual al original. Fue popularizado en los 60s con la creación de las hojas  las cuales contenian pasajes de Lorem Ipsum, y más recientemente con software de autoedición, como por ejemplo Aldus PageMaker, el cual incluye versiones de Lorem Ipsum."

                ),

        };
            //foreach (var item in listadoPelis)
            //{
            int i = 0;
            foreach (var item in listadoPelis)
            {

                newSala[i] = new Sala("Sala " + i, 15, item);
                i++;
            }
                
            //}

            

        }
      

        Sala [] newSala = new Sala[8];
        List<Pelicula> listadoPelis;
    }
}
