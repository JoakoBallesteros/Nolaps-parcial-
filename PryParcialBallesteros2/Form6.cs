using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryParcialBallesteros2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {

        }

       

        private void BtnHacerPedido_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Pedido hecho", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmMenu menu = new FrmMenu();
            menu.Show();

            this.Hide();

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistro register = new FrmRegistro();
            register.Show();
            this.Hide();
        }

        private void LstMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            LstProovedor.Items.Clear();

            if (LstMaterial.SelectedIndex == 0)
               

            {
                LstProovedor.Items.Add("Aceros Inoxidables S.A.");
                LstProovedor.Items.Add("Aceros S.A.");
                
            }
            else if (LstMaterial.SelectedIndex == 1) 
            {
                LstProovedor.Items.Add("Aceros Camesa");
                LstProovedor.Items.Add("Aceros Alesa");
                
            }
            else if (LstMaterial.SelectedIndex == 2) 
            {
                LstProovedor.Items.Add("Aluminio y Metales S.A");
                LstProovedor.Items.Add("Aluminio Argentina");
                
            }

            else if (LstMaterial.SelectedIndex == 3)
            {
                LstProovedor.Items.Add("Cometal");
                LstProovedor.Items.Add("Laminación San Luis");

            }
            else if (LstMaterial.SelectedIndex == 4)
            {
                LstProovedor.Items.Add("Aluar Aluminio Argentino S.A.I.C.");
                LstProovedor.Items.Add("Aluminio Buenos Aires");

            }
            else if (LstMaterial.SelectedIndex == 5)
            {
                LstProovedor.Items.Add("Fundición Siderca");
                LstProovedor.Items.Add("Fergusa");

            }
            else if (LstMaterial.SelectedIndex == 6)
            {
                LstProovedor.Items.Add("Fundición San Cayetano");
                LstProovedor.Items.Add("FV Fundiciones Versalles");

            }
            else if (LstMaterial.SelectedIndex == 7)
            {
                LstProovedor.Items.Add("Fundición San Cayetano");
                LstProovedor.Items.Add("FV Fundiciones Versalles");

            }



          
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLista listin = new FrmLista();
            listin.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmpedidoCliente frmCliente = new FrmpedidoCliente();
            frmCliente.Show();
        }

        private void fabricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaPedidos lista = new FrmListaPedidos();
            lista.Show();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
        }
    }
}
