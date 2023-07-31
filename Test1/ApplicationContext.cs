using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AluminiumAlloy>AluminiumAlloys { get; set; }
        public DbSet<ChemicalComposition>Compositions { get;set; }
        public DbSet<MaterialExecution> MaterialExecutions { get;set; }
        
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=false;");


        }

    }
}
