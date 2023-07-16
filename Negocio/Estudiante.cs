using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Data.Entity;

namespace SistemaPsicoaprende.Negocio
{
    public class Estudiante
    {
        private Alumnos est;//definir una instancia de la capa de datos Alumnos
        public Estudiante() // constructor vacio
        {
        }
        private string GenerarCodigoEstudiante()
        {
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                var ultimoEstudiante = ctx.Alumnos.OrderByDescending(e => e.Id).FirstOrDefault();
                if (ultimoEstudiante != null)
                {
                    // Extraer el número del último código de estudiante
                    string ultimoCodigo = ultimoEstudiante.cod_Alumno;
                    int ultimoNumero = int.Parse(ultimoCodigo.Substring(2));

                    // Incrementar el número del código y generar el nuevo código
                    int nuevoNumero = ultimoNumero + 1;
                    string nuevoCodigo = "AL" + nuevoNumero.ToString("D3");
                    return nuevoCodigo.ToUpper();
                }
                else
                {
                    return "AL001";
                }
            }
        }

        // constructor con parametros
        public Estudiante(string cod, string nombre, string apellido, DateTime fecha_nac, string responsable, string telefono, string colegio, string grado, string domicilio, string evaluacion, int departamentoId, int municipioId)
        {
            est = new Alumnos();

            if (string.IsNullOrEmpty(cod))
            {
                // Generar un nuevo código de estudiante automáticamente
                est.cod_Alumno = GenerarCodigoEstudiante().ToUpper();
            }
            else
            {
                // Utilizar el código existente para una actualización
                est.cod_Alumno = cod.ToUpper();
            }
            // Resto de asignaciones de propiedades
            est.nom_Alumno = RemoveAccentsAndSpecialCharacters(nombre.ToUpper());
            est.ape_Alumno = RemoveAccentsAndSpecialCharacters(apellido.ToUpper());
            est.fechaNac_Alumno = fecha_nac;
            est.nomResp_Alumno = RemoveAccentsAndSpecialCharacters(responsable.ToUpper());
            est.telfResp_Alumno = RemoveAccentsAndSpecialCharacters(telefono.ToUpper());
            est.colegio_Alumno = RemoveAccentsAndSpecialCharacters(colegio.ToUpper());
            est.gradoAcad_Alumno = RemoveAccentsAndSpecialCharacters(grado.ToUpper());
            est.domicilio_Alumno = RemoveAccentsAndSpecialCharacters(domicilio.ToUpper());
            est.evaluacion_Alumno = RemoveAccentsAndSpecialCharacters(evaluacion.ToUpper());
            est.DepartamentoId = departamentoId;
            est.MunicipioId = municipioId;
            est.EstadoAlumnoId = 1; // Asignas el estado como activo (1) por defecto
        }
        private string RemoveAccentsAndSpecialCharacters(string input)
        {
            string normalizedString = input.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex("[^a-zA-Z0-9 ]");
            string result = regex.Replace(normalizedString, "");
            return result;
        }
        public int guardar()
        {
            int val = 0;
            using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
            {
                if (string.IsNullOrEmpty(est.cod_Alumno))
                {
                    // Generar un nuevo código de estudiante automáticamente
                    est.cod_Alumno = GenerarCodigoEstudiante();
                }
                else
                {
                    // Verificar si el estudiante existente ya tiene ese código
                    Alumnos estudianteExistente = ctx.Alumnos.FirstOrDefault(e => e.cod_Alumno == est.cod_Alumno);
                    if (estudianteExistente != null)
                    {
                        // El código de estudiante ya existe, se trata de una actualización
                        estudianteExistente.nom_Alumno = RemoveAccentsAndSpecialCharacters(est.nom_Alumno.ToUpper());
                        estudianteExistente.ape_Alumno = RemoveAccentsAndSpecialCharacters(est.ape_Alumno.ToUpper());
                        estudianteExistente.fechaNac_Alumno = est.fechaNac_Alumno;
                        estudianteExistente.nomResp_Alumno = RemoveAccentsAndSpecialCharacters(est.nomResp_Alumno.ToUpper());
                        estudianteExistente.telfResp_Alumno = RemoveAccentsAndSpecialCharacters(est.telfResp_Alumno.ToUpper());
                        estudianteExistente.colegio_Alumno = RemoveAccentsAndSpecialCharacters(est.colegio_Alumno.ToUpper());
                        estudianteExistente.gradoAcad_Alumno = RemoveAccentsAndSpecialCharacters(est.gradoAcad_Alumno.ToUpper());
                        estudianteExistente.domicilio_Alumno = RemoveAccentsAndSpecialCharacters(est.domicilio_Alumno.ToUpper());
                        estudianteExistente.evaluacion_Alumno = RemoveAccentsAndSpecialCharacters(est.evaluacion_Alumno.ToUpper());
                        estudianteExistente.DepartamentoId = est.DepartamentoId;
                        estudianteExistente.MunicipioId = est.MunicipioId;
                        estudianteExistente.EstadoAlumnoId = est.EstadoAlumnoId;

                    }
                    else
                    {
                        // El código de estudiante no existe en la base de datos, es un nuevo registro
                        ctx.Alumnos.Add(est);
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
