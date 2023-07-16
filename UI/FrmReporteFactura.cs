using Microsoft.Reporting.WinForms;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmReporteFactura : Form
    {
        private Form FormularioActual;
        public FrmReporteFactura()
        {
            InitializeComponent();
        }
        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {

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
            //pnlContenedor.Controls.Add(NuevoFormulario);
            //pnlContenedor.Tag = NuevoFormulario;
            NuevoFormulario.BringToFront();
            NuevoFormulario.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int anio = int.Parse(textBoxAnio.Text);

            Factura factura = new Factura();
            List<dynamic> datosFacturas = factura.ObtenerTotalFacturasPorMes(anio);

            List<dynamic> Ingresos = factura.ObtenerTotalFacturasPorAño(anio);

            List<dynamic> Egresos = factura.obtenerEgresos(anio);

            List<dynamic> ganancias = factura.CalcularGanancias(anio);



            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Facturas", datosFacturas));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Total", Ingresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Egresos", Egresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Ganancias", ganancias));

            reportViewer1.RefreshReport();
        }

        private void textBoxAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si no es un número
            }
        }
    }
}
