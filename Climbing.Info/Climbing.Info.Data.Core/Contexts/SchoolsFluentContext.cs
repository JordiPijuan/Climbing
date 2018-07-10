namespace Climbing.Info.Data.Core.Contexts
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using CrossCutting.Entities.Details;
    using CrossCutting.Entities.Globals;
    using CrossCutting.Entities.Principals;
    //using log4net;

    public class SchoolsFluentContext : DbContext
    {

        //private static ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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

        public SchoolsFluentContext(
            string connectionString, 
            bool enabledLazyLoading = false
            ) : base(connectionString)
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

            MappingInheritedProperties(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        #region · Private methods  

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
