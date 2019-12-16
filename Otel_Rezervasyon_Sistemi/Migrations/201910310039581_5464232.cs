namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5464232 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Musteri_Tablo", "RezervasyonID", "dbo.Rezervasyon_Tablo");
            DropIndex("dbo.Musteri_Tablo", new[] { "RezervasyonID" });
            DropColumn("dbo.Musteri_Tablo", "RezervasyonID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteri_Tablo", "RezervasyonID", c => c.Int(nullable: false));
            CreateIndex("dbo.Musteri_Tablo", "RezervasyonID");
            AddForeignKey("dbo.Musteri_Tablo", "RezervasyonID", "dbo.Rezervasyon_Tablo", "RezervasyonID", cascadeDelete: true);
        }
    }
}
