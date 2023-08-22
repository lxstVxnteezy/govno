using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test1.Entities;
using Test1.Model;

namespace Test1.DBContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<АluminumAlloy> АluminumAlloys { get; set; }
        public DbSet<DictionaryType> DictionariesTypes { get; set; }
        public DbSet<ChemicalComposition> ChemicalCompositions { get; set; }
        public DbSet<ChemicalElement> ChemicalElements { get; set; }
        public DbSet<Unit>Units { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=postgres");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<АluminumAlloy>()
                .HasMany(c => c.ChemicalElements)
                .WithMany(s => s.АluminumAlloys)
                .UsingEntity<ChemicalComposition>(
                    j => j
                        .HasOne(pt => pt.ChemicalElement)
                        .WithMany(t => t.ChemicalCompositions)
                        .HasForeignKey(pt => pt.ChemicalElementId),
                    j => j
                        .HasOne(pt => pt.АluminumAlloy)
                        .WithMany(p => p.ChemicalCompositions)
                        .HasForeignKey(pt => pt.АluminumAlloyId));
           


        }
    }
}
