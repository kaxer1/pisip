﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infra.DataAccess
{
    using Dominio.Model.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class pisipEntities : DbContext
    {
        public pisipEntities()
            : base("name=pisipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TGENCANALES> TGENCANALES { get; set; }
        public virtual DbSet<TGENCOMPANIA> TGENCOMPANIA { get; set; }
        public virtual DbSet<TSEGPOLITICA> TSEGPOLITICA { get; set; }
        public virtual DbSet<TSEGUSUARIO> TSEGUSUARIO { get; set; }
        public virtual DbSet<TSEGUSUARIODETALLE> TSEGUSUARIODETALLE { get; set; }
        public virtual DbSet<TSEGUSUARIODETALLEHIST> TSEGUSUARIODETALLEHIST { get; set; }
        public virtual DbSet<TSEGUSUARIOSESSION> TSEGUSUARIOSESSION { get; set; }
        public virtual DbSet<TSEGUSUARIOSESSIONHISTORIA> TSEGUSUARIOSESSIONHISTORIA { get; set; }
        public virtual DbSet<TSEGROL> TSEGROL { get; set; }
        public virtual DbSet<TSEGUSUARIOROL> TSEGUSUARIOROL { get; set; }
    }
}
