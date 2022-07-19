using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventarioIMG
{
    public partial class BajaProductos : Form
    {
        BD.BDProducto producto = new BD.BDProducto();

        public BajaProductos()
        {
            InitializeComponent();
        }

        private void BajaProductos_Load(object sender, EventArgs e)
        {
            producto.VerProductos(cmbProducto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.BajaProductos(cmbProducto);
            producto.VerProductos(cmbProducto);
        }
    }
}
