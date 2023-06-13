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
    public partial class FrmSesiones : Form
    {
        public FrmSesiones()
        {
            InitializeComponent();
        }

        public FrmSesiones(string codigo, DateTime fecha, int cantidad, int profesionid, int facturaid)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox y ComboBox correspondientes en el evento Load
            Load += (sender, e) =>
            {
                txtcod.Text = codigo;
                txtcod.Enabled = false;
                datafecha.Value = fecha;
                mskcant.Text = cantidad.ToString();
                cmbfactura.SelectedValue = facturaid;
                cmbtrabajador.SelectedValue = profesionid;
                modoEdicion = ModoEdicion.Actualizacion;
            };

        }

        private void FrmSesiones_Load(object sender, EventArgs e)
        {
            Cargartrabajadores();
            CargarFacturas();
            LimpiarTextBoxes();

        }

        private void Cargartrabajadores()
        {
            // Obtener la lista de trabajadores desde el controlador
            List<Trabajadores> trabajador = CtrlSesion.Obtenertrabajadores();

            // Configurar el ComboBox de trabajadores
            cmbtrabajador.DisplayMember = "nom_Trabajador";
            cmbtrabajador.ValueMember = "Id";


            // Asignar la lista de trabajadores al ComboBox
            cmbtrabajador.DataSource = trabajador;
        }

        private void CargarFacturas()
        {
            // Obtener la lista de facturas desde el controlador
            List<Facturas> facturas = CtrlSesion.ObtenerFacturas();

            // Configurar el ComboBox de facturas
            cmbfactura.DisplayMember = "cod_Factura";
            cmbfactura.ValueMember = "Id";


            // Asignar la lista de facturas al ComboBox
            cmbfactura.DataSource = facturas;
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

        private enum ModoEdicion
        {
            NuevoRegistro,
            Actualizacion
        }

        private ModoEdicion modoEdicion = ModoEdicion.NuevoRegistro;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = datafecha.Value;
            Trabajadores trabajadorSeleccionado = cmbtrabajador.SelectedItem as Trabajadores;
            Facturas facturaSeleccionado = cmbfactura.SelectedItem as Facturas;
            // Verificar que se haya seleccionado un trabajador y una factura
            if ((trabajadorSeleccionado != null && facturaSeleccionado != null && !CamposVacios() || !string.IsNullOrEmpty(txtBuscar.Text)))
            {
                try
                {
                    // Verificar si el código del estudiante ya existe en la base de datos
                    Sesiones sesionExistente = CtrlSesion.buscar(txtcod.Text);
                    if (sesionExistente != null && modoEdicion == ModoEdicion.NuevoRegistro)
                    {
                        MessageBox.Show("El código de la sesion ya existe en la base de datos.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método para evitar guardar el estudiante duplicado
                    }

                    // Crear un objeto sesiones con los valores de los campos del formulario
                    Sesion sesion = new Sesion(txtcod.Text, fecha, Convert.ToInt32(mskcant.Text), trabajadorSeleccionado.Id, facturaSeleccionado.Id);

                    // Guardar el estudiante en la base de datos
                    int rst = sesion.guardar();

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

        private void button2_Click(object sender, EventArgs e)
        {
            Sesiones sesion = CtrlSesion.buscar(txtBuscar.Text);

            if (sesion != null)
            {
                int FacturaIdSeleccionado = sesion.FacturaId;
                int trabajadorIdSeleccionado = sesion.TrabajadorId;

                txtcod.Text = sesion.cod_Sesion;
                txtcod.Enabled = false;
                datafecha.Text = sesion.fecha_Sesion.ToString();
                mskcant.Text = sesion.cantHoras_Sesion.ToString();
                cmbfactura.SelectedValue = FacturaIdSeleccionado;
                cmbtrabajador.SelectedValue = trabajadorIdSeleccionado;

                modoEdicion = ModoEdicion.Actualizacion;
            }
            else
            {
                MessageBox.Show("Registro: " + txtBuscar.Text + " no encontrado. Verifique que el valor es correcto", "Buscar Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
