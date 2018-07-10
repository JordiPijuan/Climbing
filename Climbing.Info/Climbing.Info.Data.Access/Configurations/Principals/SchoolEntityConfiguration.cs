namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Entities.Principals;

    public class SchoolEntityConfiguration : EntityTypeConfiguration<SchoolEntity>
    {

        public SchoolEntityConfiguration()
        {

            //-- Properties
            Property(e => e.SchoolId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.SchoolDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.SchoolId);

            //-- Relation One to Many [Foreign Key]
            HasRequired(e => e.Location)
                .WithMany(e => e.Schools)
                .HasForeignKey(e => e.LocationId)
                .WillCascadeOnDelete(true);

            //-- Relation Many to Many in new Table 'SchoolRefuge'
            HasMany(e => e.Refuges)
                .WithMany(t => t.Schools)
                .Map(m =>
                {
                    m.MapLeftKey("RefugeId");
                    m.MapRightKey("SchoolId");
                    m.ToTable("SchoolRefuge");
                });

            //-- Relation Many to Many in new Table 'SchoolGuide'
            HasMany(e => e.Guides)
                .WithMany(t => t.Schools)
                .Map(m =>
                {
                    m.MapLeftKey("GuideId");
                    m.MapRightKey("SchoolId");
                    m.ToTable("SchoolGuide");
                });

            //-- Relation Many to Many in new Table 'SchoolDistrict'
            HasMany(e => e.Districts)
                .WithMany(t => t.Schools)
                .Map(m =>
                {
                    m.MapLeftKey("DistrictId");
                    m.MapRightKey("SchoolId");
                    m.ToTable("SchoolDistrict");
                });

            //-- Relation Many to Many in new Table 'SchoolProvince'
            HasMany(e => e.Provinces)
                .WithMany(t => t.Schools)
                .Map(m =>
                {
                    m.MapLeftKey("ProvinceId");
                    m.MapRightKey("SchoolId");
                    m.ToTable("SchoolProvince");
                });

        }

    }
}
