using Microsoft.EntityFrameworkCore;


namespace VeriKatmani.LokantaVt
{
    public class LokantaContext:DbContext
    {
        public virtual DbSet<Masa> Masa { get; set; }
        public virtual DbSet<Yemek> Yemek { get; set; }
        public virtual DbSet<YemekTur> YemekTur { get; set; }

        public virtual DbSet<Siparis> Siparis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Lokanta;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
