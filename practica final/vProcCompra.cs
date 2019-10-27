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
    public partial class vProcCompra : Form
    {
        public vProcCompra(PictureBox pict,string sala, string txtprecio2, string txtdescuento)
        {
            InitializeComponent();
            pictureBox9.Image = pict.Image;
        }

        private void txtprecio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
