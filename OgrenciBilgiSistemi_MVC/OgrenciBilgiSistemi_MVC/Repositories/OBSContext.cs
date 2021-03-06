﻿using Microsoft.AspNet.Identity.EntityFramework;
using OgrenciBilgiSistemi_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi_MVC.Repositories
{
    public class OBSContext:DbContext
    {
        public OBSContext() : base("OBSVeritabani") { }

        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Donem> Donemler { get; set; }
        public DbSet<DonemDers> DonemDersler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciDonemDers> OgrenciDonemDersler { get; set; }
        public DbSet<OgretimGorevlisi> OgretimGorevlileri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
    public class OBSIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public OBSIdentityContext() : base("OBSVeritabani") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
