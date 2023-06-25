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

        public Facturas ObtenerfacturasporId(int id)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos la factura  si existe , si existe pues retornaremos el objeto con sus atributos
            Facturas facts = ctx.Facturas.FirstOrDefault(e => e.Id == id);

            return facts; // retornando el objeto
        }

        public Sesion(string codigo, DateTime fecha, int cantidad, int trabajadorId, int FacturaId)
        {
            ses = new Sesiones();

            ses.cod_Sesion = codigo;
            ses.fecha_Sesion = fecha;
            ses.cantHoras_Sesion = cantidad;
            ses.TrabajadorId = trabajadorId;
            ses.FacturaId = FacturaId;
        }

        public int guardar()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection()) // establecer el acceso a la capa de abstraccion de la db
            {
                // Buscar a la sesion existente por su código de sesion
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


        public List<Facturas> ObtenerFacturas()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con los trabajadores
                return ctx.Facturas.ToList<Facturas>();
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

        public List<Sesiones> Leer()
        {
            //Establecer el contexto de la conexion 
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            //Hacer la consulta del estudiante a filtrar
            var ListSesiones = ctx.Sesiones.Select(e => new
            {
                Codido = e.cod_Sesion,
                fecha = e.fecha_Sesion,
                cantidad = e.cantHoras_Sesion,

            }).ToList().Select(e => new Sesiones()
            {
                cod_Sesion = e.Codido,
                fecha_Sesion = e.fecha,
                cantHoras_Sesion = e.cantidad

            });
            return ListSesiones.ToList(); //retornar la lista sesiones
        }//Fin del metodo

    }
}

