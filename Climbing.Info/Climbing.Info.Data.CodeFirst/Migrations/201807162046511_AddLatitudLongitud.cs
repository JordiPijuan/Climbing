namespace Climbing.Info.Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLatitudLongitud : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Section", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Section", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Zone", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Zone", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.School", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.School", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Refuge", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Refuge", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Refuge", "Longitud");
            DropColumn("dbo.Refuge", "Latitud");
            DropColumn("dbo.School", "Longitud");
            DropColumn("dbo.School", "Latitud");
            DropColumn("dbo.Zone", "Longitud");
            DropColumn("dbo.Zone", "Latitud");
            DropColumn("dbo.Section", "Longitud");
            DropColumn("dbo.Section", "Latitud");
        }
    }
}
