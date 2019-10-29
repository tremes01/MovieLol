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

        /*Evento Load usado para inicializar valores por defecto al iniciar la ventana.*/
        private void frmentrada_Load(object sender, EventArgs e)
        {
            panelCompra.Visible = false;
            for (int i = 1; i < 16; i++) txtcantidad.Items.Add(i);
            uploadInfo();

        }

        /*Evento double Click , el cual nos permite cargar los datos en la siguiente ventana o tabPage*/
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox1.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[0].nombre;
            txtprecio.Text = newSala[0].peli.precio.ToString();
            txtResena.Text += newSala[0].peli.resena;
            txtDisponible.Text = newSala[0].cantUser.ToString();


        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox2.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[1].nombre;
            txtprecio.Text = newSala[1].peli.precio.ToString();
            txtResena.Text += newSala[1].peli.resena;
            txtDisponible.Text = newSala[1].cantUser.ToString();

        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox3.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[2].nombre;
            txtprecio.Text = newSala[2].peli.precio.ToString();
            txtResena.Text += newSala[2].peli.resena;
            txtDisponible.Text = newSala[2].cantUser.ToString();
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox4.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[3].nombre;
            txtprecio.Text = newSala[3].peli.precio.ToString();
            txtResena.Text += newSala[3].peli.resena;
            txtDisponible.Text = newSala[3].cantUser.ToString();
        }

        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox5.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[4].nombre;
            txtprecio.Text = newSala[4].peli.precio.ToString();
            txtResena.Text += newSala[4].peli.resena;
            txtDisponible.Text = newSala[4].cantUser.ToString();
        }

        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox6.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[5].nombre;
            txtprecio.Text = newSala[5].peli.precio.ToString();
            txtResena.Text += newSala[5].peli.resena;
            txtDisponible.Text = newSala[5].cantUser.ToString();
        }

        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox7.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[6].nombre;
            txtprecio.Text = newSala[6].peli.precio.ToString();
            txtResena.Text += newSala[6].peli.resena;
            txtDisponible.Text = newSala[6].cantUser.ToString();
        }

        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox8.Image;
            tabControl1.SelectedIndex = 1;
            lb2.Text = newSala[7].nombre;
            txtprecio.Text = newSala[7].peli.precio.ToString();
            txtResena.Text += newSala[7].peli.resena;
            txtDisponible.Text = newSala[7].cantUser.ToString();
        }

        /*metodo que nos ayudara a cargar todos los datos a las clases creadas, digase peliculas y las peliculas a sus respectivas salas.*/
        void uploadInfo()
        {
            //Cargar peliculas
            //List para almacenar las peliculas
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
            //foreach para cargar cada pelicula en sus respectiva sala.
            foreach (var item in listadoPelis)
            {

                newSala[i] = new Sala(i.ToString(), 15, item);
                i++;
            }

            //}



        }


        Sala[] newSala = new Sala[8]; //array para la clase Sala, asi tenemos una sala para cada pelicula. //lista de objetos tipo Sala
        List<Pelicula> listadoPelis; //Lista generica de tipo Pelicula, en este caso*

        //con este evento click iniciamos el contenedor del panel de compras
        private void button1_Click(object sender, EventArgs e)
        {
            panelCompra.Visible = true; //hacemos visible el panel
            panelCompra.Enabled = true; //activamos sus manipulacion
            //llenamos los datos
            txttotal.Text = txtprecio.Text;
            precioF.Text = txtprecio.Text;
        }

       

        public int nuevoDisponibles;

        private void frmentrada_Shown(object sender, EventArgs e)
        {
           ///NADA
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            int Sala = int.Parse(lb2.Text); //sala actual
            var cantidad = (string.IsNullOrWhiteSpace(txtcantidad.Text) ? 1 : int.Parse(txtcantidad.Text)); //con el operador condiciona validamos el campo cantidad y pasamos segun lo qe tenga, si esta vacio es decir no selecciono nada, enviara un 1 , de lo contrario el valor seleccionado.
            string mensaje = $"Desea comprar {cantidad} boletos?"; //mensaje para validar la confrmacion 
            DialogResult select = MessageBox.Show(mensaje,"Cierre de compra",MessageBoxButtons.YesNo,MessageBoxIcon.Question); //Caja de mensaje para confirmar y segun la eleccion la condicion a continuacion determinara que se hara.
            if(select == DialogResult.Yes) //si nuestra eleecion dentro de la caja de mensaje es YES, pues realizara las siguientes acciones.
            {
                panelCompra.Visible = false;
                if (newSala[Sala].cantUser > 0)
                {
                    newSala[Sala].cantUser = newSala[Sala].cantUser - cantidad;
                    txtDisponible.Text = newSala[Sala].cantUser.ToString();
                    txtcantidad.Items.Clear();
                    txtcantidad.Text = "";

                }
                else
                {
                    MessageBox.Show("No quedan acientos disponibles!");
                }
            }
            

            for (int i = 1; i <= newSala[Sala].cantUser; i++) txtcantidad.Items.Add(i); //for loop para cargar el comboBox de cqntidad en funcion al numero restante de acientos.


        }
        //cada vez que cambiemos la eleeccion del comboBox mostrara si hay un descuento , si elegimos el numero 1 o dejamos vacio, no se aplica pero si es superior a 1 entonces le aplica und escuento del 0.20%

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var cantidad = (string.IsNullOrWhiteSpace(txtcantidad.Text) ? 1 : int.Parse(txtcantidad.Text));
            var precio = int.Parse(txtprecio.Text);
            var descuento = (cantidad * precio) * 0.20;
            var total = cantidad * precio;
            if (!string.IsNullOrEmpty(txtcantidad.Text) && !string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                if (cantidad > 1)
                {
                    txtdescuento.Text = descuento.ToString();
                    var totalResultado = total - descuento;
                    txttotal.Text = totalResultado.ToString();

                }
                else
                {
                    txtdescuento.Text = 0.ToString();
                    txttotal.Text = txtprecio.Text;
                }
            }
        }

        private void frmentrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
