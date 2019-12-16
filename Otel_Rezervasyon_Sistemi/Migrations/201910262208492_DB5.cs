namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RezervOda",
                c => new
                    {
                        RezervOdaID = c.Int(nullable: false, identity: true),
                        RezervasyonID = c.Int(nullable: false),
                        OdaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RezervOdaID)
                .ForeignKey("dbo.Oda_Tablo", t => t.OdaID, cascadeDelete: true)
                .ForeignKey("dbo.Rezervasyon_Tablo", t => t.RezervasyonID, cascadeDelete: true)
                .Index(t => t.RezervasyonID)
                .Index(t => t.OdaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RezervOda", "RezervasyonID", "dbo.Rezervasyon_Tablo");
            DropForeignKey("dbo.RezervOda", "OdaID", "dbo.Oda_Tablo");
            DropIndex("dbo.RezervOda", new[] { "OdaID" });
            DropIndex("dbo.RezervOda", new[] { "RezervasyonID" });
            DropTable("dbo.RezervOda");
        }
    }
}
