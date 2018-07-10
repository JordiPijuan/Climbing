namespace Climbing.Info.Data.CodeFirst.Configurations.Details
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Details;

    public class SchoolImageEntityConfiguration : EntityTypeConfiguration<SchoolImageEntity>
    {

        public SchoolImageEntityConfiguration()
        {

            //-- Properties
            Property(e => e.SchoolImageId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.SchoolImageDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .HasColumnOrder(5)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.SchoolImageId);

            //-- Relation One to Many -- School [Foreign Key]
            HasRequired(e => e.School)
                .WithMany(e => e.Images)
                .HasForeignKey(e => e.SchoolId)
                .WillCascadeOnDelete(true);

        }

    }

}
