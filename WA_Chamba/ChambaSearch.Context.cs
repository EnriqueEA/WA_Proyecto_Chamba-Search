﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WA_Chamba
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_ChambaSearchEntities : DbContext
    {
        public DB_ChambaSearchEntities()
            : base("name=DB_ChambaSearchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comentario> comentario { get; set; }
        public virtual DbSet<departamento> departamento { get; set; }
        public virtual DbSet<detalleServicio> detalleServicio { get; set; }
        public virtual DbSet<distrito> distrito { get; set; }
        public virtual DbSet<documento> documento { get; set; }
        public virtual DbSet<documentoValidacion> documentoValidacion { get; set; }
        public virtual DbSet<imagen> imagen { get; set; }
        public virtual DbSet<persona> persona { get; set; }
        public virtual DbSet<provincia> provincia { get; set; }
        public virtual DbSet<servicio> servicio { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipoCuenta> tipoCuenta { get; set; }
        public virtual DbSet<tiposervicio> tiposervicio { get; set; }
    }
}
