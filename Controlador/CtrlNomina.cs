using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlNomina
    {
      
            public  static int AgregarNomina(DateTime pagoDesde, DateTime pagoHasta, DateTime fechaPago, List<DetalleNominas> detalles)
            {
                Nomina nomina = new Nomina(pagoDesde, pagoHasta, fechaPago);

                return nomina.AgregarNomina(detalles);
            }


        public static List<dynamic> filtradohoras(DateTime inicio , DateTime final)
        {
            Nomina n = new Nomina();
            return n.ObtenerHorasTrabajadas(inicio, final);
        }





    }
}
