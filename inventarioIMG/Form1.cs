using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventarioIMG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaProductos AltaProductos = new AltaProductos();
            AltaProductos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaProductos BajaProductos = new BajaProductos();
            BajaProductos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarProductos ModificarProductos = new ModificarProductos();
            ModificarProductos.ShowDialog();
        }
    }
}
