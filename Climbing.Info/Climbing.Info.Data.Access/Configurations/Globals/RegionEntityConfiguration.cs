namespace Climbing.Info.Data.Access.Configurations.Globals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Globals;

    public class RegionEntityConfiguration : EntityTypeConfiguration<RegionEntity>
    {

        public RegionEntityConfiguration()
        {

            //-- Properties
            Property(e => e.RegionId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.RegionId);

            //-- Relation One to Many -- field null -- Community [Foreign Key]
            HasOptional(e => e.Community)
                .WithMany(e => e.Regions)
                .HasForeignKey(e => e.CommunityId)
                .WillCascadeOnDelete(true);

            //-- Relation One to Many -- field not null -- Country [Foreign Key]
            HasRequired(e => e.Country)
                .WithMany(e => e.Regions)
                .HasForeignKey(e => e.CountryId)
                .WillCascadeOnDelete(true);

        }

    }

}
