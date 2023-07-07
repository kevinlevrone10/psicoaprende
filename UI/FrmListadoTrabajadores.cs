using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using System;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmListadoTrabajadores : Form
    {
        private Form FormularioActual;
        public FrmListadoTrabajadores()
        {
            InitializeComponent();
        }

        private void ListadoTrabajador_Load(object sender, EventArgs e)
        {
            Listado();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        public void Listado()
        {

            foreach (var est in Ctrltrabajador.Buscar())
            {
                dataGridView1.Rows.Add(est.cod_Trabajador, est.nom_Trabajador, est.ape_Trabajador, est.telefono_Trabajador, "Edit");
            }
        }


        private void MostrarEstudianteEnDataGridView(Trabajadores trabajador)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(trabajador.cod_Trabajador, trabajador.nom_Trabajador, trabajador.ape_Trabajador, trabajador.telefono_Trabajador, "Edit");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string codigo = selectedRow.Cells[0].Value.ToString();
                var trabajador = Ctrltrabajador.buscar(codigo);

                if (trabajador != null)
                {
                    string nombre = trabajador.nom_Trabajador;
                    string apellido = trabajador.ape_Trabajador;
                    string domicilio = trabajador.domicilio_Trabajador;
                    string telefono = trabajador.telefono_Trabajador;
                    int profesionId = trabajador.ProfesionId;
                    int municipioId = trabajador.MunicipioId;
                    int departamentoId = trabajador.DepartamentoId;

                    this.LoadForm(new FrmTrabajadores(codigo, nombre, apellido, domicilio, telefono, profesionId, departamentoId, municipioId));
                }
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor de búsqueda válido.", "Búsqueda",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Trabajadores trabajador = Ctrltrabajador.buscar(busqueda);
            if (trabajador == null)
            {
                MessageBox.Show("No se encontró ningún estudiante con el código especificado.", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MostrarEstudianteEnDataGridView(trabajador);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
