using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Negocio;
using System.Collections.Generic;


namespace SistemaPsicoaprende.Controlador
{
    public class Ctrltrabajador
    {

        public static int Agregar(string codigo, string nombre, string apellido, string domicilio, string telefono, int profesionId, int DepartamentoId, int MunicipioId)
        {
            Trabajador e = new Trabajador(codigo, nombre, apellido, domicilio, telefono, profesionId, DepartamentoId, MunicipioId);
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

        public static List<Profesiones> ObtenerProfesiones()
        {
            Trabajador e = new Trabajador();
            return e.Obtenerprofesiones();
        }

        public static Trabajadores buscar(string cod)
        {
            Trabajador e = new Trabajador();

            return e.ObtenerTrabajador(cod);
        }

        public static Trabajadores buscarporId(int id)
        {
            Trabajador e = new Trabajador();

            return e.ObtenerTrabajadorId(id);
        }
        public static List<Trabajadores> Buscar()
        {
            Trabajador e = new Trabajador();

            return e.Leer();
        }

    }
}
