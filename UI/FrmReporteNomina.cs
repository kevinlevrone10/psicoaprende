using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmReporteNomina : Form
    {
        public FrmReporteNomina()
        {
            InitializeComponent();
        }

        private void FrmReporteNomina_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener la fecha de pago seleccionada en el DatePicker

            int inicioYear = dateTimePicker1.Value.Year;
            int inicioMonth = dateTimePicker1.Value.Month;
            int inicioDay = dateTimePicker1.Value.Day;
            DateTime fechaPago = new DateTime(inicioYear, inicioMonth, inicioDay);

            // Crear una instancia de la clase NominasReporte
            Nomina nominasReporte = new Nomina();

            // Obtener los detalles de la nómina por fecha de pago
            List<dynamic> detallesNomina = nominasReporte.ObtenerDetallesNominaPorFechaPago(fechaPago);
            List<dynamic> Nominas = nominasReporte.obtenerNominaporFecgaPago(fechaPago);

            // Crear un origen de datos para el informe

            ReportDataSource nomina = new ReportDataSource("Nomina", Nominas);
            ReportDataSource Detalles = new ReportDataSource("DetalleNomina", detallesNomina);

            // Asignar el origen de datos al informe
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(nomina);
            reportViewer1.LocalReport.DataSources.Add(Detalles);


            // Actualizar el informe
            reportViewer1.RefreshReport();
        }
    }
}
