using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;

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
                    return nuevoCodigo;
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
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection()) // establecer el acceso a la capa de abstraccion de la db
            {

                if (string.IsNullOrEmpty(ses.cod_Sesion))
                {
                    // Generar un nuevo código de estudiante automáticamente
                    ses.cod_Sesion = GenerarCodigoSesion();
                }
                else
                {
                    // verificar si la sesion existe
                    Sesiones SesionExistente = ctx.Sesiones.FirstOrDefault(e => e.cod_Sesion == ses.cod_Sesion);
                    // si la sesion no es null , pues toma ese objeto sesion y actualiza sus propiedades
                    if (SesionExistente != null)
                    {
                        // Actualizar los valores dela sesion existente con los valores de la instancia "ses"
                        SesionExistente.cod_Sesion = ses.cod_Sesion;
                        SesionExistente.fecha_Sesion = ses.fecha_Sesion;
                        SesionExistente.cantHoras_Sesion = ses.cantHoras_Sesion;
                        SesionExistente.TrabajadorId = ses.TrabajadorId;
                        SesionExistente.FacturaId = ses.FacturaId;
                    }
                    else // si el objeto sesiones es null eso quiere decir que no existe y crea el nuevo registro
                    {
                        // Crear un nuevo estudiante en la base de datos
                        ctx.Sesiones.Add(ses);
                    }
                }
                try // en una variable asignamos el cambio
                {
                    val = ctx.SaveChanges();
                }
                catch // excepciones
                {
                    throw new ArgumentNullException();
                    throw new InvalidCastException();
                    throw new System.Data.Entity.Infrastructure.DbUpdateException();
                }
            }
            return val;
        }


        public List<dynamic> ObtenerFacturas()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var facturas = (from f in ctx.Facturas
                                join a in ctx.Alumnos on f.AlumnoId equals a.Id
                                join es in ctx.EstadosSesiones on f.EstadoSesionId equals es.Id
                                where es.Id == 1 // Filtrar por el estado de sesión deseado (1 en este caso)
                                select new
                                {
                                    FacturaId = f.Id,
                                    CodigoFactura = f.cod_Factura,
                                    nombre = a.nom_Alumno,
                                }).ToList();

                return facturas.Select(f => (dynamic)new
                {
                    FacturaId = f.FacturaId,
                    CodigoFactura = f.CodigoFactura,
                    nombre = f.nombre
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

