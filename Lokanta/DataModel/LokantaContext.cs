using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lokanta.DataModel
{
    public class LokantaContext:DbContext
    {
        public virtual DbSet<Masa> Masa { get; set; }
        public virtual DbSet<Yemek> Yemek { get; set; }
        public virtual DbSet<YemekTur> YemekTur { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Lokanta;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
