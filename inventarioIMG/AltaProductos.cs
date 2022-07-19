using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventarioIMG
{
    public partial class AltaProductos : Form
    {
        BD.BDProducto producto = new BD.BDProducto();

        public AltaProductos()
        {
            InitializeComponent();
        }

        private void AltaProductos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.AgregarProducto(textnombre.Text, textcategoria.Text,textprecio.Text,textcantidad.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AltaProductos_Load_1(object sender, EventArgs e)
        {
            producto.MostrarProductos(dataGridView1);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
