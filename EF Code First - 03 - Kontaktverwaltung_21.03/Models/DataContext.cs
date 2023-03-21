using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First___03___Kontaktverwaltung_21._03.Models
{
    internal class DataContext : DbContext
    {
        public DbSet<Kontakt> Kontakte { get; set; }

        public DataContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=PC0337;Database = KontaktDB;Integrated Security=True;Encrypt=False");
        }
    }
}
