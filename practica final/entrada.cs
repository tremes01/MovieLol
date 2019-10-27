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
            txtResena.Text = newSala[0].peli.resena;
            txtDisponible.Text = newSala[0].cantUser.ToString();


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
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                 new Pelicula(
                id: 2,
                nombre:"Im a Mother",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                  new Pelicula(
                id: 3,
                nombre:"Alita",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                   new Pelicula(
                id: 4,
                nombre:"Joker",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                    new Pelicula(
                id: 1,
                nombre:"Interestelar",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                 new Pelicula(
                id: 2,
                nombre:"Im a Mother",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                  new Pelicula(
                id: 3,
                nombre:"Alita",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),
                   new Pelicula(
                id: 4,
                nombre:"Joker",
                precio:235.00,
                resena:"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

                ),

        };
            //foreach (var item in listadoPelis)
            //{
                newSala[0] = new Sala("Sala 1", 0, listadoPelis[0]);
            //}

            

        }
        void ViewInfo()
        {
            
        }

        Pelicula newPeli;
        Sala [] newSala;
        List<Pelicula> listadoPelis;
    }
}
