using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Negocio;
using System;
using System.Collections.Generic;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlSesion
    {

        public static int Agregar(string codigo, DateTime fechaNac, int cantidad, int trabajadorid, int facturaId)
        {
            Sesion e = new Sesion(codigo, fechaNac, cantidad, trabajadorid, facturaId);
            return e.guardar();
        }

        public static List<Trabajadores> Obtenertrabajadores()
        {
            Sesion e = new Sesion();

            return e.ObtenerTrabajadores();
        }

        public static List<Facturas> ObtenerFacturas()
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

        public static List<Sesiones> Buscar()
        {
            Sesion e = new Sesion();

            return e.Leer();
        }
    }

}
