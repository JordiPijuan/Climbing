namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Zone", Schema = "dbo")]
    public partial class ZoneEntity : BaseEntity
    {

        public ZoneEntity()
        {
            Sections = new HashSet<SectionEntity>();
        }

        public long ZoneId { get; set; }
        public string ZoneDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

        //-- Navigation properties
        public virtual ICollection<SectionEntity> Sections { get; protected set; }

    }

    [MetadataType(typeof(ZoneEntityMetaData))]
    public partial class ZoneEntity
    {

        sealed class ZoneEntityMetaData
        {

            public long ZoneId { get; set; }

            [StringLength(1500, ErrorMessage = "ZoneDescription debe tener 1500 caracteres o menos")]
            public string ZoneDescription { get; set; }

            public long SchoolId { get; set; }

            public SchoolEntity School { get; set; }

        }

    }

}
