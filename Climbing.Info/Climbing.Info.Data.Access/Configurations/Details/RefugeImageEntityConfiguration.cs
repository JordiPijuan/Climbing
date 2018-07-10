namespace Climbing.Info.Data.Access.Configurations.Details
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Details;

    public class RefugeImageEntityConfiguration : EntityTypeConfiguration<RefugeImageEntity>
    {

        public RefugeImageEntityConfiguration()
        {

            //-- Properties
            Property(e => e.RefugeImageId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.RefugeImageDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .HasColumnOrder(5)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.RefugeImageId);

            //-- Relation One to Many -- Refuge [Foreign Key]
            HasRequired(e => e.Refuge)
                .WithMany(e => e.Images)
                .HasForeignKey(e => e.RefugeId)
                .WillCascadeOnDelete(true);

        }

    }

}
