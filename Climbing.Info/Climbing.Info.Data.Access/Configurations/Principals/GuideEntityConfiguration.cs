namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Principals;

    public class GuideEntityConfiguration : EntityTypeConfiguration<GuideEntity>
    {

        public GuideEntityConfiguration()
        {

            //-- Properties
            Property(e => e.GuideId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.GuideDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.GuideId);

            //-- Relation One to Many [Foreign Key]
            HasRequired(e => e.Editorial)
                .WithMany(e => e.Guides)
                .HasForeignKey(e => e.EditorialId)
                .WillCascadeOnDelete(true);

        }

    }

}
