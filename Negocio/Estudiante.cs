using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPsicoaprende.Negocio
{
    public class Estudiante
    {
        private Alumnos est;//definir una instancia de la capa de datos Alumnos

        public Estudiante() // constructor vacio
        {
        }

        // constructor con parametros
        public Estudiante(string codigo, string nombre, string apellido, DateTime fecha_nac, string responsable, string telefono, string colegio, string grado, string domicilio, string evaluacion, int departamentoId, int municipioId)
        {
            est = new Alumnos();
            est.cod_Alumno = codigo;
            est.nom_Alumno = nombre;
            est.ape_Alumno = apellido;
            est.fechaNac_Alumno = fecha_nac;
            est.nomResp_Alumno = responsable;
            est.telfResp_Alumno = telefono;
            est.colegio_Alumno = colegio;
            est.gradoAcad_Alumno = grado;
            est.domicilio_Alumno = domicilio;
            est.evaluacion_Alumno = evaluacion;
            est.DepartamentoId = departamentoId;
            est.MunicipioId = municipioId;
            est.EstadoAlumnoId = 1; // Asignas el estado como activo (1) por defecto
        }


        public int guardar()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection()) // establecer el acceso a la capa de abstraccion de la db
            {
                // Buscar el estudiante existente por su código de alumno
                Alumnos estudianteExistente = ctx.Alumnos.FirstOrDefault(e => e.cod_Alumno == est.cod_Alumno);


                // si el estudiante no es null , pues toma ese objeto estudiante y actualiza sus propiedades
                if (estudianteExistente != null)
                {
                    // Actualizar los valores del estudiante existente con los valores de la instancia "est"
                    estudianteExistente.nom_Alumno = est.nom_Alumno;
                    estudianteExistente.ape_Alumno = est.ape_Alumno;
                    estudianteExistente.fechaNac_Alumno = est.fechaNac_Alumno;
                    estudianteExistente.nomResp_Alumno = est.nomResp_Alumno;
                    estudianteExistente.telfResp_Alumno = est.telfResp_Alumno;
                    estudianteExistente.colegio_Alumno = est.colegio_Alumno;
                    estudianteExistente.gradoAcad_Alumno = est.gradoAcad_Alumno;
                    estudianteExistente.domicilio_Alumno = est.domicilio_Alumno;
                    estudianteExistente.evaluacion_Alumno = est.evaluacion_Alumno;
                    estudianteExistente.DepartamentoId = est.DepartamentoId;
                    estudianteExistente.MunicipioId = est.MunicipioId;
                    estudianteExistente.EstadoAlumnoId = est.EstadoAlumnoId;
                }
                else // si el objeto estudiante es null eso quiere decir que no existe y crea el nuevo registro
                {
                    // Crear un nuevo estudiante en la base de datos
                    ctx.Alumnos.Add(est);
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

        // metodo para retornar una lista de municipios segun el departamento
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

        public Alumnos ObtenerEstudiantePorCarnet(string carnet)
        {
            // establecemos el acceso a la capa de abstraccion de las entidades
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            // buscamos el alumno si existe , si existe pues retornaremos el objeto con sus atributos
            Alumnos estudiante = ctx.Alumnos.FirstOrDefault(e => e.cod_Alumno == carnet);

            return estudiante; // retornando el objeto
        }

        public List<Alumnos> Leer()
        {
            //Establecer el contexto de la conexion 
            SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection();

            //Hacer la consulta del estudiante a filtrar
            var ListEstudiante = ctx.Alumnos.Select(e => new
            {
                Carnet = e.cod_Alumno,
                Nombres = e.nom_Alumno,
                Apellido = e.ape_Alumno,
                Fecha = e.fechaNac_Alumno,
                Telefono = e.telfResp_Alumno,
                Responsable = e.nomResp_Alumno,
                Domicilio = e.domicilio_Alumno,
            }).ToList().Select(e => new Alumnos()
            {
                cod_Alumno = e.Carnet,
                nom_Alumno = e.Nombres,
                ape_Alumno = e.Apellido,
                fechaNac_Alumno = e.Fecha,
                telfResp_Alumno = e.Telefono,
                nomResp_Alumno = e.Responsable,
                domicilio_Alumno = e.Domicilio,

            });
            return ListEstudiante.ToList(); //retornar la lista estudiante
        }//Fin del metodo
    }
}
