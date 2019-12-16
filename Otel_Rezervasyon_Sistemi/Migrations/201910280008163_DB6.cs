namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fiyat_Tablo",
                c => new
                    {
                        FiyatID = c.Int(nullable: false, identity: true),
                        FiyatTipi = c.String(nullable: false, maxLength: 4000),
                        FiyatOran = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.FiyatID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fiyat_Tablo");
        }
    }
}
