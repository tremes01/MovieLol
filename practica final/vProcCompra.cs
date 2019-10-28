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
        public vProcCompra(PictureBox pict,string sala, string precio, int disponibles, frmentrada frm)
        {
            InitializeComponent();
            pictureBox9.Image = pict.Image;
            txtSala.Text = sala;
            txtprecio2.Text = precio;
            v = frm;
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
            int cantidad = (string.IsNullOrWhiteSpace(textBox1.Text) ? 1 : int.Parse(textBox1.Text));
            float precio = float.Parse(txtprecio2.Text);
            txttotal.Text = (cantidad * precio).ToString();

            if (cantidad > 1 && cantidad < 3) txtdescuento.Text = (float.Parse(txttotal.Text) * 0.15).ToString();



        }

        private void vProcCompra_Load(object sender, EventArgs e)
        {
            var valor = int.Parse(textBox1.Text) * int.Parse(txtprecio2.Text);
            txttotal.Text = valor.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult eleccion = MessageBox.Show("Quiere realizar el pago?", "Finalizando!", MessageBoxButtons.YesNo); 
            if(eleccion == DialogResult.Yes)
            {
                this.Close();
                v.nuevoDisponibles = int.Parse(textBox1.Text);
            }
        }

        frmentrada v;
    }
}
