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
    public partial class FrmpedidoCliente : Form
    {
        string[,] matrizPedidos = new string[100, 4];
        public FrmpedidoCliente()
        {
            InitializeComponent();
        }

        public static class DatosCompartidos
        {
            public static string[,] matriz = new string[100, 4];
        }
        public void RecibirMatriz(string[,] matriz)
        {
            matrizPedidos = matriz;
          
        }

        private void FrmpedidoCliente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnHacerPedido_Click(object sender, EventArgs e)
        {

            string tipoTornillo = LstTipo.SelectedItem?.ToString();
            string medida = LstMedida.SelectedItem?.ToString();
            int cantidad = (int)NudCantidad.Value;
            string nombre = TxtNombre.Text;

            
            int filaVacia = -1;
            for (int i = 0; i < 100; i++)
            {
                if (matrizPedidos[i, 0] == null)
                {
                    filaVacia = i;
                    break;
                }
            }
            if (filaVacia != -1)
            {
                matrizPedidos[filaVacia, 0] = nombre;
                matrizPedidos[filaVacia, 1] = tipoTornillo;
                matrizPedidos[filaVacia, 2] = medida;
                matrizPedidos[filaVacia, 3] = cantidad.ToString();
               
            }
            else
            {
                MessageBox.Show("No hay filas disponibles en la matriz para guardar los datos.");
            }


            LimpiarFormulario();
            MessageBox.Show($"Pedido de {tipoTornillo} ({medida}) realizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            

        }
        private void LimpiarFormulario()
        {
            LstTipo.SelectedIndex = -1;
            LstMedida.SelectedIndex = -1; 
            NudCantidad.Value = 0;
            TxtNombre.Clear();

        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaPedidos frmListaPedidos = new FrmListaPedidos();
            frmListaPedidos.RecibirMatriz(matrizPedidos);
            frmListaPedidos.Show();
            this.Hide();
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmpedidoCliente frmCliente = new FrmpedidoCliente();
            frmCliente.Show();
        }
    }
}
