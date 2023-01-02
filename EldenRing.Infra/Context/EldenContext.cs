using EldenRing.Domain.Entities;
using EldenRing.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldenRing.Infra.Context
{
    public class EldenContext : DbContext
    {
        public EldenContext(DbContextOptions<EldenContext> options)
            : base(options)
        {
        }

        public DbSet<Ammo> Ammos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AmmoMapping());
        }
    }
}
