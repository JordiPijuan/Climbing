namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Details;

    [Table("Refuge", Schema = "dbo")]
    public partial class RefugeEntity : BaseEntity
    {

        public RefugeEntity()
        {
            Images = new HashSet<RefugeImageEntity>();
            Schools = new HashSet<SchoolEntity>();
        }

        public long RefugeId { get; set; }
        public string RefugeDescription { get; set; }

        //-- Navigation properties
        public virtual ICollection<RefugeImageEntity> Images { get; protected set; }
        public virtual ICollection<SchoolEntity> Schools { get; protected set; }

    }

    [MetadataType(typeof(RefugeEntityMetaData))]
    public partial class RefugeEntity
    {

        sealed class RefugeEntityMetaData
        {

            public long RefugeId { get; set; }

            [StringLength(1500, ErrorMessage = "RefugeDescription debe tener 1500 caracteres o menos")]
            public string RefugeDescription { get; set; }

        }

    }

}
