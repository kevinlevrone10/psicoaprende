using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaPsicoaprende.Negocio
{
    public class Factura
    {
        private Facturas fac;

        //constructor vacio
        public Factura() { }

        // generar el codigo para factura
        private static string GenerarCodigoFactura()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var ultimaFactura = ctx.Facturas.OrderByDescending(f => f.Id).FirstOrDefault();
                if (ultimaFactura != null)
                {
                    // Extraer el número del último código de factura
                    string ultimoCodigo = ultimaFactura.cod_Factura;
                    int ultimoNumero = int.Parse(ultimoCodigo.Substring(3));

                    // Incrementar el número del código y generar el nuevo código
                    int nuevoNumero = ultimoNumero + 1;
                    string nuevoCodigo = "FAC" + nuevoNumero.ToString("D3");
                    return nuevoCodigo;
                }
                else
                {
                    return "FAC001";
                }
            }
        }

        //constructor con parametros
        public Factura(int cantSesiones, double costo, DateTime fecha, int alumnoId, int modalidadId)
        {
            fac = new Facturas();
            fac.cod_Factura = GenerarCodigoFactura();
            fac.cantSesiones_Factura = cantSesiones;
            fac.costo_Factura = costo;
            fac.fecha_Factura = fecha;
            fac.AlumnoId = alumnoId;
            fac.ModalidadId = modalidadId;
            fac.EstadoSesionId = "En curso";
            fac.EstadofacturaId= 1;
        }

        public int GuardarFactura()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {

                if (string.IsNullOrEmpty(fac.cod_Factura))
                {
                    // Generar un nuevo código de factura automáticamente
                    fac.cod_Factura = GenerarCodigoFactura();
                }
                else
                {
                    // Verificar si la factura existente ya tiene ese código
                    Facturas facturaexistente = ctx.Facturas.FirstOrDefault(e => e.cod_Factura == fac.cod_Factura);

                    if (facturaexistente != null)
                    {
                        facturaexistente.cantSesiones_Factura = fac.cantSesiones_Factura;
                        facturaexistente.costo_Factura = fac.costo_Factura;
                        facturaexistente.fecha_Factura = fac.fecha_Factura;
                        facturaexistente.AlumnoId = fac.AlumnoId;
                        facturaexistente.ModalidadId = fac.ModalidadId;
                        facturaexistente.EstadoSesionId = facturaexistente.EstadoSesionId;
                        facturaexistente.EstadoFactura = facturaexistente.EstadoFactura;
                    }
                    else
                    {
                        ctx.Facturas.Add(fac);
                    }
                }
                try
                {
                    val = ctx.SaveChanges();
                }
                catch
                {
                    throw new ArgumentNullException();
                    throw new InvalidCastException();
                    throw new System.Data.Entity.Infrastructure.DbUpdateException();
                }

            }
            return val;
        }

        public List<Modalidades> ObtenerModalidades()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con las modalidades
                return ctx.Modalidades.ToList<Modalidades>();
            }
        }

        public Alumnos ObtenerEstudiantePorCarnet(string carnet)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el alumno si existe , si existe pues retornaremos el objeto con sus atributos
            Alumnos estudiante = ctx.Alumnos.FirstOrDefault(e => e.cod_Alumno == carnet);

            return estudiante; // retornando el objeto
        }

        public Facturas ObtenerfacturaporId(int id)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos la factura si existe , si existe pues retornaremos el objeto con sus atributos
            Facturas factura = ctx.Facturas.FirstOrDefault(e => e.Id == id);

            return factura; // retornando el objeto
        }

        public void ActualizarEstadoFacturas()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                List<Facturas> facturas = ctx.Facturas.ToList();

                foreach (Facturas factura in facturas)
                {
                    bool todasSesionesRealizadas = SeCumplieronSesiones(factura.Id);

                    if (todasSesionesRealizadas)
                    {
                        factura.EstadoSesionId = "Terminado";
                    }
                    else
                    {
                        factura.EstadoSesionId = "En curso";
                    }
                   
                }

                ctx.SaveChanges(); // Guardar los cambios en la base de datos
            }
        }




        public bool SeCumplieronSesiones(int facturaId)
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                Facturas factura = ctx.Facturas.FirstOrDefault(f => f.Id == facturaId);

                if (factura != null)
                {
                    int sesionesContratadas = factura.cantSesiones_Factura;
                    int sesionesRealizadas = ctx.Sesiones.Count(s => s.FacturaId == facturaId);

                    if (sesionesRealizadas == sesionesContratadas)
                    {
                        // Todas las sesiones contratadas ya se han realizado, incluyendo las nuevas sesiones
                        return true;
                    }
                }
            }

            return false;
        }





    }
}
