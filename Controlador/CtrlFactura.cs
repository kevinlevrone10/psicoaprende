using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlFactura
    {
        public int Agregar(int cantSesiones, float costo, DateTime fecha, int alumnoId, int modalidadId)
        {

            Factura f = new Factura(cantSesiones, costo, fecha, alumnoId, modalidadId);

            return f.GuardarFactura();
        }

        public static List<Modalidades> ObtenerModalidades()
        {
            Factura f = new Factura();
            return f.ObtenerModalidades();
        }

        public static Alumnos buscar(string cod)
        {
            Factura f = new Factura();

            return f.ObtenerEstudiantePorCarnet(cod);

        }


        public static bool VerificarCumplimientoSesiones(int facturaId)
        {
            Factura f = new Factura();

            return f.SeCumplieronSesiones(facturaId);
        }


    }
}
