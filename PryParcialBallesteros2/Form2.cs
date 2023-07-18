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
    public partial class FrmRegistro : Form
    {

        string[,] matriz = new string[100, 5];



        public FrmRegistro()
        {
            InitializeComponent();
        }
        public static class DatosCompartidos
        {
            public static string[,] matriz = new string[100, 5];
        }
        public void RecibirMatriz(string[,] matrizRecibida)
        {
            matriz = matrizRecibida;
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

            TxtNombre.KeyPress += TxtNombre_KeyPress;
            TxtApellido.KeyPress += TxtApellido_KeyPress;
            TxtDireccion.KeyPress += TxtDireccion_KeyPress;
            TxtTelefono.KeyPress += TxtTelefono_KeyPress;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                TxtApellido.Focus();
               
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtDireccion.Focus();
                e.Handled = true;
               
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtTelefono.Focus();
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnGuardar.Focus();
                e.Handled = true;
                BtnGuardar.PerformClick();
            }
        }
       

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLista frmLista = new FrmLista();
            frmLista.RecibirMatriz(matriz);

           
            frmLista.Show();
            this.Hide();
        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string direccion = TxtDireccion.Text;
            string telefono = TxtTelefono.Text;

           
            int filaVacia = -1;
            for (int i = 0; i < 100; i++)
            {
                if (matriz[i, 0] == null)
                {
                    filaVacia = i;
                    break;
                }
            }

          
            if (filaVacia != -1)
            {
                matriz[filaVacia, 0] = nombre;
                matriz[filaVacia, 1] = apellido;
                matriz[filaVacia, 2] = direccion;
                matriz[filaVacia, 3] = telefono;
            }
            else
            {
                MessageBox.Show("No hay filas disponibles en la matriz para guardar los datos.");
            }
            DatosCompartidos.matriz = matriz;


            


            LimpiarCampos();
            TxtNombre.Focus();
        
       

            

            
        }

        private void LimpiarCampos()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtDireccion.Clear();
            TxtTelefono.Clear();
        }

        private void fabrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPedidos pedidos = new FrmPedidos();
            pedidos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmpedidoCliente cliente = new FrmpedidoCliente();
            cliente.Show();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstadistica estadistica = new FrmEstadistica();
            estadistica.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListaPedidos lista = new FrmListaPedidos();
            lista.Show();
        }
    }
}
