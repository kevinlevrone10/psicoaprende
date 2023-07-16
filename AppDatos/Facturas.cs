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
    
    public partial class Facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas()
        {
            this.Sesiones = new HashSet<Sesiones>();
        }
    
        public int Id { get; set; }
        public string cod_Factura { get; set; }
        public int cantSesiones_Factura { get; set; }
        public double costo_Factura { get; set; }
        public System.DateTime fecha_Factura { get; set; }
        public int AlumnoId { get; set; }
        public int ModalidadId { get; set; }
        public int EstadofacturaId { get; set; }
        public string EstadoSesiones { get; set; }
        public double costoTotal_Factura { get; set; }
    
        public virtual Alumnos Alumnos { get; set; }
        public virtual EstadoFactura EstadoFactura { get; set; }
        public virtual Modalidades Modalidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sesiones> Sesiones { get; set; }
    }
}
