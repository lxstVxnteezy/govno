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
        public DbSet<АluminumAlloy> АluminumAlloys { get; set; }
        public DbSet<DictAlloy> Dictionaries { get; set; }
        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb1;Trusted_Connection=false;");

        }

    }
}
