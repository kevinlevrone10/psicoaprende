using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;

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
            fac.EstadoSesionId = 1;
        }

        public int GuardarFactura()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                ctx.Facturas.Add(fac);

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

        public void ActualizarEstadoFacturas()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // Obtener todas las facturas en curso
                List<Facturas> facturasEnCurso = ctx.Facturas.Where(f => f.EstadoSesionId == 1).ToList();

                foreach (Facturas factura in facturasEnCurso)
                {
                    // Verificar si se han cumplido las sesiones de la factura
                    if (SeCumplieronSesiones(factura.Id))
                    {
                        // Cambiar el estado de la factura a "finalizada"
                        factura.EstadoSesionId = 2;
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

                    if (sesionesRealizadas >= sesionesContratadas)
                    {
                        return true;
                    }
                }
            }

            return false;
        }







    }
}
