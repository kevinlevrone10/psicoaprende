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
    
    public partial class Sesiones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sesiones()
        {
            this.DetalleNominas = new HashSet<DetalleNominas>();
        }
    
        public int Id { get; set; }
        public string cod_Sesion { get; set; }
        public System.DateTime fecha_Sesion { get; set; }
        public int cantHoras_Sesion { get; set; }
        public int TrabajadorId { get; set; }
        public int FacturaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleNominas> DetalleNominas { get; set; }
        public virtual Facturas Facturas { get; set; }
        public virtual Trabajadores Trabajadores { get; set; }
    }
}
