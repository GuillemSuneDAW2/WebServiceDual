﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSServer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GimnasAppEntities : DbContext
    {
        public GimnasAppEntities()
            : base("name=GimnasAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivitatDirigida> ActivitatDirigidas { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Benefici> Beneficis { get; set; }
        public virtual DbSet<CategoriaActivitat> CategoriaActivitats { get; set; }
        public virtual DbSet<CategoriaProfesional> CategoriaProfesionals { get; set; }
        public virtual DbSet<Dia> Dias { get; set; }
        public virtual DbSet<DiaNoHabil> DiaNoHabils { get; set; }
        public virtual DbSet<Esdeveniment> Esdeveniments { get; set; }
        public virtual DbSet<Hora> Horas { get; set; }
        public virtual DbSet<Inscripcions1> Inscripcions1 { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Sessio> Sessios { get; set; }
        public virtual DbSet<Soci> Socis { get; set; }
        public virtual DbSet<Treballador> Treballadors { get; set; }
        public virtual DbSet<SessioView> SessioViews { get; set; }
    }
}
