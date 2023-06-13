using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }
        public FrmEstudiante(string codigo, string nombre, string apellido, DateTime fecha_nac, string telefono, string colegio, string responsable, string domicilio, string grado, string evaluacion, int municipioId, int departamentoId)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox y ComboBox correspondientes en el evento Load
            Load += (sender, e) =>
            {
                txtcod.Text = codigo;
                txtcod.Enabled = false;
                txtname.Text = nombre;
                txtape.Text = apellido;
                dateTimeFechaAL.Value = fecha_nac;
                txttel.Text = telefono;
                txtcol.Text = colegio;
                txtres.Text = responsable;
                txtdom.Text = domicilio;
                txtgrad.Text = grado;
                txteva.Text = evaluacion;
                cmbMunicipio.SelectedValue = municipioId;
                cmbDepartamento.SelectedValue = departamentoId;
                modoEdicion = ModoEdicion.Actualizacion;
            };
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            CargarDepartamentos(); // Cargar los departamentos en el ComboBox
            cmbDepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged; // Asignar el evento para el cambio de selección del ComboBox de departamentos
            LimpiarTextBoxes(); // Limpiar los TextBox y ComboBox al cargar el formulario
        }

        private void CargarDepartamentos()
        {
            // Obtener la lista de departamentos desde el controlador
            List<Departamentos> departamentos = CtrlEstudiante.ObtenerDepartamentos();

            // Configurar el ComboBox de departamentos
            cmbDepartamento.DisplayMember = "nom_Departamento"; // Mostrar el nombre del departamento en el ComboBox
            cmbDepartamento.ValueMember = "Id"; // Establecer el valor del departamento como el ID

            // Asignar la lista de departamentos al ComboBox
            cmbDepartamento.DataSource = departamentos;
        }

        private void CargarMunicipios(int departamentoId)
        {
            // Obtener la lista de municipios por departamento desde el controlador
            List<Municipios> municipios = CtrlEstudiante.ObtenerMunicipiosPorDepartamento(departamentoId);

            // Limpiar el ComboBox de municipios antes de agregar los nuevos elementos
            cmbMunicipio.Items.Clear();

            // Configurar el ComboBox de municipios
            cmbMunicipio.DisplayMember = "nom_Municipio"; // Mostrar el nombre del municipio en el ComboBox
            cmbMunicipio.ValueMember = "Id"; // Establecer el valor del municipio como el ID

            // Agregar los municipios al ComboBox
            cmbMunicipio.Items.AddRange(municipios.ToArray());

            // Obtener el ID del municipio seleccionado del estudiante (si existe)
            int municipioIdSeleccionado = -1; // Valor por defecto para ningún municipio seleccionado
            if (!string.IsNullOrEmpty(txtcod.Text))
            {
                Alumnos estudiante = CtrlEstudiante.buscar(txtcod.Text);
                if (estudiante != null)
                {
                    municipioIdSeleccionado = estudiante.MunicipioId;
                }
            }

            // Establecer el municipio seleccionado en el ComboBox
            cmbMunicipio.SelectedItem = municipios.FirstOrDefault(m => m.Id == municipioIdSeleccionado);
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el departamento seleccionado del ComboBox
            Departamentos departamentoSeleccionado = cmbDepartamento.SelectedItem as Departamentos;

            // Verificar que se haya seleccionado un departamento válido (diferente de la opción de título)
            if (departamentoSeleccionado != null && departamentoSeleccionado.Id > 0)
            {
                // Obtener el ID del departamento seleccionado
                int departamentoId = departamentoSeleccionado.Id;

                // Cargar los municipios asociados al departamento seleccionado
                CargarMunicipios(departamentoId);
            }
        }

        private bool CamposVacios()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && textBox != txtBuscar)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return true;
                    }
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    if (string.IsNullOrEmpty(maskedTextBox.Text))
                    {
                        return true;
                    }
                }
            }

            return false;
        }




        private void LimpiarTextBoxes()
        {
            // Recorrer todos los controles del formulario
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    // Si el control es un TextBox, se limpia su texto estableciéndolo como vacío
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    // Si el control es un ComboBox, se establece el índice seleccionado a -1 para limpiar la selección
                    comboBox.SelectedIndex = -1;
                }
            }
        }

        private enum ModoEdicion
        {
            NuevoRegistro,
            Actualizacion
        }

        private ModoEdicion modoEdicion = ModoEdicion.NuevoRegistro;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimeFechaAL.Value;
            Departamentos departamentoSeleccionado = cmbDepartamento.SelectedItem as Departamentos;
            Municipios municipioSeleccionado = cmbMunicipio.SelectedItem as Municipios;

            // Verificar que se haya seleccionado un departamento y un municipio válidos
            if ((departamentoSeleccionado != null && municipioSeleccionado != null && !CamposVacios() || !string.IsNullOrEmpty(txtBuscar.Text)))
            {
                try
                {
                    // Verificar si el código del estudiante ya existe en la base de datos
                    Alumnos estudianteExistente = CtrlEstudiante.buscar(txtcod.Text);
                    if (estudianteExistente != null && modoEdicion == ModoEdicion.NuevoRegistro)
                    {
                        MessageBox.Show("El código de estudiante ya existe en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método para evitar guardar el estudiante duplicado
                    }

                    // Crear un objeto Estudiante con los valores de los campos del formulario
                    Estudiante estudiante = new Estudiante(txtcod.Text, txtname.Text, txtape.Text, fecha, txtres.Text, txttel.Text, txtcol.Text, txtgrad.Text, txtdom.Text, txteva.Text, departamentoSeleccionado.Id, municipioSeleccionado.Id);

                    // Guardar el estudiante en la base de datos
                    int rst = estudiante.guardar();

                    if (rst > 0)
                    {
                        // Mostrar mensaje de éxito y limpiar los campos del formulario
                        MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcod.Enabled = true;
                        LimpiarTextBoxes();
                        modoEdicion = ModoEdicion.NuevoRegistro; // Restablecer el modo de edición a NuevoRegistro
                    }
                }
                catch (ArgumentNullException arg)
                {
                    // Mostrar mensaje de error en caso de ArgumentNullException
                    MessageBox.Show("Se ha producido una falla al ejecutar la acción guardar: " + arg.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException inv)
                {
                    // Mostrar mensaje de error en caso de InvalidOperationException
                    MessageBox.Show("Se ha producido una falla al ejecutar la acción guardar: " + inv.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DbUpdateException db)
                {
                    // Mostrar mensaje de error en caso de DbUpdateException
                    MessageBox.Show("Se ha producido una falla al ejecutar la acción guardar: " + db.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje de error si no se seleccionó un departamento y municipio válidos
                MessageBox.Show("Por favor llena todos los campos.", "Guardar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Realizar la búsqueda del estudiante
            Alumnos estudiante = CtrlEstudiante.buscar(txtBuscar.Text);

            if (estudiante != null)
            {
                // Obtener los IDs del departamento y municipio seleccionados en el estudiante
                int departamentoIdSeleccionado = estudiante.DepartamentoId;
                int municipioIdSeleccionado = estudiante.MunicipioId;

                // Asignar los valores del estudiante a los campos correspondientes
                txtcod.Text = estudiante.cod_Alumno;
                txtcod.Enabled = false;
                txtname.Text = estudiante.nom_Alumno;
                txtape.Text = estudiante.ape_Alumno;
                txtcol.Text = estudiante.colegio_Alumno;
                txttel.Text = estudiante.telfResp_Alumno;
                txtres.Text = estudiante.nomResp_Alumno;
                txtdom.Text = estudiante.domicilio_Alumno;
                txtgrad.Text = estudiante.gradoAcad_Alumno;
                txteva.Text = estudiante.evaluacion_Alumno;
                dateTimeFechaAL.Text = estudiante.fechaNac_Alumno.ToString();
                cmbDepartamento.SelectedValue = departamentoIdSeleccionado;
                cmbMunicipio.SelectedValue = municipioIdSeleccionado;

                // Establecer el modo de edición a Actualizacion
                modoEdicion = ModoEdicion.Actualizacion;
            }
            else
            {
                // Mostrar mensaje de error si no se encuentra el estudiante
                MessageBox.Show("Registro: " + txtBuscar.Text + " no encontrado. Verifique que el valor es correcto", "Buscar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}