namespace Climbing.Info.Data.Access.Configurations.Globals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Entities.Globals;

    public class DistrictEntityConfiguration : EntityTypeConfiguration<DistrictEntity>
    {

        public DistrictEntityConfiguration()
        {

            //-- Properties
            Property(e => e.DistrictId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.DistrictId);

            //-- Relation One to Many -- Province [Foreign Key]
            HasRequired(e => e.Province)
                .WithMany(e => e.Districts)
                .HasForeignKey(e => e.ProvinceId)
                .WillCascadeOnDelete(true);

        }

    }

}
