namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Entities.Principals;

    public class ZoneEntityConfiguration : EntityTypeConfiguration<ZoneEntity>
    {

        public ZoneEntityConfiguration()
        {

            //-- Properties
            this.Property(e => e.ZoneId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            this.Property(e => e.ZoneDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

            //-- [Primary Key]
            this.HasKey<long>(e => e.ZoneId);

            //-- Relation One to Many [Foreign Key]
            this.HasRequired(e => e.School)
                .WithMany(e => e.Zones)
                .HasForeignKey(e => e.SchoolId)
                .WillCascadeOnDelete(true);

        }

    }

}
