using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using System;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmListadoSesiones : Form
    {
        private Form FormularioActual;
        public FrmListadoSesiones()
        {
            InitializeComponent();
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
                    this.LoadForm(new FrmSesiones(codigo, fecha, cantidad, trabajadorId, facturaId));
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor de búsqueda válido.", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Sesiones sesiones = CtrlSesion.buscar(busqueda);

                if (sesiones == null)
                {
                    MessageBox.Show("No se encontró ninguna sesión con el código especificado.", "Búsqueda",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MostrarEstudianteEnDataGridView(sesiones);
                }
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
