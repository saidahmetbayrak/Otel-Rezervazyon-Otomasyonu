using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Otel_Rezervasyon_Sistemi.EF
{
    public class OtelContext : DbContext
    {
        public DbSet<Oda> Odalar { get; set; }

        public DbSet<Musteri> musteriler { get; set; }

        public DbSet<RezervasyonTipi> rezervasyonTipleri { get; set; }

        public DbSet<KayitliUye> kayitliUyeler { get; set; }

        public DbSet<Rezervasyon> rezervasyonlar { get; set; }

        public DbSet<Yoneticiler> yoneticiler { get; set; }

        public DbSet<Fiyat> fiyatlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
