namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Details;

    [Table("Section", Schema = "dbo")]
    public partial class SectionEntity : BaseEntity
    {

        public SectionEntity()
        {
            Routes = new HashSet<RouteEntity>();
            Images = new HashSet<SectionImageEntity>();
        }

        public long SectionId { get; set; }
        public string SectionDescription { get; set; }

        public long ZoneId { get; set; }

        public virtual ZoneEntity Zone { get; set; }

        //-- Navigation properties
        public virtual ICollection<RouteEntity> Routes { get; protected set; }
        public virtual ICollection<SectionImageEntity> Images { get; protected set; }

    }

    [MetadataType(typeof(SectionEntityMetaData))]
    public partial class SectionEntity
    {

        sealed class SectionEntityMetaData
        {

            public long SectionId { get; set; }

            [MaxLength(1500, ErrorMessage = "SectionDescription debe tener 1500 caracteres o menos")]
            public string SectionDescription { get; set; }

            public long ZoneId { get; set; }

            public ZoneEntity Zone { get; set; }

        }

    }

}
