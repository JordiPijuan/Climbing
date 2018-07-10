namespace Climbing.Info.Data.CodeFirst.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Principals;

    public class ClimberEntityConfiguration : EntityTypeConfiguration<ClimberEntity>
    {

        public ClimberEntityConfiguration()
        {

            HasKey<long>(e => e.ClimberId);

            Property(e => e.ClimberId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.ClimberDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

        }

    }

}
