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
    public partial class ListadoSesion : Form
    {
        public ListadoSesion()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBusqueda.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor de búsqueda válido.", "Búsqueda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Sesiones sesiones = CtrlSesion.buscar(busqueda);

            if (sesiones == null)
            {
                MessageBox.Show("No se encontró ningún estudiante con el código especificado.", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MostrarEstudianteEnDataGridView(sesiones);
        }


        private void MostrarEstudianteEnDataGridView(Sesiones sesiones)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(sesiones.cod_Sesion, sesiones.fecha_Sesion, sesiones.cantHoras_Sesion, "Edit");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string codigo = selectedRow.Cells[0].Value.ToString();

                // Obtener la sesion completa utilizando el código
                Sesiones sesion = CtrlSesion.buscar(codigo);

                if (sesion != null)
                {
                    // Obtener los valores de los campos de la sesion
                    DateTime fecha = sesion.fecha_Sesion;
                    int cantidad = sesion.cantHoras_Sesion;
                    int facturaId = sesion.FacturaId;
                    int trabajadorId = sesion.TrabajadorId;

                    // Abrir el formulario de FrmEstudiante y pasar los datos como argumentos
                    FrmSesiones frmses = new FrmSesiones(codigo, fecha, cantidad, trabajadorId, facturaId);
                    frmses.ShowDialog();
                }
            }
        }

        public void Listado()
        {

            foreach (var ses in CtrlSesion.Buscar())
            {
                dataGridView1.Rows.Add(ses.cod_Sesion, ses.fecha_Sesion, ses.cantHoras_Sesion, "Edit");
            }
        }

        private void ListadoSesion_Load(object sender, EventArgs e)
        {
            Listado();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
