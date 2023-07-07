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
    public partial class FrmTrabajadores : Form
    {
        private Form FormularioActual;
        private enum ModoEdicion
        {
            NuevoRegistro,
            Actualizacion
        }

        private ModoEdicion modoEdicion = ModoEdicion.NuevoRegistro;

        public FrmTrabajadores()
        {
            InitializeComponent();
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
        public FrmTrabajadores(string codigo, string nombre, string apellido, string domicilio, string telefono, int profesionId, int departamentoId, int municipioId)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox y ComboBox correspondientes en el evento Load
            Load += (sender, e) =>
            {
                txtcod.Text = codigo;
                txtnom.Text = nombre;
                txtape.Text = apellido;
                txtdom.Text = domicilio;
                Msktel.Text = telefono;

                // Seleccionar la profesión correspondiente
                cmbprofesion.SelectedItem = cmbprofesion.Items.Cast<Profesiones>().FirstOrDefault(p => p.Id == profesionId);

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


        private void FrmTrabajador_Load(object sender, EventArgs e)
        {

            CargarDepartamentos();
            cmbDepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged;
            CargarProfesiones();
            LimpiarCampos();
        }

        private void CargarProfesiones()
        {
            List<Profesiones> profesiones = Ctrltrabajador.ObtenerProfesiones();

            cmbprofesion.DisplayMember = "nom_Profesion";
            cmbprofesion.ValueMember = "Id";
            cmbprofesion.DataSource = profesiones;
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
        private void LimpiarCampos()
        {
            // Recorrer todos los controles del formulario
            foreach (Control control in grbRegistrarTraba.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Excluir el campo txtBuscar al limpiar los TextBox

                    textBox.Text = string.Empty;

                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Text = string.Empty;
                }
            }
            foreach (Control control in pnlMenu.Controls)
            {
                if (control is TextBox textBox)
                {
                    // Excluir el campo txtBuscar al limpiar los TextBox

                    textBox.Text = string.Empty;

                }
            }
        }

        private bool CamposVacios()
        {
            foreach (Control control in grbRegistrarTraba.Controls)
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
            foreach (Control control in pnlMenu.Controls)
            {
                if (control is TextBox textBox && textBox != txtBuscar)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return true;
                    }
                }
            }

            foreach (Control control in pnlContenedor.Controls)
            {
                if (control is TextBox textBox && textBox != txtBuscar && textBox != txtcod)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void CargarTrabajador(Trabajadores trabajador)
        {
            txtcod.Text = trabajador.cod_Trabajador;
            txtnom.Text = trabajador.nom_Trabajador;
            txtape.Text = trabajador.ape_Trabajador;
            txtdom.Text = trabajador.domicilio_Trabajador;
            Msktel.Text = trabajador.telefono_Trabajador;

            int departamentoIdSeleccionado = trabajador.DepartamentoId;
            int municipioIdSeleccionado = trabajador.MunicipioId;
            int profesionIdSeleccionada = trabajador.ProfesionId;

            // Obtener el departamento seleccionado del trabajador
            Departamentos departamentoSeleccionado = cmbDepartamento.Items.OfType<Departamentos>().FirstOrDefault(d => d.Id == departamentoIdSeleccionado);

            // Seleccionar el departamento correspondiente
            if (departamentoSeleccionado != null)
            {
                cmbDepartamento.SelectedItem = departamentoSeleccionado;

                // Cargar los municipios correspondientes al departamento seleccionado
                CargarMunicipios(departamentoIdSeleccionado);

                // Obtener el municipio seleccionado del trabajador
                Municipios municipioSeleccionado = cmbMunicipio.Items.OfType<Municipios>().FirstOrDefault(m => m.Id == municipioIdSeleccionado);

                // Seleccionar el municipio correspondiente
                if (municipioSeleccionado != null)
                {
                    cmbMunicipio.SelectedItem = municipioSeleccionado;
                }
            }

            // Obtener la profesión seleccionada del trabajador
            Profesiones profesionSeleccionada = cmbprofesion.Items.OfType<Profesiones>().FirstOrDefault(p => p.Id == profesionIdSeleccionada);

            // Seleccionar la profesión correspondiente
            if (profesionSeleccionada != null)
            {
                cmbprofesion.SelectedItem = profesionSeleccionada;
            }
            modoEdicion = ModoEdicion.Actualizacion;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el código del trabajador a buscar
            string codigoTrabajador = txtBuscar.Text;

            // Realizar la búsqueda del trabajador
            Trabajadores trabajador = Ctrltrabajador.buscar(codigoTrabajador);

            if (trabajador != null)
            {
                // Cargar los datos del trabajador en los campos del formulario
                CargarTrabajador(trabajador);
            }
            else
            {
                // Mostrar mensaje de error si no se encuentra el trabajador
                MessageBox.Show("Registro: " + codigoTrabajador + " no encontrado. Verifique que el valor es correcto", "Buscar Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un departamento, un municipio y una profesión válidos
            Departamentos departamentoSeleccionado = cmbDepartamento.SelectedItem as Departamentos;
            Municipios municipioSeleccionado = cmbMunicipio.SelectedItem as Municipios;
            Profesiones profesionSeleccionada = cmbprofesion.SelectedItem as Profesiones;


            if (departamentoSeleccionado != null && municipioSeleccionado != null && profesionSeleccionada != null && !CamposVacios())
            {
                try
                {
                    // Crear un objeto Trabajador con los valores de los campos del formulario
                    Trabajador trabajador = new Trabajador(txtcod.Text, txtnom.Text, txtape.Text, txtdom.Text, Msktel.Text, profesionSeleccionada.Id, departamentoSeleccionado.Id, municipioSeleccionado.Id);

                    // Guardar el trabajador en la base de datos
                    int resultado = trabajador.guardar();

                    if (resultado > 0)
                    {
                        // Mostrar mensaje de éxito y limpiar los campos del formulario
                        MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
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
                // Mostrar mensaje de error si no se seleccionó un departamento, municipio y profesión válidos o si hay campos vacíos
                MessageBox.Show("Por favor llena todos los campos correctamente.", "Guardar");
            }
        }

        private void btnListarTraba_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmListadoTrabajadores());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbRegistrarTraba_Enter(object sender, EventArgs e)
        {

        }
    }

}