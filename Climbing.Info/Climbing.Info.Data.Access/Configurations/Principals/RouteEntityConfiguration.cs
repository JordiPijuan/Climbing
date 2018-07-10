namespace Climbing.Info.Data.Access.Configurations.Principals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Principals;

    public class RouteEntityConfiguration : EntityTypeConfiguration<RouteEntity>
    {

        public RouteEntityConfiguration()
        {

            //-- Properties
            Property(e => e.RouteId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            Property(e => e.RouteDescription)
                .HasColumnName("Description")
                .HasColumnType("nvarchar")
                .HasMaxLength(1500)
                .HasColumnOrder(5)
                .IsRequired();

            Property(e => e.Grade)
                .HasColumnName("Grade")
                .HasColumnType("nvarchar")
                .HasMaxLength(10)
                .HasColumnOrder(7)
                .IsOptional();

            Property(e => e.Meters)
                .HasColumnName("Meters")
                .HasColumnType("int")
                .HasColumnOrder(8)
                .IsOptional();

            //-- [Primary Key]
            HasKey<long>(e => e.RouteId);

            //-- Relation One to Many [Foreign Key]
            HasRequired(e => e.Section)
                .WithMany(e => e.Routes)
                .HasForeignKey(e => e.SectionId)
                .WillCascadeOnDelete(true);

            //-- Relation Many to Many in new Table 'RouteClimber'
            HasMany(e => e.Climbers)
                .WithMany(t => t.Routes)
                .Map(m =>
                {
                    m.MapLeftKey("ClimberId");
                    m.MapRightKey("RouteId");
                    m.ToTable("RouteClimber");
                });

        }

    }

}
