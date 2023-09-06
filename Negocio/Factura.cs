using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
                    return nuevoCodigo.ToUpper();
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
            fac.cod_Factura = GenerarCodigoFactura().ToUpper();
            fac.cantSesiones_Factura = cantSesiones;
            fac.costo_Factura = costo;
            fac.fecha_Factura = fecha;
            fac.AlumnoId = alumnoId;
            fac.ModalidadId = modalidadId;
            fac.EstadoSesiones = "En curso".ToUpper();
            fac.EstadofacturaId = 1;
        }

        public int GuardarFactura()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // Generar un nuevo código de factura automáticamente
                fac.cod_Factura = GenerarCodigoFactura();
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

        public int EditarFactura(string codigoFactura)
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // Verificar si la factura existente ya tiene ese código
                Facturas facturaexistente = ctx.Facturas.FirstOrDefault(e => e.cod_Factura == codigoFactura);

                if (facturaexistente != null)
                {
                    facturaexistente.cantSesiones_Factura = fac.cantSesiones_Factura;
                    facturaexistente.costo_Factura = fac.costo_Factura;
                    facturaexistente.fecha_Factura = fac.fecha_Factura;
                    facturaexistente.AlumnoId = fac.AlumnoId;
                    facturaexistente.ModalidadId = fac.ModalidadId;
                    facturaexistente.EstadoSesiones = facturaexistente.EstadoSesiones;
                    facturaexistente.EstadoFactura = facturaexistente.EstadoFactura;

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

        public Facturas ObtenerFacturas(string cod)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el alumno si existe , si existe pues retornaremos el objeto con sus atributos
           Facturas facturas = ctx.Facturas.FirstOrDefault(e => e.cod_Factura== cod);

            return facturas; // retornando el objeto
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
                        factura.EstadoSesiones = "Terminado".ToUpper();
                    }
                    else
                    {
                        factura.EstadoSesiones = "En curso".ToUpper();
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

        public List<dynamic> ObtenerTotalFacturasPorAño(int año)
        {
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            var totalFacturas = ctx.Facturas
                .Where(f => f.fecha_Factura.Year == año)
                .Sum(f => (double?)f.costoTotal_Factura);

            double total = totalFacturas ?? 0;

            var resultado = new List<dynamic>()
         {
        new
        {
            Total = total
        }
        };

            return resultado;
        }


        public List<dynamic> ObtenerTotalFacturasPorMes(int año)
        {
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();
            var query = (from factura in ctx.Facturas
                         where factura.fecha_Factura.Year == año
                         group factura by factura.fecha_Factura.Month into grupo
                         select new
                         {
                             fecha_Factura = grupo.Key,
                             costo_Factura = grupo.Sum(f => f.costoTotal_Factura)
                         }).OrderBy(x => x.fecha_Factura).ToList();

            var resultados = query.Select(x => new
            {
                fecha_Factura = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(x.fecha_Factura),
                costo_Factura = x.costo_Factura
            }).ToList();

            return resultados.ToList<dynamic>();
        }

        public List<dynamic> obtenerEgresos(int año)
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var totalEgresos = ctx.Nominas
                    .Where(n => n.fechaPago_Nomina.Year == año)
                    .Sum(n => (double?)n.totalpago_Nomina);

                double Egresos = totalEgresos ?? 0;

                var resultado = new List<dynamic>()
        {
            new
            {
                totalpago_Nomina = Egresos
            }
        };

                return resultado;
            }
        }


        public List<dynamic> CalcularGanancias(int año)
        {
            List<dynamic> ingresos = ObtenerTotalFacturasPorAño(año);
            List<dynamic> egresos = obtenerEgresos(año);

            // Sumar los ingresos
            double totalIngresos = ingresos.Sum(x => (double)x.Total);

            // Sumar los egresos
            double totalEgresos = egresos.Sum(x => (double)x.totalpago_Nomina);

            // Calcular las ganancias
            double ganancias = totalIngresos - totalEgresos;

            // Crear una lista dinámica con el resultado
            List<dynamic> resultado = new List<dynamic>()
            {
             new
            {
            costoTotal_Factura = ganancias
            }
            };
            return resultado;
        }


        public List<dynamic> Leer()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var facturas = ctx.Facturas.Select(f => new
                {
                    codigoFactura = f.cod_Factura,
                    fechaFactura = f.fecha_Factura,
                    costoTotal = f.costoTotal_Factura,
                    estadoSesiones = f.EstadoSesiones
                }).ToList();

                return facturas.Cast<dynamic>().ToList();
            }
        }


    }
}
