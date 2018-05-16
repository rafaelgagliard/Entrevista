using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntrevistaEniwine.Models
{
    public class EntrevistaContext : DbContext
    {
        public EntrevistaContext() : base("DefaultConnection")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Arma> Armas { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Suspeito> Suspeitos { get; set; }
    }
}