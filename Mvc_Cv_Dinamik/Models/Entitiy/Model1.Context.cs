﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Cv_Dinamik.Models.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Db_Cv_UdemyEntities2 : DbContext
    {
        public Db_Cv_UdemyEntities2()
            : base("name=Db_Cv_UdemyEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
        public virtual DbSet<Tbl_Deneyimler> Tbl_Deneyimler { get; set; }
        public virtual DbSet<Tbl_Egitim> Tbl_Egitim { get; set; }
        public virtual DbSet<Tbl_Hakkimda> Tbl_Hakkimda { get; set; }
        public virtual DbSet<Tbl_Hobiler> Tbl_Hobiler { get; set; }
        public virtual DbSet<Tbl_Iletisim> Tbl_Iletisim { get; set; }
        public virtual DbSet<Tbl_Sertifikalar> Tbl_Sertifikalar { get; set; }
        public virtual DbSet<Tbl_Yetenekler> Tbl_Yetenekler { get; set; }
        public virtual DbSet<Tbl_SosyalMedya> Tbl_SosyalMedya { get; set; }
    }
}
