using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace SistemaPsicoaprende.UI
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void CargarModalidades()
        {
            // Obtener la lista de modalidades desde el controlador
            List<Modalidades> modalidades = CtrlFactura.ObtenerModalidades();
            cmbmod.DisplayMember = "nom_Modalidad";
            cmbmod.ValueMember = "Id";
            cmbmod.DataSource = modalidades;
        }

 

        private void BtnEmitir_Click(object sender, EventArgs e)
        {

            Modalidades modalidaseleccionada = cmbmod.SelectedItem as Modalidades;

            DateTime fecha = Fecha.Value;


            if (modalidaseleccionada != null)
            {
                try
                {

                    if (dataGridView1.Rows.Count > 0)
                    {
                        decimal total = Convert.ToDecimal(dataGridView1.Rows[0].Cells[2].Value);

                        // Crear un objeto Factura con los valores de los campos del formulario
                        Factura facturas = new Factura(Convert.ToInt32(txtcant.Text), Convert.ToDouble(total), fecha, Convert.ToInt32(txtid.Text), modalidaseleccionada.Id);

                        // Guardar la factura en la base de datos

                        int resultado = facturas.GuardarFactura();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("calcule el total de la factura");
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

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            CargarModalidades();
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            string codigoAlumno = txtcod.Text; // Código del alumno buscado

            CtrlFactura factura = new CtrlFactura();
            Alumnos alumno = CtrlFactura.buscar(codigoAlumno);

            if (alumno != null)
            {
                txtest.Text = alumno.nom_Alumno;
                txtid.Text = alumno.Id.ToString(); // Asignar el Id del alumno a la propiedad AlumnoId en tu objeto Factura
            }
            else
            {
                txtest.Text = string.Empty; // Limpiar el TextBox si no se encontró un alumno
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private bool filaAgregada = false;

        private void Btncal_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
