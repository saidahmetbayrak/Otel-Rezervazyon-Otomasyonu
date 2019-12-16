namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Oda_Tablo", "MusteriID", "dbo.Musteri_Tablo");
            DropIndex("dbo.Oda_Tablo", new[] { "MusteriID" });
            AddColumn("dbo.Musteri_Tablo", "OdaID", c => c.Int(nullable: false));
            AddColumn("dbo.Rezervasyon_Tablo", "OdaID", c => c.Int(nullable: false));
            CreateIndex("dbo.Musteri_Tablo", "OdaID");
            CreateIndex("dbo.Rezervasyon_Tablo", "OdaID");
            AddForeignKey("dbo.Musteri_Tablo", "OdaID", "dbo.Oda_Tablo", "OdaID", cascadeDelete: false);
            AddForeignKey("dbo.Rezervasyon_Tablo", "OdaID", "dbo.Oda_Tablo", "OdaID", cascadeDelete: false);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oda_Tablo", "MusteriID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Rezervasyon_Tablo", "OdaID", "dbo.Oda_Tablo");
            DropForeignKey("dbo.Musteri_Tablo", "OdaID", "dbo.Oda_Tablo");
            DropIndex("dbo.Rezervasyon_Tablo", new[] { "OdaID" });
            DropIndex("dbo.Musteri_Tablo", new[] { "OdaID" });
            DropColumn("dbo.Rezervasyon_Tablo", "OdaID");
            DropColumn("dbo.Musteri_Tablo", "OdaID");
            CreateIndex("dbo.Oda_Tablo", "MusteriID");
            AddForeignKey("dbo.Oda_Tablo", "MusteriID", "dbo.Musteri_Tablo", "MusteriId", cascadeDelete: true);
        }
    }
}
