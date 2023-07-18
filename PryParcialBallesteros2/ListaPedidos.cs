using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PryParcialBallesteros2.FrmRegistro;

namespace PryParcialBallesteros2
{
    public partial class FrmListaPedidos : Form
    {
        private string[,] matrizPedidos;

        public FrmListaPedidos()
        {
            InitializeComponent();
            DgvPedidos.Columns.Add("Nombre", "Nombre");
            DgvPedidos.Columns.Add("Tipo de Tornillo/Roscado", "Tipo de Tornillo/Roscado");
            DgvPedidos.Columns.Add("Medidas", "Medidas");
            DgvPedidos.Columns.Add("Cantidad", "Cantidad");
        }
        public void RecibirMatriz(string[,] matriz)
        {
            matrizPedidos = matriz;

            SetDataGridViewData(matrizPedidos);
        }

        private void FrmListaPedidos_Load(object sender, EventArgs e)
        {

        }
       


        public void SetDataGridViewData(string[,] matriz)
        {
            DgvPedidos.Rows.Clear();

            for (int i = 0; i < 100; i++)
            {
                if (matriz[i, 0] != null)
                {
                    DgvPedidos.Rows.Add(matriz[i, 0], matriz[i, 1], matriz[i, 2], matriz[i, 3]);
                }
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmpedidoCliente cliente = new FrmpedidoCliente();
            cliente.RecibirMatriz(matrizPedidos); 
            cliente.Show();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistro nuevo = new FrmRegistro();
            nuevo.Show();

        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLista listin = new FrmLista();
            listin.Show();
        }

        private void fabricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
        }
    }
}
