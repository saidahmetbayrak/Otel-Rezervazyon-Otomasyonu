namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Oda_Tablo", "OdaNumarasi", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Oda_Tablo", "OdaNumarasi", c => c.Int(nullable: false));
        }
    }
}
