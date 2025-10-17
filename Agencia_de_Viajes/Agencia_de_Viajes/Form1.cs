using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destino destino = new Destino();
            destino.ShowDialog();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ofertas ofertas = new Ofertas();
            ofertas.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.ShowDialog();
        }
    }
}
