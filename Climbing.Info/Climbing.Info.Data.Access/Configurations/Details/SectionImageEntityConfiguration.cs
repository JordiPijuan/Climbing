namespace Climbing.Info.Data.Access.Configurations.Details
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Details;

    public class SectionImageEntityConfiguration : EntityTypeConfiguration<SectionImageEntity>
    {

        public SectionImageEntityConfiguration()
        {

            //-- Properties
            Property(e => e.SectionImageId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.SectionImageDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .HasColumnOrder(5)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.SectionImageId);

            //-- Relation One to Many -- School [Foreign Key]
            HasRequired(e => e.Section)
                .WithMany(e => e.Images)
                .HasForeignKey(e => e.SectionId)
                .WillCascadeOnDelete(true);

        }

    }

}
