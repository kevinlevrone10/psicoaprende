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
    
    public partial class EstadoAlumnos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoAlumnos()
        {
            this.Alumnos = new HashSet<Alumnos>();
        }
    
        public int Id { get; set; }
        public string cod_EstadoAlumno { get; set; }
        public string nom_EstadoAlumno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumnos> Alumnos { get; set; }
    }
}
