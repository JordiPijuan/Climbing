namespace Climbing.Info.Data.CodeFirst.Configurations.Globals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Globals;

    public class ProvinceEntityConfiguration : EntityTypeConfiguration<ProvinceEntity>
    {

        public ProvinceEntityConfiguration()
        {

            //-- Properties
            Property(e => e.ProvinceId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.ProvinceId);

            //-- Relation One to Many -- Region [Foreign Key]
            HasRequired(e => e.Region)
                .WithMany(e => e.Provinces)
                .HasForeignKey(e => e.RegionId)
                .WillCascadeOnDelete(true);

        }

    }
}
