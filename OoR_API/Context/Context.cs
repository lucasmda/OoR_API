using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Models;


namespace OoR_API.Context
{
    public class Context : DbContext
    {
        public Context() : base("oor")
        {
            Database.SetInitializer(new DBInitializercs());
        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Divida> dividas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}