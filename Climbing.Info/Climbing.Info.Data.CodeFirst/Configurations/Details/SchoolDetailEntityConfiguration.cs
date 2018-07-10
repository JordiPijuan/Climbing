namespace Climbing.Info.Data.CodeFirst.Configurations.Details
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Details;

    public class SchoolDetailEntityConfiguration : EntityTypeConfiguration<SchoolDetailEntity>
    {

        public SchoolDetailEntityConfiguration()
        {

            //-- Properties
            Property(e => e.SchoolDetailId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.SchoolDetailDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .HasColumnOrder(5)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.SchoolDetailId);

            //-- Relation One to Many -- School [Foreign Key]
            HasRequired(e => e.School)
                .WithMany(e => e.Details)
                .HasForeignKey(e => e.SchoolId)
                .WillCascadeOnDelete(true);

        }

    }

}
