using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test1.Model;

namespace Test1.DBContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<АluminumAlloy> АluminumAlloys { get; set; }
        public DbSet<DictionaryType> DictionariesTypes { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=postgres");

        }

    }
}
