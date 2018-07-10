namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Principals;

    public class SectionEntityConfiguration : EntityTypeConfiguration<SectionEntity>
    {

        public SectionEntityConfiguration()
        {

            //-- Properties
            Property(e => e.SectionId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.SectionDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.SectionId);

            //-- Relation One to Many [Foreign Key]
            HasRequired(e => e.Zone)
                .WithMany(e => e.Sections)
                .HasForeignKey(e => e.ZoneId)
                .WillCascadeOnDelete(true);

        }

    }

}
