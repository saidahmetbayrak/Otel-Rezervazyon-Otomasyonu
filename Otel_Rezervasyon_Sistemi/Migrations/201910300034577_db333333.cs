namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db333333 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RezervOda", "OdaID", "dbo.Oda_Tablo");
            DropForeignKey("dbo.RezervOda", "RezervasyonID", "dbo.Rezervasyon_Tablo");
            DropIndex("dbo.RezervOda", new[] { "RezervasyonID" });
            DropIndex("dbo.RezervOda", new[] { "OdaID" });
            DropTable("dbo.RezervOda");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RezervOda",
                c => new
                    {
                        RezervOdaID = c.Int(nullable: false, identity: true),
                        RezervasyonID = c.Int(nullable: false),
                        OdaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RezervOdaID);
            
            CreateIndex("dbo.RezervOda", "OdaID");
            CreateIndex("dbo.RezervOda", "RezervasyonID");
            AddForeignKey("dbo.RezervOda", "RezervasyonID", "dbo.Rezervasyon_Tablo", "RezervasyonID", cascadeDelete: true);
            AddForeignKey("dbo.RezervOda", "OdaID", "dbo.Oda_Tablo", "OdaID", cascadeDelete: true);
        }
    }
}
