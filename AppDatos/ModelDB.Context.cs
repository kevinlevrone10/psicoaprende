﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemaPsicoaprendeConnection : DbContext
    {
        public SistemaPsicoaprendeConnection()
            : base("name=SistemaPsicoaprendeConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alumnos> Alumnos { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<DetalleNominas> DetalleNominas { get; set; }
        public virtual DbSet<EstadoAlumnos> EstadoAlumnos { get; set; }
        public virtual DbSet<EstadosSesiones> EstadosSesiones { get; set; }
        public virtual DbSet<EstadoTrabajadores> EstadoTrabajadores { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Modalidades> Modalidades { get; set; }
        public virtual DbSet<Municipios> Municipios { get; set; }
        public virtual DbSet<Nominas> Nominas { get; set; }
        public virtual DbSet<Profesiones> Profesiones { get; set; }
        public virtual DbSet<Sesiones> Sesiones { get; set; }
        public virtual DbSet<Trabajadores> Trabajadores { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
