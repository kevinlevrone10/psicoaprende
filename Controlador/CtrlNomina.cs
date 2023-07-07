using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlNomina
    {

        public static int AgregarNomina(DateTime pagoDesde, DateTime pagoHasta, DateTime fechaPago, List<DetalleNominas> detalles)
        {
            Nomina nomina = new Nomina(pagoDesde, pagoHasta, fechaPago);

            return nomina.AgregarNomina(detalles);
        }

        public static List<dynamic> filtradohoras(DateTime inicio, DateTime final)
        {
            Nomina n = new Nomina();
            return n.ObtenerHorasTrabajadas(inicio, final);
        }
    }
}
