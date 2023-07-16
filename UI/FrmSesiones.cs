using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using SistemaPsicoaprende.Negocio;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmSesiones : Form
    {
        private Form FormularioActual;
        public FrmSesiones()
        {
            InitializeComponent();
        }

        private DataTable registrosSeleccionados;
        private DataTable registrosSeleccionados2;
        private void FrmSesiones_Load(object sender, EventArgs e)
        {
            Listado();
            Listado2();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView2.CellClick += dataGridView2_CellClick;
            LimpiarTextBoxes();

            // Inicializar el DataTable para almacenar los registros seleccionados
            registrosSeleccionados = new DataTable();
            registrosSeleccionados.Columns.Add("Id", typeof(int));
            registrosSeleccionados.Columns.Add("Nombre", typeof(string));

            registrosSeleccionados2 = new DataTable();
            registrosSeleccionados2.Columns.Add("Id", typeof(int));
            registrosSeleccionados2.Columns.Add("Factura", typeof(string));

            // Configurar el ComboBox
            cmbtrabajador.DisplayMember = "Nombre";
            cmbtrabajador.ValueMember = "Id";


            cmbfactura.DisplayMember = "Factura";
            cmbfactura.ValueMember = "Id";

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                // Buscar el nombre del trabajador correspondiente al ID seleccionado
                Trabajadores trabajadorSeleccionado = Ctrltrabajador.buscarporId(id);

                if (trabajadorSeleccionado != null)
                {
                    string nombre = trabajadorSeleccionado.nom_Trabajador;

                    // Limpiar el DataTable y agregar el registro seleccionado
                    registrosSeleccionados.Clear();
                    registrosSeleccionados.Rows.Add(id, nombre);

                    // Asignar el DataTable como origen de datos del ComboBox
                    cmbtrabajador.DataSource = registrosSeleccionados;
                    cmbtrabajador.Refresh();
                }
            }
        }


        public void Listado()
        {

            foreach (var est in Ctrltrabajador.Buscar())
            {
                dataGridView1.Rows.Add(est.Id, est.cod_Trabajador, est.nom_Trabajador, "Seleccionar");
            }
        }

        public void Listado2()
        {
            foreach (dynamic factura in CtrlSesion.ObtenerFacturas())
            {
                dataGridView2.Rows.Add(factura.FacturaId, factura.CodigoFactura, factura.Nombre, "Seleccionar");
            }
        }



        public FrmSesiones(string codigo, DateTime fecha, int profesionid, int facturaid)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox correspondientes en el evento Load
            Load += (sender, e) =>
            {
                txtcod.Text = codigo;
                txtcod.Enabled = false;
                datafecha.Value = fecha;
                cmbfactura.SelectedValue = facturaid;
                modoEdicion = ModoEdicion.Actualizacion;

                // Buscar el trabajador correspondiente por ID
                Trabajadores trabajadorSeleccionado = Ctrltrabajador.buscarporId(profesionid);
                Facturas facturaseleccionado = CtrlSesion.ObtenerFacturasid(facturaid);

                if (trabajadorSeleccionado != null && facturaseleccionado != null)
                {
                    // Crear un DataTable con una única fila para el trabajador seleccionado
                    DataTable registrosFiltrados = new DataTable();
                    registrosFiltrados.Columns.Add("Id", typeof(int));
                    registrosFiltrados.Columns.Add("Nombre", typeof(string));
                    registrosFiltrados.Rows.Add(trabajadorSeleccionado.Id, trabajadorSeleccionado.nom_Trabajador);


                    registrosFiltrados2 = new DataTable();
                    registrosFiltrados2.Columns.Add("Id", typeof(int));
                    registrosFiltrados2.Columns.Add("Factura", typeof(string));
                    registrosFiltrados2.Rows.Add(facturaseleccionado.Id, facturaseleccionado.cod_Factura);

                    // Asignar el DataTable como origen de datos del ComboBox
                    cmbtrabajador.DataSource = registrosFiltrados;
                    cmbtrabajador.DisplayMember = "Nombre";
                    cmbtrabajador.ValueMember = "Id";



                    cmbfactura.DataSource = registrosFiltrados2;
                    cmbfactura.DisplayMember = "Factura";
                    cmbfactura.ValueMember = "Id";

                    // Establecer el trabajador seleccionado como el valor seleccionado en el ComboBox
                    cmbtrabajador.SelectedValue = trabajadorSeleccionado.Id;
                    cmbfactura.SelectedValue = facturaseleccionado.Id;

                }
            };
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Edit2"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Identificador"].Value);

                // Buscar la lógica necesaria para obtener el nombre o cualquier otro valor relacionado al ID seleccionado en dataGridView2
                // Buscar el nombre del trabajador correspondiente al ID seleccionado
                Facturas nombreSeleccionado = CtrlSesion.ObtenerFacturasid(id);

                if (nombreSeleccionado != null)
                {
                    string codigo = nombreSeleccionado.cod_Factura;

                    // Limpiar el DataTable y agregar el registro seleccionado
                    registrosSeleccionados2.Clear();
                    registrosSeleccionados2.Rows.Add(id, codigo);

                    // Asignar el DataTable como origen de datos del ComboBox correspondiente en tu formulario
                    cmbfactura.DataSource = registrosSeleccionados2;
                    cmbfactura.Refresh();
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

        private bool CamposVacios()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
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

            return false;
        }






        private void LimpiarTextBoxes()
        {
            // Recorrer todos los controles del formulario
            foreach (Control control in grpBoxSesiones.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    // Excluir el campo txtBuscar al limpiar los TextBox
                    textBox.Text = string.Empty;

                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Text = string.Empty;
                }
            }
            foreach (Control control in grpBoxSeleccion.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    // Excluir el campo txtBuscar al limpiar los TextBox
                    textBox.Text = string.Empty;

                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Text = string.Empty;
                }
            }
            foreach (Control control in grpBoxEmision.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    // Excluir el campo txtBuscar al limpiar los TextBox
                    textBox.Text = string.Empty;

                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is MaskedTextBox maskedTextBox)
                {
                    maskedTextBox.Text = string.Empty;
                }
            }
            foreach (Control control in pnlContenedor.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    // Excluir el campo txtBuscar al limpiar los TextBox
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = datafecha.Value.Date;
            Trabajadores trabajadorSeleccionado = cmbtrabajador.SelectedItem as Trabajadores;
            Facturas facturaSeleccionado = cmbfactura.SelectedItem as Facturas;

            // Verificar que se haya seleccionado un trabajador y una factura
            if ((trabajadorSeleccionado != null && facturaSeleccionado != null && CamposVacios()) == false || !string.IsNullOrEmpty(txtBuscar.Text))
            {
                try
                {
                    int trabajadorId = Convert.ToInt32(cmbtrabajador.SelectedValue);
                    int facturaId = Convert.ToInt32(cmbfactura.SelectedValue);
                    string codigoSesion = txtcod.Text;

                    // Verificar si se han cumplido todas las sesiones contratadas antes de guardar la sesión
                    bool todasSesionesRealizadas = CtrlFactura.VerificarCumplimientoSesiones(facturaId);

                    if (todasSesionesRealizadas && modoEdicion == ModoEdicion.NuevoRegistro)
                    {
                        MessageBox.Show("No se pueden agregar más sesiones a esta factura porque ya se han cumplido todas las sesiones contratadas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Sesion sesion = new Sesion(codigoSesion, fecha, trabajadorId, facturaId);
                    int resultado = sesion.guardar();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTextBoxes();
                        modoEdicion = string.IsNullOrEmpty(codigoSesion) ? ModoEdicion.NuevoRegistro : ModoEdicion.Actualizacion;

                        CtrlFactura.actualizarestado(); // Actualizar el estado de las facturas
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


        private void btnListarEstu_Click(object sender, EventArgs e)
        {
            this.LoadForm(new FrmListadoSesiones());
        }

        private DataTable registrosFiltrados;

        private DataTable registrosFiltrados2;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscar.Text;
            Sesiones sesion = CtrlSesion.buscar(codigo);

            if (sesion != null)
            {
                int FacturaIdSeleccionado = sesion.FacturaId;
                int trabajadorIdSeleccionado = sesion.TrabajadorId;

                datafecha.Value = sesion.fecha_Sesion;

                // Buscar el trabajador correspondiente por ID
                Trabajadores trabajadorSeleccionado = Ctrltrabajador.buscarporId(trabajadorIdSeleccionado);
                Facturas facturaseleccionado = CtrlSesion.ObtenerFacturasid(FacturaIdSeleccionado);

                if (trabajadorSeleccionado != null && facturaseleccionado != null)
                {
                    // Crear un DataTable con una única fila para el trabajador seleccionado
                    registrosFiltrados = new DataTable();
                    registrosFiltrados.Columns.Add("Id", typeof(int));
                    registrosFiltrados.Columns.Add("Nombre", typeof(string));
                    registrosFiltrados.Rows.Add(trabajadorSeleccionado.Id, trabajadorSeleccionado.nom_Trabajador);

                    // Crear un DataTable con una única fila para la factura seleccionada
                    registrosFiltrados2 = new DataTable();
                    registrosFiltrados2.Columns.Add("Id", typeof(int));
                    registrosFiltrados2.Columns.Add("Factura", typeof(string));
                    registrosFiltrados2.Rows.Add(facturaseleccionado.Id, facturaseleccionado.cod_Factura);

                    // Asignar el DataTable como origen de datos del ComboBox
                    cmbtrabajador.DataSource = registrosFiltrados;
                    cmbtrabajador.DisplayMember = "Nombre";
                    cmbtrabajador.ValueMember = "Id";
                    // Establecer el trabajador seleccionado como el valor seleccionado en el ComboBox
                    cmbtrabajador.SelectedValue = trabajadorSeleccionado.Id;

                    cmbfactura.DataSource = registrosFiltrados2;
                    cmbfactura.DisplayMember = "Factura";
                    cmbfactura.ValueMember = "Id";
                    // Establecer la factura seleccionada como el valor seleccionado en el ComboBox
                    cmbfactura.SelectedValue = facturaseleccionado.Id;
                }

                modoEdicion = ModoEdicion.Actualizacion;
            }
            else
            {
                MessageBox.Show("Registro: " + txtBuscar.Text + " no encontrado. Verifique que el valor es correcto", "Buscar Trabajador", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
