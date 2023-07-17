using Microsoft.Reporting.WinForms;
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
    public partial class FrmReporteFactura : Form
    {
        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
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
