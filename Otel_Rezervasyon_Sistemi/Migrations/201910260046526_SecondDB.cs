namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.KayitliUye", newName: "KayitliUye_Tablo");
            RenameTable(name: "dbo.Musteri", newName: "Musteri_Tablo");
            RenameTable(name: "dbo.Rezervasyon_Table", newName: "Rezervasyon_Tablo");
            AlterColumn("dbo.KayitliUye_Tablo", "Mail", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.KayitliUye_Tablo", "Sifre", c => c.String(nullable: false, maxLength: 16));
            AlterColumn("dbo.Musteri_Tablo", "KimlikNo", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Yonetici_Table", "KullaniciAdi", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yonetici_Table", "KullaniciAdi", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.Musteri_Tablo", "KimlikNo", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.KayitliUye_Tablo", "Sifre", c => c.String(nullable: false, maxLength: 4000));
            AlterColumn("dbo.KayitliUye_Tablo", "Mail", c => c.String(nullable: false, maxLength: 4000));
            RenameTable(name: "dbo.Rezervasyon_Tablo", newName: "Rezervasyon_Table");
            RenameTable(name: "dbo.Musteri_Tablo", newName: "Musteri");
            RenameTable(name: "dbo.KayitliUye_Tablo", newName: "KayitliUye");
        }
    }
}
