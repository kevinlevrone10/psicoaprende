using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPsicoaprende.Negocio
{
    public class Trabajador
    {

        private Trabajadores tra;//definir una instancia de la capa de datos Alumnos


        public Trabajador()
        {

        }

        public Trabajador(string codigo, string nombre, string apellido, string domicilio, string telefono, int profesionId, int DepartamentoId, int MunicipioId)
        {
            tra = new Trabajadores();

            tra.cod_Trabajador = codigo;
            tra.nom_Trabajador = nombre;
            tra.ape_Trabajador = apellido;
            tra.domicilio_Trabajador = domicilio;
            tra.telefono_Trabajador = telefono;
            tra.ProfesionId = profesionId;
            tra.DepartamentoId = DepartamentoId;
            tra.MunicipioId = MunicipioId;
            tra.EstadoTrabajadorId = 1;

        }

        public int guardar()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection()) // establecer el acceso a la capa de abstraccion de la db
            {
                // Buscar el trabajador existente por su código de alumno
                Trabajadores trabajadorExistente = ctx.Trabajadores.FirstOrDefault(e => e.cod_Trabajador == tra.cod_Trabajador);


                // si el trabajador no es null , pues toma ese objeto trabajador y actualiza sus propiedades
                if (trabajadorExistente != null)
                {
                    // Actualizar los valores del trabajador existente con los valores de la instancia "est"
                    trabajadorExistente.nom_Trabajador = tra.nom_Trabajador;
                    trabajadorExistente.ape_Trabajador = tra.ape_Trabajador;
                    trabajadorExistente.domicilio_Trabajador = tra.domicilio_Trabajador;
                    trabajadorExistente.telefono_Trabajador = tra.telefono_Trabajador;
                    trabajadorExistente.ProfesionId = tra.ProfesionId;
                    trabajadorExistente.DepartamentoId = tra.DepartamentoId;
                    trabajadorExistente.MunicipioId = tra.MunicipioId;
                    trabajadorExistente.EstadoTrabajadorId = tra.EstadoTrabajadorId;

                }
                else // si el objeto   trabajador  es null eso quiere decir que no existe y crea el nuevo registro
                {
                    // Crear un nuevo trabajador en la base de datos
                    ctx.Trabajadores.Add(tra);
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


        public List<Departamentos> ObtenerDepartamentos()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con los departamentos
                return ctx.Departamentos.ToList<Departamentos>();
            }
        }

        public List<Profesiones> Obtenerprofesiones()
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                // retornamos la lista con los departamentos
                return ctx.Profesiones.ToList<Profesiones>();
            }
        }

        public List<Municipios> ObtenerMunicipiosPorDepartamento(int departamentoId)
        {

            // establecemos el acceso a la capa de abstraccion de las entidades
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {

                // hacemos la consulta para seleccionarlos con inner join porque departamentos es fk en municipios
                var query = from m in ctx.Municipios
                            join d in ctx.Departamentos on m.DepartamentoId equals d.Id
                            where d.Id == departamentoId
                            select m;

                return query.ToList(); // retorna la lista con los municipios
            }
        }

        public Trabajadores ObtenerTrabajador(string codigo)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el trabajador si existe , si existe pues retornaremos el objeto con sus atributos
            Trabajadores trabajador = ctx.Trabajadores.FirstOrDefault(e => e.cod_Trabajador == codigo);

            return trabajador; // retornando el objeto
        }

        public Trabajadores ObtenerTrabajadorId(int id)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el trabajador si existe , si existe pues retornaremos el objeto con sus atributos
            Trabajadores trabajador = ctx.Trabajadores.FirstOrDefault(e => e.Id == id);

            return trabajador; // retornando el objeto
        }




        public List<Trabajadores> Leer()
        {
            //Establecer el contexto de la conexion 
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            //Hacer la consulta del estudiante a filtrar
            var Listtrabajadores = ctx.Trabajadores.Select(e => new
            {
                id = e.Id,
                Codigo = e.cod_Trabajador,
                Nombres = e.nom_Trabajador,
                Apellido = e.ape_Trabajador,
                Telefono = e.telefono_Trabajador
            }).ToList().Select(e => new Trabajadores()
            {
                Id = e.id,
                cod_Trabajador = e.Codigo,
                nom_Trabajador = e.Nombres,
                ape_Trabajador = e.Apellido,
                telefono_Trabajador = e.Telefono

            });
            return Listtrabajadores.ToList(); //retornar la lista trabajadores
        }

    }
}
