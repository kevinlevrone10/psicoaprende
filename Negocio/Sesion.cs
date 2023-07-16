using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaPsicoaprende.Negocio
{
    public class Sesion
    {
        private Sesiones ses;//definir una instancia de la capa de datos Sesiones
        public Sesion()
        {

        }
        private string GenerarCodigoSesion()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // Obtener la última sesión registrada en la base de datos
                var ultimaSesion = ctx.Sesiones.OrderByDescending(s => s.Id).FirstOrDefault();
                if (ultimaSesion != null)
                {
                    // Extraer el número de la última sesión
                    string ultimoCodigo = ultimaSesion.cod_Sesion;
                    int ultimoNumero = int.Parse(ultimoCodigo.Substring(3));

                    // Incrementar el número del código y generar el nuevo código
                    int nuevoNumero = ultimoNumero + 1;
                    string nuevoCodigo = "SES" + nuevoNumero.ToString("D3");
                    return nuevoCodigo.ToUpper();
                }
                else
                {
                    // No hay sesiones registradas, generar el código inicial
                    return "SES001";
                }
            }
        }
        public Facturas ObtenerfacturasporId(int id)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos la factura  si existe , si existe pues retornaremos el objeto con sus atributos
            Facturas facts = ctx.Facturas.FirstOrDefault(e => e.Id == id);

            return facts; // retornando el objeto
        }
        public Sesion(string codigo, DateTime fecha, int trabajadorId, int FacturaId)
        {
            ses = new Sesiones();

            if (string.IsNullOrEmpty(codigo))
            {
                // Generar un nuevo código de sesion automáticamente
                ses.cod_Sesion = GenerarCodigoSesion();
            }
            else
            {
                // Utilizar el código existente para una actualización
                ses.cod_Sesion = codigo;
            }
            ses.fecha_Sesion = fecha;
            ses.cantHoras_Sesion = 2;
            ses.TrabajadorId = trabajadorId;
            ses.FacturaId = FacturaId;
        }
        public int guardar()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                if (string.IsNullOrEmpty(ses.cod_Sesion))
                {
                    ses.cod_Sesion = GenerarCodigoSesion();
                }
                else
                {
                    Sesiones sesionExistente = ctx.Sesiones.FirstOrDefault(e => e.cod_Sesion == ses.cod_Sesion);

                    if (sesionExistente != null)
                    {
                        sesionExistente.fecha_Sesion = ses.fecha_Sesion;
                        sesionExistente.cantHoras_Sesion = ses.cantHoras_Sesion;
                        sesionExistente.TrabajadorId = ses.TrabajadorId;
                        sesionExistente.FacturaId = ses.FacturaId;
                    }
                    else
                    {
                        ctx.Sesiones.Add(ses);
                    }
                }

                try
                {
                    val = ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error al guardar el registro: " + ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return val;
        }
        public List<dynamic> ObtenerFacturas()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var facturas = ctx.Facturas
                    .Join(
                        ctx.Alumnos,
                        f => f.AlumnoId,
                        a => a.Id,
                        (f, a) => new
                        {
                            Factura = f,
                            Alumno = a
                        }
                    )
                    .GroupBy(
                        fa => fa.Alumno.Id,
                        fa => fa.Factura,
                        (alumnoId, facturasGrupo) => new
                        {
                            AlumnoId = alumnoId,
                            FacturaReciente = facturasGrupo.OrderByDescending(f => f.fecha_Factura).FirstOrDefault()
                        }
                    )
                    .Select(fa => new
                    {
                        FacturaId = fa.FacturaReciente.Id,
                        CodigoFactura = fa.FacturaReciente.cod_Factura,
                        Nombre = fa.FacturaReciente.Alumnos.nom_Alumno
                    })
                    .ToList();

                return facturas.Select(f => (dynamic)new
                {
                    FacturaId = f.FacturaId,
                    CodigoFactura = f.CodigoFactura,
                    Nombre = f.Nombre
                }).ToList();
            }
        }
        public List<Trabajadores> ObtenerTrabajadores()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con los trabajadores
                return ctx.Trabajadores.ToList<Trabajadores>();
            }
        }
        public Sesiones ObtenerSesion(string codigo)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos la sesion si existe , si existe pues retornaremos el objeto con sus atributos
            Sesiones sesion = ctx.Sesiones.FirstOrDefault(e => e.cod_Sesion == codigo);

            return sesion; // retornando el objeto
        }
        public List<dynamic> Leer()
        {
            // Establecer el contexto de la conexión
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // Hacer la consulta y combinar las tablas mediante join
            var sesiones = (from s in ctx.Sesiones
                            join f in ctx.Facturas on s.FacturaId equals f.Id
                            join a in ctx.Alumnos on f.AlumnoId equals a.Id
                            select new
                            {
                                cod_Sesion = s.cod_Sesion,
                                cod_Alumno = a.cod_Alumno,
                                nombreAlumno = a.nom_Alumno,
                                fecha_Sesion = s.fecha_Sesion,
                                cantHoras_Sesion = s.cantHoras_Sesion

                            })
                            .GroupBy(s => s.cod_Alumno) // Agrupar por el código del alumno
                            .Select(g => new
                            {
                                cod_Alumno = g.Key,
                                sesiones = g.ToList()
                            })
                            .ToList();

            return sesiones.Cast<dynamic>().ToList();
        }

    }
}

