namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KayitliUye",
                c => new
                    {
                        Mail = c.String(nullable: false, maxLength: 4000),
                        Sifre = c.String(nullable: false, maxLength: 4000),
                        KayitliUyeID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.KayitliUyeID);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        KimlikNo = c.String(nullable: false, maxLength: 4000),
                        Ad = c.String(nullable: false, maxLength: 30),
                        Soyad = c.String(nullable: false, maxLength: 30),
                        MusteriId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MusteriId);
            
            CreateTable(
                "dbo.Oda_Tablo",
                c => new
                    {
                        OdaNumarasi = c.Int(nullable: false),
                        KisiSayisi = c.Int(nullable: false),
                        BosMu = c.Boolean(nullable: false),
                        OdaId = c.Int(nullable: false, identity: true),
                        MusteriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OdaId)
                .ForeignKey("dbo.Musteri", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.MusteriID);
            
            CreateTable(
                "dbo.Rezervasyon_Table",
                c => new
                    {
                        RezervasyonID = c.Int(nullable: false, identity: true),
                        KayitliUyeID = c.Int(nullable: false),
                        RezervasyonTipiID = c.Int(nullable: false),
                        GirisTarihi = c.DateTime(nullable: false),
                        CikisTarihi = c.DateTime(nullable: false),
                        KisiSayisi = c.Int(nullable: false),
                        OdaSayisi = c.Int(nullable: false),
                        YatakSayisi = c.Int(nullable: false),
                        Fiyat = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.RezervasyonID)
                .ForeignKey("dbo.KayitliUye", t => t.KayitliUyeID, cascadeDelete: true)
                .ForeignKey("dbo.RezervasyonTipi_Tablo", t => t.RezervasyonTipiID, cascadeDelete: true)
                .Index(t => t.KayitliUyeID)
                .Index(t => t.RezervasyonTipiID);
            
            CreateTable(
                "dbo.RezervasyonTipi_Tablo",
                c => new
                    {
                        Tipi = c.String(nullable: false, maxLength: 30),
                        Acıklama = c.String(nullable: false, maxLength: 100),
                        RezervasyonTipiId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.RezervasyonTipiId);
            
            CreateTable(
                "dbo.Yonetici_Table",
                c => new
                    {
                        YoneticiID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 4000),
                        Sifre = c.String(nullable: false, maxLength: 16),
                    })
                .PrimaryKey(t => t.YoneticiID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyon_Table", "RezervasyonTipiID", "dbo.RezervasyonTipi_Tablo");
            DropForeignKey("dbo.Rezervasyon_Table", "KayitliUyeID", "dbo.KayitliUye");
            DropForeignKey("dbo.Oda_Tablo", "MusteriID", "dbo.Musteri");
            DropIndex("dbo.Rezervasyon_Table", new[] { "RezervasyonTipiID" });
            DropIndex("dbo.Rezervasyon_Table", new[] { "KayitliUyeID" });
            DropIndex("dbo.Oda_Tablo", new[] { "MusteriID" });
            DropTable("dbo.Yonetici_Table");
            DropTable("dbo.RezervasyonTipi_Tablo");
            DropTable("dbo.Rezervasyon_Table");
            DropTable("dbo.Oda_Tablo");
            DropTable("dbo.Musteri");
            DropTable("dbo.KayitliUye");
        }
    }
}
