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
    public partial class FrmNominas : Form
    {
        public FrmNominas()
        {
            InitializeComponent();
        }

        private void FrmNominas_Load(object sender, EventArgs e)
        {
            listado();
        }


        public void listado()
        {
            DateTime inicio = new DateTime(2023, 7, 2); // Establecer una fecha manual
            DateTime final = new DateTime(2023, 7, 2);

            dataGridView1.Rows.Clear(); // Limpiar las filas existentes en el DataGridView

            double valorMultiplicador = 80;
          
                foreach (dynamic nominas in CtrlNomina.filtradohoras(inicio, final))
                {
                    double horasTrabajadas = nominas.HorasTrabajadas;
                    double horasMultiplicadas = horasTrabajadas * valorMultiplicador;

                    dataGridView1.Rows.Add(nominas.NombreTrabajador, horasTrabajadas, horasMultiplicadas);
                }
            
           
        }








        public void AgregarNomina()
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
                decimal salario = Convert.ToDecimal(row.Cells["Salario"].Value);

                // Crear un objeto DetalleNomina y agregarlo a la lista
                DetalleNominas detalle = new DetalleNominas(horasTrabajadas, salario);
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
