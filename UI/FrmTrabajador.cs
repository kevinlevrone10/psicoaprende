using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmTrabajador : Form
    {
        private enum ModoEdicion
        {
            NuevoRegistro,
            Actualizacion
        }

        private ModoEdicion modoEdicion = ModoEdicion.NuevoRegistro;

        public FrmTrabajador()
        {
            InitializeComponent();
        }

        public FrmTrabajador(string codigo, string nombre, string apellido, string domicilio, string telefono, int profesionId, int DepartamentoId, int MunicipioId)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox y ComboBox correspondientes en el evento Load
            Load += (sender, e) =>
            {
                txtcod.Text = codigo;
                txtcod.Enabled = false;
                txtnom.Text = nombre;
                txtape.Text = apellido;
                txtdom.Text = domicilio;
                Msktel.Text = telefono;
                cmbmunicipio.SelectedValue = MunicipioId;
                cmbdepartamento.SelectedValue = DepartamentoId;
                cmbprofesion.SelectedValue = profesionId;
                modoEdicion = ModoEdicion.Actualizacion;
            };


        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            CargarProfesiones();
            CargarDepartamentos();
            cmbdepartamento.SelectedIndexChanged += cmbDepartamento_SelectedIndexChanged;
            LimpiarCampos();
        }

        private void CargarDepartamentos()
        {
            List<Departamentos> departamentos = CtrlEstudiante.ObtenerDepartamentos();

            cmbdepartamento.DisplayMember = "nom_Departamento";
            cmbdepartamento.ValueMember = "Id";
            cmbdepartamento.DataSource = departamentos;
        }

        private void CargarProfesiones()
        {
            List<Profesiones> profesiones = Ctrltrabajador.ObtenerProfesiones();

            cmbprofesion.DisplayMember = "nom_Profesion";
            cmbprofesion.ValueMember = "Id";
            cmbprofesion.DataSource = profesiones;
        }

        private void CargarMunicipios(int departamentoId)
        {
            List<Municipios> municipios = CtrlEstudiante.ObtenerMunicipiosPorDepartamento(departamentoId);

            cmbmunicipio.DisplayMember = "nom_Municipio";
            cmbmunicipio.ValueMember = "Id";
            cmbmunicipio.DataSource = municipios;

            // Obtener el ID del municipio seleccionado del trabajador (si existe)
            int municipioIdSeleccionado = -1; // Valor por defecto para ningún municipio seleccionado
            if (!string.IsNullOrEmpty(txtcod.Text))
            {
                Trabajadores trabajador = Ctrltrabajador.buscar(txtcod.Text);
                if (trabajador != null)
                {
                    municipioIdSeleccionado = trabajador.MunicipioId;
                }
            }

            // Establecer el municipio seleccionado en el ComboBox
            cmbmunicipio.SelectedValue = municipioIdSeleccionado;
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamentos departamentoSeleccionado = cmbdepartamento.SelectedItem as Departamentos;

            if (departamentoSeleccionado != null && departamentoSeleccionado.Id > 0)
            {
                int departamentoId = departamentoSeleccionado.Id;
                CargarMunicipios(departamentoId);
            }
        }

        private void LimpiarCampos()
        {
            // Recorrer todos los controles del formulario
            foreach (Control control in Controls)
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





        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Trabajadores trabajador = Ctrltrabajador.buscar(txtBuscar.Text);

            if (trabajador != null)
            {
                int departamentoIdSeleccionado = trabajador.DepartamentoId;
                int municipioIdSeleccionado = trabajador.MunicipioId;
                int profesionIdSeleccionada = trabajador.ProfesionId;

                txtcod.Text = trabajador.cod_Trabajador;
                txtcod.Enabled = false;
                txtnom.Text = trabajador.nom_Trabajador;
                txtape.Text = trabajador.ape_Trabajador;
                txtdom.Text = trabajador.domicilio_Trabajador;
                Msktel.Text = trabajador.telefono_Trabajador;
                cmbprofesion.SelectedValue = profesionIdSeleccionada;
                cmbdepartamento.SelectedValue = departamentoIdSeleccionado;
                cmbmunicipio.SelectedValue = municipioIdSeleccionado;

                modoEdicion = ModoEdicion.Actualizacion;
            }
            else
            {
                MessageBox.Show("Registro: " + txtBuscar.Text + " no encontrado. Verifique que el valor es correcto", "Buscar Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Departamentos departamentoSeleccionado = cmbdepartamento.SelectedItem as Departamentos;
            Municipios municipioSeleccionado = cmbmunicipio.SelectedItem as Municipios;
            Profesiones profesionSeleccionado = cmbprofesion.SelectedItem as Profesiones;

            // Verificar que se haya seleccionado un departamento y un municipio válidos
            if (departamentoSeleccionado != null && municipioSeleccionado != null && !CamposVacios() || !string.IsNullOrEmpty(txtBuscar.Text))
            {
                try
                {
                    // Verificar si el código del trabajador ya existe en la base de datos
                    Trabajadores Existente = Ctrltrabajador.buscar(txtcod.Text);
                    if (Existente != null && modoEdicion == ModoEdicion.NuevoRegistro)
                    {
                        MessageBox.Show("El código de trabajador ya existe en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método para evitar guardar el trabajador duplicado
                    }

                    // Crear un objeto Trabajador con los valores de los campos del formulario
                    Trabajador trabajador = new Trabajador(txtcod.Text, txtnom.Text, txtape.Text, txtdom.Text, Msktel.Text, profesionSeleccionado.Id, departamentoSeleccionado.Id, municipioSeleccionado.Id);

                    // Guardar el trabajador en la base de datos
                    int rst = trabajador.guardar();

                    if (rst > 0)
                    {
                        // Mostrar mensaje de éxito y limpiar los campos del formulario
                        MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcod.Enabled = true;
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
                // Mostrar mensaje de error si no se seleccionó un departamento y municipio válidos
                MessageBox.Show("Por favor llena todos los campos o asegúrate de que el campo de búsqueda no esté vacío.", "Guardar");
            }
        }

    }

}