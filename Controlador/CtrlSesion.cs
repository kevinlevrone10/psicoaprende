using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlSesion
    {

        public static int Agregar(string codigo, DateTime fechaNac, int trabajadorid, int facturaId)
        {
            Sesion e = new Sesion(codigo, fechaNac, trabajadorid, facturaId);
            return e.guardar();
        }

        public static List<Trabajadores> Obtenertrabajadores()
        {
            Sesion e = new Sesion();

            return e.ObtenerTrabajadores();
        }

        public static List<dynamic> ObtenerFacturas()
        {
            Sesion e = new Sesion();
            return e.ObtenerFacturas();
        }

        public static Facturas ObtenerFacturasid(int id)
        {
            Sesion e = new Sesion();

            return e.ObtenerfacturasporId(id);
        }

        public static Sesiones buscar(string cod)
        {
            Sesion e = new Sesion();

            return e.ObtenerSesion(cod);

        }

        public List<dynamic> Buscar()
        {
            Sesion sesion = new Sesion();
            return sesion.Leer();
        }

    }

}
