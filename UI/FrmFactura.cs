using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmFactura : Form
    {
        private Form FormularioActual;
        private bool filaAgregada = false;
      
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            txtcost.Text = string.Empty;
            txtcant.Text = string.Empty;
            txtcod.Text= string.Empty;
            txtest.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            cmbmod.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
        }

        private void CargarModalidades()
        {
            // Obtener la lista de modalidades desde el controlador
            List<Modalidades> modalidades = CtrlFactura.ObtenerModalidades();
            cmbmod.DisplayMember = "nom_Modalidad";
            cmbmod.ValueMember = "Id";
            cmbmod.DataSource = modalidades;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            CargarModalidades();
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private enum ModoEdicion
        {
            NuevoRegistro,
            Actualizacion
        }

        private ModoEdicion modoEdicion = ModoEdicion.NuevoRegistro;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modalidades modalidaseleccionada = cmbmod.SelectedItem as Modalidades;
            DateTime fecha = Fecha.Value;

            if (modalidaseleccionada != null)
            {
                try
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        decimal total = Convert.ToDecimal(dataGridView1.Rows[0].Cells[0].Value);
                        Factura facturas = new Factura(Convert.ToInt32(txtcant.Text), Convert.ToDouble(total), fecha, Convert.ToInt32(txtid.Text), modalidaseleccionada.Id);

                        int resultado;
                        if (modoEdicion == ModoEdicion.Actualizacion)
                        {
                            // Actualizar el registro existente
                            resultado = facturas.EditarFactura(txtcodfac.Text);
                        }
                        else
                        {
                            // Crear un nuevo registro
                            resultado = facturas.GuardarFactura();
                        }

                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            modoEdicion = ModoEdicion.NuevoRegistro;
                            LimpiarFormulario();
                        }
                    }
                    else
                    {
                        MessageBox.Show("calcule el total de la factura");
                    }
                }
                catch (ArgumentNullException arg)
                {
                    MessageBox.Show("Se ha producido una falla al ejecutar la acción guardar: " + arg.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidOperationException inv)
                {
                    MessageBox.Show("Se ha producido una falla al ejecutar la acción guardar: " + inv.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DbUpdateException db)
                {
                    MessageBox.Show("Se ha producido una falla al ejecutar la acción guardar: " + db.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos.", "Guardar");
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cantidadSesiones;
            if (int.TryParse(txtcant.Text, out cantidadSesiones))
            {
                // El valor se pudo convertir correctamente, continuar con el cálculo y agregar la fila al DataGridView
                double costoSesion = Convert.ToDouble(txtcost.Text);
                double costoFinal = cantidadSesiones * costoSesion;

                if (filaAgregada)
                {
                    // Si ya se ha agregado una fila, eliminarla antes de agregar una nueva
                    dataGridView1.Rows.RemoveAt(0);
                }

                // Agregar la nueva fila al DataGridView
                dataGridView1.Rows.Add(costoSesion, cantidadSesiones, costoFinal);
                filaAgregada = true;
            }
            else
            {
                // Mostrar un mensaje de error indicando que la cantidad de sesiones no es válida
                MessageBox.Show("La cantidad de sesiones ingresada no es válida.", "Error");
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

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        public void CargarFacturas()
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener el código del estudiante y factura a buscar
            string codigoFac = txtBuscar.Text;
            // Realizar la búsqueda de la factura
            Facturas factura = CtrlFactura.facturas(codigoFac);

            if (factura != null)
            {
                txtcant.Text = factura.cantSesiones_Factura.ToString();
                txtcost.Text = factura.costo_Factura.ToString();
                txtid.Text = factura.AlumnoId.ToString();
                txtcodfac.Text = factura.cod_Factura;
                // Asignar el valor seleccionado en el ComboBox
                cmbmod.SelectedValue = factura.ModalidadId;

                Alumnos alumno =  CtrlEstudiante.buscarAumnoId(factura.AlumnoId);
                if (alumno != null)
                {
                    txtcod.Text = alumno.cod_Alumno; // Asignar el código del alumno al campo correspondiente
                }

                // Restablecer el modo de edición a Actualización
                modoEdicion = ModoEdicion.Actualizacion;


            }
            else
            {
                // Mostrar mensaje de error si no se encuentra el estudiante
                MessageBox.Show("Registro: " + codigoFac + " no encontrado. Verifique que el valor es correcto", "Buscar Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnListarEstu_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmListadoFacturas());
           
        }

        private void txtcod_TextChanged_1(object sender, EventArgs e)
        {
            string codigoAlumno = txtcod.Text; // Código del alumno buscado

            CtrlFactura factura = new CtrlFactura();
            Alumnos alumno = CtrlFactura.buscar(codigoAlumno);

            if (alumno != null)
            {
                txtest.Text = alumno.nom_Alumno;
                txtid.Text = alumno.Id.ToString(); // Asignar el Id del alumno a la propiedad AlumnoId en el objeto Factura

            }
            else
            {
                txtest.Text = string.Empty; // Limpiar el TextBox si no se encontró un alumno
            }
        }
    }
}
