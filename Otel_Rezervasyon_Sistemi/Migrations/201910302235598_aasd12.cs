namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aasd12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rezervasyon_Tablo", "GirisTarihi", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Rezervasyon_Tablo", "CikisTarihi", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rezervasyon_Tablo", "CikisTarihi", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Rezervasyon_Tablo", "GirisTarihi", c => c.DateTime(nullable: false));
        }
    }
}
