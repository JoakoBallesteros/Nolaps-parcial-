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
    public partial class FrmSesion : Form
    {
        public FrmSesion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            TxtUsuario.KeyPress += TxtUsuario_KeyPress;
            TxtContraseña.KeyPress += TxtContraseña_KeyPress;

            this.ActiveControl = TxtUsuario;
        }

        private void BtnSesion_Click(object sender, EventArgs e)
        {

            int ContraseñaValida = 1234;
            string UsuarioValido = "rosario";
            string UsuarioIngresado = TxtUsuario.Text;
            int ContraseñaIngresada;

            bool esContraseñaValida = int.TryParse(TxtContraseña.Text, out ContraseñaIngresada);

            if (ContraseñaValida == ContraseñaIngresada && UsuarioValido == UsuarioIngresado)
            {
                this.Hide();
                FrmMenu menu = new FrmMenu();
                menu.Show();
            }
            else if (!esContraseñaValida && UsuarioValido != UsuarioIngresado)
            {
                MessageBox.Show("Usuario y contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UsuarioValido != UsuarioIngresado)
            {
                MessageBox.Show("Usuario incorrecto", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ContraseñaValida != ContraseñaIngresada)
            {
                MessageBox.Show("Contraseña incorrecta", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                TxtContraseña.Focus();
                e.Handled = true;
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnSesion.Focus();

                BtnSesion.PerformClick();

                e.Handled = true;
            }
        }
    }
}


