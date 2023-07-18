using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryParcialBallesteros2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        } 
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmRegistro nuevo = new FrmRegistro();
            nuevo.Show();
        }
         

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLista listin = new FrmLista();
            listin.Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
        }

        private void fabricaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            this.Hide();
            FrmPedidos frmPedidos = new FrmPedidos();   
            frmPedidos.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmpedidoCliente frmCliente = new FrmpedidoCliente();
            frmCliente.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaPedidos lista = new FrmListaPedidos();
            lista.Show();
            
        }
    }
}
 
 
 
 
 