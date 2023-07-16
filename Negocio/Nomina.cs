using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
public class Nomina
{
    private Nominas nomina;

    public Nomina()
    {
    }

    public Nomina(DateTime pagoDesde, DateTime pagoHasta, DateTime fechaPago)
    {
        nomina = new Nominas
        {
            pagoDesde_Nomina = pagoDesde,
            pagoHasta_Nomina = pagoHasta,
            fechaPago_Nomina = fechaPago
        };
    }

    public int AgregarNomina(List<DetalleNominas> lst)
    {
        int val = 0;
        using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
        {
            ctx.Nominas.Add(nomina);
            val = ctx.SaveChanges();
            if (val > 0)
            {
                foreach (DetalleNominas detalle in lst)
                {
                    DetalleNominas dn = new DetalleNominas
                    {
                        NominaId = nomina.Id,
                        trabajador = detalle.trabajador,
                        total_Horas = detalle.total_Horas,
                        total = detalle.total,
                        salario_Neto = detalle.salario_Neto,
                        viaticos = detalle.viaticos
                    };
                    ctx.DetalleNominas.Add(dn);
                }
                val += ctx.SaveChanges();
                // Calcular el total pagado y actualizar el campo en la tabla Nominas
                double totalPagado = lst.Sum(detalle => detalle.salario_Neto);
                nomina.totalpago_Nomina = totalPagado;
                ctx.SaveChanges();
            }
        }
        return val;
    }

    public List<dynamic> ObtenerDetallesNominaPorFechaPago(DateTime fechaPago)
    {
        using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
        {
            var detallesNomina = from n in ctx.Nominas
                                 join d in ctx.DetalleNominas on n.Id equals d.NominaId
                                 where n.fechaPago_Nomina == fechaPago
                                 select new
                                 {
                                     d.trabajador,
                                     d.total,
                                     d.total_Horas,
                                     d.viaticos,
                                     d.salario_Neto
                                 };
            return detallesNomina.ToList<dynamic>();
        }
    }

    public List<dynamic> obtenerNominaporFecgaPago(DateTime fechapago)
    {
        using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
        {
            var Nomina = from n in ctx.Nominas
                         where n.fechaPago_Nomina == fechapago
                         select new
                         {
                             n.totalpago_Nomina,
                             n.fechaPago_Nomina
                         };

            return Nomina.ToList<dynamic>();
        }

    }

    public List<dynamic> ObtenerHorasTrabajadas(DateTime fechaDesde, DateTime fechaHasta)
    {
        using (SistemaPsicoaprendeConnection ctx = new SistemaPsicoaprendeConnection())
        {
            var trabajadores = ctx.Sesiones
                .Where(s => s.fecha_Sesion >= fechaDesde && s.fecha_Sesion <= fechaHasta)
                .Join(ctx.Trabajadores, s => s.TrabajadorId, t => t.Id, (s, t) => new
                {
                    NombreTrabajador = t.nom_Trabajador + " " + t.ape_Trabajador,
                    HorasTrabajadas = 2 // Suponiendo que cada sesión dura 2 horas
                })
                .GroupBy(t => t.NombreTrabajador)
                .Select(g => new
                {
                    NombreTrabajador = g.Key,
                    HorasTrabajadas = g.Sum(t => t.HorasTrabajadas)
                })
                .ToList();

            // Convertir la lista de objetos anónimos a una lista de tipo dynamic
            List<dynamic> listaHorasTrabajadas = trabajadores.Cast<dynamic>().ToList();

            return listaHorasTrabajadas;
        }

    }
}

