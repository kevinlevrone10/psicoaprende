using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using SistemaPsicoaprende.Negocio;
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
    public partial class FrmListadoFacturas : Form
    {
        private Form FormularioActual;
        public FrmListadoFacturas()
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

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {
            Listado();
        }

        public void Listado()
        {
            CtrlFactura fac = new CtrlFactura();

            foreach (var factura in fac.Listado())
            {
                string fechaFormateada = factura.fechaFactura.ToString("dd/MM/yyyy");
                dataGridView1.Rows.Add(factura.codigoFactura, fechaFormateada, factura.costoTotal, factura.estadoSesiones);
            }
        }
        private void MostrarFacturaEnDataGridView(Facturas factura)
        {
            dataGridView1.Rows.Clear();

            string fechaFormateada = factura.fecha_Factura.ToString("dd/MM/yyyy");
            dataGridView1.Rows.Add(factura.cod_Factura, fechaFormateada, factura.costoTotal_Factura, factura.EstadoSesiones);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoFacturaBusqueda = txtBuscar.Text; // Obtener el código de factura ingresado en el TextBox

            if (!string.IsNullOrEmpty(codigoFacturaBusqueda)) // Verificar si se ingresó un código de factura válido
            {
                Facturas facturaBuscada = CtrlFactura.facturas(codigoFacturaBusqueda);

                if (facturaBuscada != null)
                {
                    MostrarFacturaEnDataGridView(facturaBuscada);
                }
                else
                {
                    MessageBox.Show("No se encontró la factura con el código ingresado.", "Factura no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de factura.", "Código de factura vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
