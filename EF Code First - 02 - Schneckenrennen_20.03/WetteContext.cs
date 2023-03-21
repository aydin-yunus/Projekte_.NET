using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___02___Schneckenrennen_20._03
{
    public class WettContext : DbContext
    {
        public DbSet<Wettbüro> Wettbüros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC0471;Database=WettDB;Integrated Security=True;");
        }
    }
}
