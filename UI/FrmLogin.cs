using SistemaPsicoaprende.Negocio;
using SistemaPsicoaprende.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPsicoaprende
{
    public partial class FrmLogin : Form
    {
        private Login login;
        public FrmLogin()
        {
            InitializeComponent();
            login = new Login();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomUsuario = txtNomUsuario.Text;
            string password = txtContra.Text;

            bool credencialesValidas = login.ValidarCredenciales(nomUsuario, password);

            if (credencialesValidas)
            {
                // Inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes realizar la navegación a la siguiente ventana o realizar otras acciones necesarias
                txtNomUsuario.Clear(); txtContra.Clear();
                FrmInicio ventanaMenu = new FrmInicio();
                ventanaMenu.Show();
                this.Hide();
            }
            else
            {
                // Credenciales inválidas
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                txtNomUsuario.Clear(); txtContra.Clear();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
