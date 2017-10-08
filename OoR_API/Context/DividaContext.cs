using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Models;

namespace OoR_API.Context
{
    public class DividaContext : DbContext
    {
        public DividaContext() : base("oor")
        {
            Database.SetInitializer(new ClienteDBInitializercs());
        }

        public DbSet<Divida> dividas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}