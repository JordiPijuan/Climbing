namespace Climbing.Info.Data.CodeFirst.Configurations.Globals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Globals;

    public class LocationEntityConfiguration : EntityTypeConfiguration<LocationEntity>
    {

        public LocationEntityConfiguration()
        {

            //-- Properties
            Property(e => e.LocationId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.LocationId);

            //-- Relation One to Many -- Province [Foreign Key]
            HasRequired(e => e.Province)
                .WithMany(e => e.Locations)
                .HasForeignKey(e => e.ProvinceId)
                .WillCascadeOnDelete(true);

        }

    }

}
