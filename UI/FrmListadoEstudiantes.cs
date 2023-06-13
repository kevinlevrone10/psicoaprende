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
    public partial class FrmListadoEstudiantes : Form
    {
        private Form FormularioActual;
        public FrmListadoEstudiantes()
        {
            InitializeComponent();
        }

        public void Listado()
        {

            foreach (var est in CtrlEstudiante.Buscar())
            {
                dataGridView1.Rows.Add(est.cod_Alumno, est.nom_Alumno, est.ape_Alumno, est.fechaNac_Alumno, est.telfResp_Alumno, est.nomResp_Alumno, est.domicilio_Alumno, "Edit");
            }
        }

        private void MostrarEstudianteEnDataGridView(Alumnos estudiante)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(estudiante.cod_Alumno, estudiante.nom_Alumno, estudiante.ape_Alumno,
                                   estudiante.fechaNac_Alumno, estudiante.telfResp_Alumno, estudiante.nomResp_Alumno,
                                   estudiante.domicilio_Alumno, "Edit");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string codigo = selectedRow.Cells[0].Value.ToString();

                // Obtener el estudiante completo utilizando el código
                Alumnos estudiante = CtrlEstudiante.buscar(codigo);

                if (estudiante != null)
                {
                    // Obtener los valores de los campos del estudiante
                    string nombre = estudiante.nom_Alumno;
                    string apellido = estudiante.ape_Alumno;
                    DateTime fechaNacimiento = estudiante.fechaNac_Alumno;
                    string telefono = estudiante.telfResp_Alumno;
                    string colegio = estudiante.colegio_Alumno;
                    string responsable = estudiante.nomResp_Alumno;
                    string domicilio = estudiante.domicilio_Alumno;
                    string grado = estudiante.gradoAcad_Alumno;
                    string evaluacion = estudiante.evaluacion_Alumno;
                    int municipioId = estudiante.MunicipioId;
                    int departamentoId = estudiante.DepartamentoId;

                    // Abrir el formulario de FrmEstudiante y pasar los datos como argumentos
                    this.LoadForm(new FrmEstudiante(codigo, nombre, apellido, fechaNacimiento, telefono, colegio, responsable, domicilio, grado, evaluacion, municipioId, departamentoId));
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

        private void FrmListadoEstudiantes_Load(object sender, EventArgs e)
        {
            Listado();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void btnCerra_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese un valor de búsqueda válido.", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Alumnos estudiante = CtrlEstudiante.buscar(busqueda);

            if (estudiante == null)
            {
                MessageBox.Show("No se encontró ningún estudiante con el código especificado.", "Búsqueda",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MostrarEstudianteEnDataGridView(estudiante);
        }
    }
}
