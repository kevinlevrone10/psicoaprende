//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaPsicoaprende.AppDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleNominas
    {
        public int Id { get; set; }
        public string trabajador { get; set; }
        public decimal total { get; set; }
        public int total_Horas { get; set; }
        public decimal viaticos { get; set; }
        public double salario_Neto { get; set; }
        public int NominaId { get; set; }
    
        public virtual Nominas Nominas { get; set; }
    }
}
