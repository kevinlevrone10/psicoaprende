using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Negocio;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlEstudiante
    {
        public static int Agregar(string codigo, string nombre, string apellido, DateTime fechaNac, string responsable, string telefono, string colegio, string grado, string domicilio, string evaluacion, int departamentoId, int municipioId)
        {
            Estudiante e = new Estudiante(codigo, nombre, apellido, fechaNac, responsable, telefono, colegio, grado, domicilio, evaluacion, departamentoId, municipioId);
            return e.guardar();
        }

        public static List<Departamentos> ObtenerDepartamentos()
        {
            Estudiante e = new Estudiante();
            return e.ObtenerDepartamentos();
        }
        public static List<Municipios> ObtenerMunicipiosPorDepartamento(int departamentoId)
        {
            Estudiante estudiante = new Estudiante();
            return estudiante.ObtenerMunicipiosPorDepartamento(departamentoId);
        }

        public static Alumnos buscar(string cod)
        {
            Estudiante e = new Estudiante();

            return e.ObtenerEstudiantePorCarnet(cod);

        }

        public static List<Alumnos> Buscar()
        {
            Estudiante e = new Estudiante();

            return e.Leer();
        }

    }
}
