using System;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmInicio : Form
    {
        private Form FormularioActual;
        public FrmInicio()
        {
            InitializeComponent();
            //FormularioActual = null;
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmEstudiantes());
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmTrabajadores());
        }

        private void btnSesiones_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmSesiones());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmInicio home = new FrmInicio();
            home.Show();
        }

        private void LoadForm(Form NuevoFormulario)
        {
            //Verifica si existe un formulario activo
            if (FormularioActual != null)

                //Configurar vuevo formulario
                FormularioActual.Close();
            FormularioActual = NuevoFormulario;
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            NuevoFormulario.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(NuevoFormulario);
            pnlContenedor.Tag = NuevoFormulario;
            NuevoFormulario.BringToFront();
            NuevoFormulario.Show();
        }
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString(); ;
        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestionFinaciera_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmGestionFinanciera());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLogin login = new FrmLogin();
            login.Show(); 
        }
    }
}
