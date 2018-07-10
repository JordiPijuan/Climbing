namespace Climbing.Info.Data.Access.Configurations.Details
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Details;

    public class ClimberImageEntityConfiguration : EntityTypeConfiguration<ClimberImageEntity>
    {

        public ClimberImageEntityConfiguration()
        {

            //-- Properties
            Property(e => e.ClimberImageId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.ClimberImageDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .HasColumnOrder(5)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.ClimberImageId);

            //-- Relation One to Many -- Climber [Foreign Key]
            HasRequired(e => e.Climber)
                .WithMany(e => e.Images)
                .HasForeignKey(e => e.ClimberId)
                .WillCascadeOnDelete(true);

        }

    }

}
