using ClimaTempoSimples.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Migrations;

using System.Linq;
using System.Web;

namespace ClimaTempoSimples.Dao
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFConnectionString") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }

    }
}