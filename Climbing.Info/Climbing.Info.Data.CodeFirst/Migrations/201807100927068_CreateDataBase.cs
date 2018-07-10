namespace Climbing.Info.Data.Access.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClimberImage",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(maxLength: 500),
                        ClimberId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Climber", t => t.ClimberId, cascadeDelete: true)
                .Index(t => t.ClimberId);
            
            CreateTable(
                "dbo.Climber",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                        Grade = c.String(maxLength: 10),
                        Meters = c.Int(),
                        SectionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Section", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Section",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                        ZoneId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Zone", t => t.ZoneId, cascadeDelete: true)
                .Index(t => t.ZoneId);
            
            CreateTable(
                "dbo.SectionImage",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(maxLength: 500),
                        SectionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Section", t => t.SectionId, cascadeDelete: true)
                .Index(t => t.SectionId);
            
            CreateTable(
                "dbo.Zone",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                        LocationId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Location", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.SchoolDetail",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(maxLength: 500),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        ProvinceId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Province", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        RegionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Region", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        ProvinceId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Province", t => t.ProvinceId, cascadeDelete: true)
                .Index(t => t.ProvinceId);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        CountryId = c.Long(nullable: false),
                        CommunityId = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Community", t => t.CommunityId, cascadeDelete: true)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.CommunityId);
            
            CreateTable(
                "dbo.Community",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Guide",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                        EditorialId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Editorial", t => t.EditorialId, cascadeDelete: true)
                .Index(t => t.EditorialId);
            
            CreateTable(
                "dbo.Editorial",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SchoolImage",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(maxLength: 500),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.SchoolLink",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(maxLength: 500),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.Refuge",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1500),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RefugeImage",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        CreatedDate = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        LastDate = c.DateTime(),
                        Description = c.String(maxLength: 500),
                        RefugeId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Refuge", t => t.RefugeId, cascadeDelete: true)
                .Index(t => t.RefugeId);
            
            CreateTable(
                "dbo.RouteClimber",
                c => new
                    {
                        ClimberId = c.Long(nullable: false),
                        RouteId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClimberId, t.RouteId })
                .ForeignKey("dbo.Route", t => t.ClimberId)
                .ForeignKey("dbo.Climber", t => t.RouteId)
                .Index(t => t.ClimberId)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.SchoolDistrict",
                c => new
                    {
                        DistrictId = c.Long(nullable: false),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.DistrictId, t.SchoolId })
                .ForeignKey("dbo.School", t => t.DistrictId)
                .ForeignKey("dbo.District", t => t.SchoolId)
                .Index(t => t.DistrictId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.SchoolGuide",
                c => new
                    {
                        GuideId = c.Long(nullable: false),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.GuideId, t.SchoolId })
                .ForeignKey("dbo.School", t => t.GuideId)
                .ForeignKey("dbo.Guide", t => t.SchoolId)
                .Index(t => t.GuideId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.SchoolProvince",
                c => new
                    {
                        ProvinceId = c.Long(nullable: false),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProvinceId, t.SchoolId })
                .ForeignKey("dbo.School", t => t.ProvinceId)
                .ForeignKey("dbo.Province", t => t.SchoolId)
                .Index(t => t.ProvinceId)
                .Index(t => t.SchoolId);
            
            CreateTable(
                "dbo.SchoolRefuge",
                c => new
                    {
                        RefugeId = c.Long(nullable: false),
                        SchoolId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => new { t.RefugeId, t.SchoolId })
                .ForeignKey("dbo.School", t => t.RefugeId)
                .ForeignKey("dbo.Refuge", t => t.SchoolId)
                .Index(t => t.RefugeId)
                .Index(t => t.SchoolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClimberImage", "ClimberId", "dbo.Climber");
            DropForeignKey("dbo.Route", "SectionId", "dbo.Section");
            DropForeignKey("dbo.Section", "ZoneId", "dbo.Zone");
            DropForeignKey("dbo.Zone", "SchoolId", "dbo.School");
            DropForeignKey("dbo.SchoolRefuge", "SchoolId", "dbo.Refuge");
            DropForeignKey("dbo.SchoolRefuge", "RefugeId", "dbo.School");
            DropForeignKey("dbo.RefugeImage", "RefugeId", "dbo.Refuge");
            DropForeignKey("dbo.SchoolProvince", "SchoolId", "dbo.Province");
            DropForeignKey("dbo.SchoolProvince", "ProvinceId", "dbo.School");
            DropForeignKey("dbo.School", "LocationId", "dbo.Location");
            DropForeignKey("dbo.SchoolLink", "SchoolId", "dbo.School");
            DropForeignKey("dbo.SchoolImage", "SchoolId", "dbo.School");
            DropForeignKey("dbo.SchoolGuide", "SchoolId", "dbo.Guide");
            DropForeignKey("dbo.SchoolGuide", "GuideId", "dbo.School");
            DropForeignKey("dbo.Guide", "EditorialId", "dbo.Editorial");
            DropForeignKey("dbo.SchoolDistrict", "SchoolId", "dbo.District");
            DropForeignKey("dbo.SchoolDistrict", "DistrictId", "dbo.School");
            DropForeignKey("dbo.District", "ProvinceId", "dbo.Province");
            DropForeignKey("dbo.Province", "RegionId", "dbo.Region");
            DropForeignKey("dbo.Region", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Region", "CommunityId", "dbo.Community");
            DropForeignKey("dbo.Location", "ProvinceId", "dbo.Province");
            DropForeignKey("dbo.SchoolDetail", "SchoolId", "dbo.School");
            DropForeignKey("dbo.SectionImage", "SectionId", "dbo.Section");
            DropForeignKey("dbo.RouteClimber", "RouteId", "dbo.Climber");
            DropForeignKey("dbo.RouteClimber", "ClimberId", "dbo.Route");
            DropIndex("dbo.SchoolRefuge", new[] { "SchoolId" });
            DropIndex("dbo.SchoolRefuge", new[] { "RefugeId" });
            DropIndex("dbo.SchoolProvince", new[] { "SchoolId" });
            DropIndex("dbo.SchoolProvince", new[] { "ProvinceId" });
            DropIndex("dbo.SchoolGuide", new[] { "SchoolId" });
            DropIndex("dbo.SchoolGuide", new[] { "GuideId" });
            DropIndex("dbo.SchoolDistrict", new[] { "SchoolId" });
            DropIndex("dbo.SchoolDistrict", new[] { "DistrictId" });
            DropIndex("dbo.RouteClimber", new[] { "RouteId" });
            DropIndex("dbo.RouteClimber", new[] { "ClimberId" });
            DropIndex("dbo.RefugeImage", new[] { "RefugeId" });
            DropIndex("dbo.SchoolLink", new[] { "SchoolId" });
            DropIndex("dbo.SchoolImage", new[] { "SchoolId" });
            DropIndex("dbo.Guide", new[] { "EditorialId" });
            DropIndex("dbo.Region", new[] { "CommunityId" });
            DropIndex("dbo.Region", new[] { "CountryId" });
            DropIndex("dbo.Location", new[] { "ProvinceId" });
            DropIndex("dbo.Province", new[] { "RegionId" });
            DropIndex("dbo.District", new[] { "ProvinceId" });
            DropIndex("dbo.SchoolDetail", new[] { "SchoolId" });
            DropIndex("dbo.School", new[] { "LocationId" });
            DropIndex("dbo.Zone", new[] { "SchoolId" });
            DropIndex("dbo.SectionImage", new[] { "SectionId" });
            DropIndex("dbo.Section", new[] { "ZoneId" });
            DropIndex("dbo.Route", new[] { "SectionId" });
            DropIndex("dbo.ClimberImage", new[] { "ClimberId" });
            DropTable("dbo.SchoolRefuge");
            DropTable("dbo.SchoolProvince");
            DropTable("dbo.SchoolGuide");
            DropTable("dbo.SchoolDistrict");
            DropTable("dbo.RouteClimber");
            DropTable("dbo.RefugeImage");
            DropTable("dbo.Refuge");
            DropTable("dbo.SchoolLink");
            DropTable("dbo.SchoolImage");
            DropTable("dbo.Editorial");
            DropTable("dbo.Guide");
            DropTable("dbo.Country");
            DropTable("dbo.Community");
            DropTable("dbo.Region");
            DropTable("dbo.Location");
            DropTable("dbo.Province");
            DropTable("dbo.District");
            DropTable("dbo.SchoolDetail");
            DropTable("dbo.School");
            DropTable("dbo.Zone");
            DropTable("dbo.SectionImage");
            DropTable("dbo.Section");
            DropTable("dbo.Route");
            DropTable("dbo.Climber");
            DropTable("dbo.ClimberImage");
        }
    }
}
