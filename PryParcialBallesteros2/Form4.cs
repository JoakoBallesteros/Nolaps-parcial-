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
    public partial class FrmLista : Form
    {
        private string[,] matrizRecibida;

        public FrmLista()
        {
            InitializeComponent();
            DgvLista.Columns.Add("Nombre", "Nombre");
            DgvLista.Columns.Add("Apellido", "Apellido");
            DgvLista.Columns.Add("Dirección", "Dirección");
            DgvLista.Columns.Add("Teléfono", "Teléfono");
        }
        private void FrmLista_Load(object sender, EventArgs e)
        {

        }   

        public void RecibirMatriz(string[,] matriz)
        {
            matrizRecibida = matriz;


            for (int i = 0; i < 100; i++)
            {
                if (DatosCompartidos.matriz[i, 0] != null)
                {
                    DgvLista.Rows.Add(DatosCompartidos.matriz[i, 0], DatosCompartidos.matriz[i, 1], DatosCompartidos.matriz[i, 2], DatosCompartidos.matriz[i, 3]);
                }
            }
        }
        public void SetDataGridViewData(int[,] matriz)
        {

        }

        private void DgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.RecibirMatriz(DatosCompartidos.matriz); 
            frmRegistro.Show();
            this.Close();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fabricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos pedidos = new FrmPedidos();
            pedidos.Show();
            this.Hide();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
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
