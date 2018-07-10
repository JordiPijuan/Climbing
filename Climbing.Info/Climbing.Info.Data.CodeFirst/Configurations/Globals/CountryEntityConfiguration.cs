namespace Climbing.Info.Data.CodeFirst.Configurations.Globals
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;
    using CrossCutting.Entities.Globals;

    public class CountryEntityConfiguration : EntityTypeConfiguration<CountryEntity>
    {

        public CountryEntityConfiguration()
        {

            //-- Properties
            Property(e => e.CountryId)
                .HasColumnName("ID")
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnOrder(1)
                .IsRequired();

            //-- [Primary Key]
            HasKey<long>(e => e.CountryId);

        }

    }

}
