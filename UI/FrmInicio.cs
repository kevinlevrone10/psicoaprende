using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            //this.LoadForm(new FrmEstudiante());
        }

        private void btnMaestros_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmMaestro());
        }

        private void btnSesiones_Click(object sender, EventArgs e)
        {
            //this.LoadForm(new FrmSesiones());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        //private void LoadForm(Form child)
        //{
        //    //Asignar el nuevo formulario a desplegar
        //    if (FrmActivo == null)
        //    {
        //        FrmActivo = (Form)child;
        //        FrmActivo.TopLevel = false;
        //        FrmActivo.Dock = DockStyle.Fill;
        //        pnlContenedor.Controls.Add(FrmActivo);
        //        pnlContenedor.Tag = FrmActivo;
        //        FrmActivo.Show();
        //    }
        //}
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

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void pnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
