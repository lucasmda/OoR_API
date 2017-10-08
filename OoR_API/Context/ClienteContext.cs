using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Models;


namespace OoR_API.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("oor")
        {
            Database.SetInitializer(new ClienteDBInitializercs());
        }

        public DbSet<Cliente> clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}