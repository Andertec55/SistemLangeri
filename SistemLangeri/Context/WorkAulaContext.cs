using MySql.Data.Entity;
using SistemLangeri.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SistemLangeri.Context
{


    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WorkAulaContext : DbContext
    {

        public WorkAulaContext() : base("BaseConnc")
        {

        }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Revendedor> Revendedor { get; set; }
        public DbSet<Estoque> Estoque { get; set; }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {


            ModelBuilder.Entity<Pessoa>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Pessoa");
            });


            ModelBuilder.Entity<Client>().Map(m =>
           {
               m.MapInheritedProperties();
               m.ToTable("Client");
           });

            ModelBuilder.Entity<Revendedor>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Revendedor");
            });


            ModelBuilder.Entity<Estoque>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Estoque");

            });
         



             base.OnModelCreating(ModelBuilder);
    }
}
}