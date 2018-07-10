namespace Climbing.Info.Data.Access.Configurations.Details
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Entities.Details;

    public class SchoolLinkEntityConfiguration : EntityTypeConfiguration<SchoolLinkEntity>
    {

        public SchoolLinkEntityConfiguration()
        {

            //-- Properties
            Property(e => e.SchoolLinkId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.SchoolLinkDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .HasColumnOrder(5)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.SchoolLinkId);

            //-- Relation One to Many -- School [Foreign Key]
            HasRequired(e => e.School)
                .WithMany(e => e.Links)
                .HasForeignKey(e => e.SchoolId)
                .WillCascadeOnDelete(true);

        }

    }

}
