namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Guide", Schema = "dbo")]
    public partial class GuideEntity : BaseEntity
    {

        public GuideEntity()
        {
            Schools = new HashSet<SchoolEntity>();
        }

        public long GuideId { get; set; }
        public string GuideDescription { get; set; }
        public long EditorialId { get; set; }

        public virtual EditorialEntity Editorial { get; set; }

        //-- Navigation properties
        public virtual ICollection<SchoolEntity> Schools { get; protected set; }

    }

    [MetadataType(typeof(GuideEntityMetaData))]
    public partial class GuideEntity 
    {
        sealed class GuideEntityMetaData
        {

            public long GuideId { get; set; }

            [StringLength(1500, ErrorMessage = "GuideDescription debe tener 1500 caracteres o menos")]
            public string GuideDescription { get; set; }

            public long EditorialId { get; set; }

            public EditorialEntity Editorial { get; set; }

        }
    }

}
