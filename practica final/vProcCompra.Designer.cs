namespace practica_final
{
    partial class vProcCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.txtprecio2 = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.Label();
            this.txtdispon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.AutoSize = true;
            this.txtprecio.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(347, 130);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(53, 19);
            this.txtprecio.TabIndex = 4;
            this.txtprecio.Text = "Precio: ";
            this.txtprecio.Click += new System.EventHandler(this.txtprecio_Click);
            // 
            // txtSala
            // 
            this.txtSala.AutoSize = true;
            this.txtSala.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtSala.Location = new System.Drawing.Point(344, 25);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(63, 32);
            this.txtSala.TabIndex = 6;
            this.txtSala.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(140, -73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de la pelicula";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(65, 25);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(247, 278);
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = " 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = " Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = " Descuento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = " Total:";
            this.label4.Click += new System.EventHandler(this.txtprecio_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::practica_final.Properties.Resources.error;
            this.pictureBox10.Location = new System.Drawing.Point(609, 12);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 12;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // txtprecio2
            // 
            this.txtprecio2.AutoSize = true;
            this.txtprecio2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio2.Location = new System.Drawing.Point(438, 132);
            this.txtprecio2.Name = "txtprecio2";
            this.txtprecio2.Size = new System.Drawing.Size(53, 19);
            this.txtprecio2.TabIndex = 4;
            this.txtprecio2.Text = "Precio: ";
            this.txtprecio2.Click += new System.EventHandler(this.txtprecio_Click);
            // 
            // txtdescuento
            // 
            this.txtdescuento.AutoSize = true;
            this.txtdescuento.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescuento.Location = new System.Drawing.Point(438, 166);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(21, 19);
            this.txtdescuento.TabIndex = 4;
            this.txtdescuento.Text = " 0";
            // 
            // txttotal
            // 
            this.txttotal.AutoSize = true;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(438, 205);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(45, 19);
            this.txttotal.TabIndex = 4;
            this.txttotal.Text = " Total:";
            this.txttotal.Click += new System.EventHandler(this.txtprecio_Click);
            // 
            // txtdispon
            // 
            this.txtdispon.AutoSize = true;
            this.txtdispon.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdispon.Location = new System.Drawing.Point(564, 264);
            this.txtdispon.Name = "txtdispon";
            this.txtdispon.Size = new System.Drawing.Size(0, 19);
            this.txtdispon.TabIndex = 5;
            // 
            // vProcCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(653, 352);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecio2);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdispon);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vProcCompra";
            this.Text = "vProcCompra";
            this.Load += new System.EventHandler(this.vProcCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtprecio;
        private System.Windows.Forms.Label txtSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label txtprecio2;
        private System.Windows.Forms.Label txtdescuento;
        private System.Windows.Forms.Label txttotal;
        private System.Windows.Forms.Label txtdispon;
    }
}