namespace Climbing.Info.Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyLatitudeLongitude : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Section", "Latitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Section", "Longitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Zone", "Latitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Zone", "Longitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.School", "Latitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.School", "Longitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Refuge", "Latitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Refuge", "Longitude", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            DropColumn("dbo.Section", "Latitud");
            DropColumn("dbo.Section", "Longitud");
            DropColumn("dbo.Zone", "Latitud");
            DropColumn("dbo.Zone", "Longitud");
            DropColumn("dbo.School", "Latitud");
            DropColumn("dbo.School", "Longitud");
            DropColumn("dbo.Refuge", "Latitud");
            DropColumn("dbo.Refuge", "Longitud");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Refuge", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Refuge", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.School", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.School", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Zone", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Zone", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Section", "Longitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            AddColumn("dbo.Section", "Latitud", c => c.Decimal(nullable: true, precision: 18, scale: 8));
            DropColumn("dbo.Refuge", "Longitude");
            DropColumn("dbo.Refuge", "Latitude");
            DropColumn("dbo.School", "Longitude");
            DropColumn("dbo.School", "Latitude");
            DropColumn("dbo.Zone", "Longitude");
            DropColumn("dbo.Zone", "Latitude");
            DropColumn("dbo.Section", "Longitude");
            DropColumn("dbo.Section", "Latitude");
        }
    }
}
