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
    public partial class FrmGestionFinanciera : Form
    {
        private Form FormularioActual;
        public FrmGestionFinanciera()
        {
            InitializeComponent();
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

        private void btnFactura_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmFactura());
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmNominas());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
