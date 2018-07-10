namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using Entities.Principals;

    public class RefugeEntityConfiguration : EntityTypeConfiguration<RefugeEntity>
    {

        public RefugeEntityConfiguration()
        {

            //-- Properties
            Property(e => e.RefugeId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.RefugeDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.RefugeId);

        }

    }
}
