using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmNominas : Form
    {
        public FrmNominas()
        {
            InitializeComponent();
        }

        private void FrmNominas_Load(object sender, EventArgs e)
        {

        }

        public void ListarNominas()
        {
            int inicioYear = dateTimePickerPagoDesde.Value.Year;
            int inicioMonth = dateTimePickerPagoDesde.Value.Month;
            int inicioDay = dateTimePickerPagoDesde.Value.Day;
            DateTime inicio = new DateTime(inicioYear, inicioMonth, inicioDay);

            int finalYear = dateTimePickerPagoHasta.Value.Year;
            int finalMonth = dateTimePickerPagoHasta.Value.Month;
            int finalDay = dateTimePickerPagoHasta.Value.Day;
            DateTime final = new DateTime(finalYear, finalMonth, finalDay);
            dataGridView1.Rows.Clear();

            if (int.TryParse(txtcost.Text, out int valorMultiplicador) && float.TryParse(txtvia.Text, out float viatico))
            {
                decimal totalNomina = 0;
                foreach (dynamic nominas in CtrlNomina.filtradohoras(inicio, final))
                {
                    int horas = nominas.HorasTrabajadas * valorMultiplicador;
                    int total = (int)viatico; // Sumar el viático al total de horas trabajadas

                    int salario = horas + total;

                    dataGridView1.Rows.Add(nominas.NombreTrabajador, nominas.HorasTrabajadas, horas, total, salario);

                    totalNomina += salario;
                }

                txttol.Text = totalNomina.ToString();


            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos en los TextBox.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Realizar los cálculos y actualizar el DataGridView
            ListarNominas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos necesarios para la nómina
            DateTime pagoDesde = dateTimePickerPagoDesde.Value;
            DateTime pagoHasta = dateTimePickerPagoHasta.Value;
            DateTime fechaPago = dateTimePickerFechaPago.Value;

            // Crear una instancia de la nómina
            Nomina nomina = new Nomina(pagoDesde, pagoHasta, fechaPago);

            // Crear una lista de detalles de la nómina
            List<DetalleNominas> detalles = new List<DetalleNominas>();

            // Obtener los detalles de la nómina y agregarlos a la lista
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int horasTrabajadas = Convert.ToInt32(row.Cells["horas"].Value);
                decimal total = Convert.ToDecimal(row.Cells["total"].Value);
                decimal viaticos = Convert.ToDecimal(row.Cells["viatico"].Value);




                // Crear un objeto DetalleNomina y asignar el ID de la nómina
                DetalleNominas detalle = new DetalleNominas
                {
                    total_Horas = horasTrabajadas,
                    total = total,
                    viaticos = viaticos,
                    salario_Neto = (double)((Convert.ToDecimal(total) + viaticos))
                };

                detalles.Add(detalle);
            }

            // Llamar al método AgregarNomina de la instancia de Nomina
            int resultado = nomina.AgregarNomina(detalles);

            // Verificar el resultado
            if (resultado > 0)
            {
                // La nómina se agregó correctamente
                MessageBox.Show("Nómina agregada correctamente");
            }
            else
            {
                // Hubo un error al agregar la nómina
                MessageBox.Show("Error al agregar la nómina");
            }
        }





    }
}
