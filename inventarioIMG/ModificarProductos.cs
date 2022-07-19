using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventarioIMG
{
    public partial class ModificarProductos : Form
    {
        BD.BDProducto producto = new BD.BDProducto();

        public ModificarProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModificarProductos_Load(object sender, EventArgs e)
        {
            producto.VerProductos(cmbprod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.ModificarProductos(textproducto.Text, textcategoria.Text, textprecio.Text, textstock.Text, cmbprod);
        }


    }
}
