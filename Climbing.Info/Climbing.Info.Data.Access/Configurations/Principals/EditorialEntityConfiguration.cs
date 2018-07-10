namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Entities.Principals;

   public class EditorialEntityConfiguration : EntityTypeConfiguration<EditorialEntity>
    {

        public EditorialEntityConfiguration()
        {

            HasKey<long>(e => e.EditorialId);

            Property(e => e.EditorialId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.EditorialDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

        }

    }
}
