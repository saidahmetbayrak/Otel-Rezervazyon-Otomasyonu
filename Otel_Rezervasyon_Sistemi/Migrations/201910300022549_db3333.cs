namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db3333 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Oda_Tablo", "DoluMu", c => c.Boolean(nullable: false));
            DropColumn("dbo.Oda_Tablo", "BosMu");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Oda_Tablo", "BosMu", c => c.Boolean(nullable: false));
            DropColumn("dbo.Oda_Tablo", "DoluMu");
        }
    }
}
