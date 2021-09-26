using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partes_de_coches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Partes_de_coches partes = new Partes_de_coches();
            partes.PCname = txbnombre.Text;
            partes.PCmarca = txbmarca.Text;
            partes.PCprecio = txbprecio.Text;

            lb1.Items.Add(partes.PCname + ", " + partes.PCmarca + ", $" + partes.PCprecio);
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
