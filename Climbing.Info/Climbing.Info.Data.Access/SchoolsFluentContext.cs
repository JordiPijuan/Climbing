namespace Climbing.Info.Data.Access
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Configurations.Details;
    using Configurations.Globals;
    using Configurations.Principals;
    using Entities.Details;
    using Entities.Globals;
    using Entities.Principals;

    public class SchoolsFluentContext : DbContext
    {

        #region · Constructors 

        public SchoolsFluentContext()
            : base("SchoolsFluentContext")
        {

        }

        public SchoolsFluentContext(bool enabledLazyLoading = false)
            : base("SchoolsFluentContext")
        {
            Configuration.LazyLoadingEnabled = enabledLazyLoading;
        }

        public SchoolsFluentContext(string connectionString, bool enabledLazyLoading = false)
            : base(connectionString)
        {
            Configuration.LazyLoadingEnabled = enabledLazyLoading;
        }

        #endregion Constructors

        #region · Globals 

        public DbSet<CountryEntity> Countries { get; set; }
        public DbSet<RegionEntity> Regions { get; set; }
        public DbSet<ProvinceEntity> Provinces { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<CommunityEntity> Communities { get; set; }
        public DbSet<DistrictEntity> Districts { get; set; }

        #endregion Globals

        #region · Principals 

        public DbSet<SchoolEntity> Schools { get; set; }
        public DbSet<ZoneEntity> Zones { get; set; }
        public DbSet<SectionEntity> Sections { get; set; }
        public DbSet<RouteEntity> Routes { get; set; }
        public DbSet<ClimberEntity> Climbers { get; set; }
        public DbSet<GuideEntity> Guides { get; set; }
        public DbSet<EditorialEntity> Editorials { get; set; }
        public DbSet<RefugeEntity> Refuges { get; set; }

        #endregion Principals

        #region · Details 

        public DbSet<SchoolImageEntity> SchoolImages { get; set; }
        public DbSet<SchoolLinkEntity> SchoolLinks { get; set; }
        public DbSet<SchoolDetailEntity> SchoolDetails { get; set; }
        public DbSet<SectionImageEntity> SectionImages { get; set; }
        public DbSet<ClimberImageEntity> ClimberImages { get; set; }
        public DbSet<RefugeImageEntity> RefugeImages { get; set; }

        #endregion Details 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            InitializeConfigurationEntities(modelBuilder);
            MappingInheritedProperties(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        #region · Private methods  

        private static void InitializeConfigurationEntities(DbModelBuilder modelBuilder)
        {
            InitializeGlobalTables(modelBuilder);
            InitializePrincipalTables(modelBuilder);
            InitializeDetailTables(modelBuilder);
        }

        private static void InitializeGlobalTables(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryEntityConfiguration());
            modelBuilder.Configurations.Add(new RegionEntityConfiguration());
            modelBuilder.Configurations.Add(new CommunityEntityConfiguration());
            modelBuilder.Configurations.Add(new ProvinceEntityConfiguration());
            modelBuilder.Configurations.Add(new DistrictEntityConfiguration());
            modelBuilder.Configurations.Add(new LocationEntityConfiguration());
        }

        private static void InitializePrincipalTables(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SchoolEntityConfiguration());
            modelBuilder.Configurations.Add(new ZoneEntityConfiguration());
            modelBuilder.Configurations.Add(new SectionEntityConfiguration());
            modelBuilder.Configurations.Add(new RouteEntityConfiguration());
            modelBuilder.Configurations.Add(new ClimberEntityConfiguration());
            modelBuilder.Configurations.Add(new RefugeEntityConfiguration());
            modelBuilder.Configurations.Add(new EditorialEntityConfiguration());
            modelBuilder.Configurations.Add(new GuideEntityConfiguration());
        }

        private static void InitializeDetailTables(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SchoolImageEntityConfiguration());
            modelBuilder.Configurations.Add(new SchoolLinkEntityConfiguration());
            modelBuilder.Configurations.Add(new SchoolDetailEntityConfiguration());
            modelBuilder.Configurations.Add(new SectionImageEntityConfiguration());
            modelBuilder.Configurations.Add(new ClimberImageEntityConfiguration());
            modelBuilder.Configurations.Add(new RefugeImageEntityConfiguration());
        }

        private static void MappingInheritedProperties(DbModelBuilder modelBuilder)
        {
            //-- Global
            modelBuilder.Entity<CommunityEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<CountryEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<DistrictEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<LocationEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<ProvinceEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<RegionEntity>().Map(m => m.MapInheritedProperties());
            //-- Principal
            modelBuilder.Entity<SchoolEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<ZoneEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<SectionEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<RouteEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<ClimberEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<RefugeEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<EditorialEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<GuideEntity>().Map(m => m.MapInheritedProperties());
            //-- Details
            modelBuilder.Entity<ClimberImageEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<RefugeImageEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<SchoolDetailEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<SchoolImageEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<SchoolLinkEntity>().Map(m => m.MapInheritedProperties());
            modelBuilder.Entity<SectionImageEntity>().Map(m => m.MapInheritedProperties());
        }

        #endregion

    }

}
