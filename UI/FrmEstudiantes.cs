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
    public partial class FrmEstudiantes : Form
    {
        private Form FormularioActual;
        public FrmEstudiantes()
        {
            InitializeComponent();
        }
        public FrmEstudiantes(string codigo, string nombre, string apellido, DateTime fecha_nac, string telefono, string colegio, string responsable, string domicilio, string grado, string evaluacion, int municipioId, int departamentoId)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox y ComboBox correspondientes en el evento Load
            Load += (sender, e) =>
            {
                txtcod1.Text = codigo;
                txtname.Text = nombre;
                txtape.Text = apellido;
                dateTimeFechaAL.Value = fecha_nac;
                txttel.Text = telefono;
                txtcol.Text = colegio;
                txtres.Text = responsable;
                txtdom.Text = domicilio;
                txtgrad.Text = grado;
                txteva.Text = evaluacion;

                CargarDepartamentos();

                // Verificar que se haya seleccionado un departamento válido
                if (departamentoId > 0)
                {
                    // Obtener el departamento seleccionado
                    Departamentos departamentoSeleccionado = cmbDepartamento.Items.Cast<Departamentos>().FirstOrDefault(d => d.Id == departamentoId);

                    // Verificar que se haya encontrado el departamento
                    if (departamentoSeleccionado != null)
                    {
                        // Seleccionar el departamento en el ComboBox
                        cmbDepartamento.SelectedItem = departamentoSeleccionado;

                        // Cargar los municipios asociados al departamento seleccionado
                        CargarMunicipios(departamentoId);

                        // Obtener el municipio seleccionado
                        Municipios municipioSeleccionado = cmbMunicipio.Items.Cast<Municipios>().FirstOrDefault(m => m.Id == municipioId);

                        // Verificar que se haya encontrado el municipio
                        if (municipioSeleccionado != null)
                        {
                            // Seleccionar el municipio en el ComboBox
                            cmbMunicipio.SelectedItem = municipioSeleccionado;
                        }
                    }
                }


                modoEdicion = ModoEdicion.Actualizacion;
            };
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

            int municipioIdSeleccionado = -1; // Valor por defecto para ningún municipio seleccionado
            if (cmbMunicipio.SelectedItem != null)
            {
                Municipios municipioSeleccionado = cmbMunicipio.SelectedItem as Municipios;
                municipioIdSeleccionado = municipioSeleccionado.Id;
            }
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
            foreach (Control control in grpBoxEstu.Controls)
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

            foreach (Control control in pnlContenedor.Controls)
            {
                if (control is TextBox textBox && textBox != txtBuscar && textBox != txtcod1)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
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
            foreach (Control control in grpBoxEstu.Controls)
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
            foreach (Control control in pnlContenedor.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Si el control es un TextBox, se limpia su texto estableciéndolo como vacío
                    textBox.Text = string.Empty;
                }
            }

            foreach (Control control in pnlMenu.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Si el control es un TextBox, se limpia su texto estableciéndolo como vacío
                    textBox.Text = string.Empty;
                }
            }

        }
        private enum ModoEdicion
        {
            NuevoRegistro,
            Actualizacion
        }

        private ModoEdicion modoEdicion = ModoEdicion.NuevoRegistro;


        private void btnListarEstu_Click_1(object sender, EventArgs e)
        {
            this.LoadForm(new FrmListadoEstudiantes());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarEstudiante(Alumnos estudiante)
        {
            // Asignar los valores a los campos del formulario
            txtcod1.Text = estudiante.cod_Alumno;
            txtname.Text = estudiante.nom_Alumno;
            txtape.Text = estudiante.ape_Alumno;
            txtcol.Text = estudiante.colegio_Alumno;
            txttel.Text = estudiante.telfResp_Alumno;
            txtres.Text = estudiante.nomResp_Alumno;
            txtdom.Text = estudiante.domicilio_Alumno;
            txtgrad.Text = estudiante.gradoAcad_Alumno;
            txteva.Text = estudiante.evaluacion_Alumno;
            dateTimeFechaAL.Value = estudiante.fechaNac_Alumno;

            // Obtener el departamento seleccionado del estudiante
            int departamentoIdSeleccionado = estudiante.DepartamentoId;
            Departamentos departamentoSeleccionado = cmbDepartamento.Items.OfType<Departamentos>().FirstOrDefault(d => d.Id == departamentoIdSeleccionado);

            // Seleccionar el departamento correspondiente
            if (departamentoSeleccionado != null)
            {
                cmbDepartamento.SelectedItem = departamentoSeleccionado;

                // Cargar los municipios correspondientes al departamento seleccionado
                CargarMunicipios(departamentoIdSeleccionado);

                // Obtener el municipio seleccionado del estudiante
                int municipioIdSeleccionado = estudiante.MunicipioId;

                // Buscar el municipio correspondiente al municipioIdSeleccionado en la lista de municipios del ComboBox
                Municipios municipioSeleccionado = cmbMunicipio.Items.OfType<Municipios>().FirstOrDefault(m => m.Id == municipioIdSeleccionado);

                // Seleccionar el municipio correspondiente
                if (municipioSeleccionado != null)
                {
                    cmbMunicipio.SelectedItem = municipioSeleccionado;
                }

                // Establecer el modo de edición a Actualización
                modoEdicion = ModoEdicion.Actualizacion;

            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el código del estudiante a buscar
            string codigoEstudiante = txtBuscar.Text;

            // Realizar la búsqueda del estudiante
            Alumnos estudiante = CtrlEstudiante.buscar(codigoEstudiante);

            if (estudiante != null)
            {
                // Cargar los datos del estudiante en los campos del formulario
                CargarEstudiante(estudiante);

            }
            else
            {
                // Mostrar mensaje de error si no se encuentra el estudiante
                MessageBox.Show("Registro: " + codigoEstudiante + " no encontrado. Verifique que el valor es correcto", "Buscar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un departamento y un municipio válidos
            Departamentos departamentoSeleccionado = cmbDepartamento.SelectedItem as Departamentos;
            Municipios municipioSeleccionado = cmbMunicipio.SelectedItem as Municipios;

            if (departamentoSeleccionado != null && municipioSeleccionado != null && !CamposVacios())
            {
                try
                {
                    // Crear un objeto Estudiante con los valores de los campos del formulario
                    Estudiante estudiante = new Estudiante(txtcod1.Text, txtname.Text, txtape.Text, dateTimeFechaAL.Value, txtres.Text, txttel.Text, txtcol.Text, txtgrad.Text, txtdom.Text, txteva.Text, departamentoSeleccionado.Id, municipioSeleccionado.Id);

                    // Guardar el estudiante en la base de datos

                    int resultado = estudiante.guardar();

                    if (resultado > 0)
                    {
                        // Mostrar mensaje de éxito y limpiar los campos del formulario
                        MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpBoxEstu_Enter(object sender, EventArgs e)
        {

        }
    }
}