namespace Otel_Rezervasyon_Sistemi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db33 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yonetici_Table", "Email", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Yonetici_Table", "KullaniciAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Yonetici_Table", "KullaniciAdi", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Yonetici_Table", "Email");
        }
    }
}
