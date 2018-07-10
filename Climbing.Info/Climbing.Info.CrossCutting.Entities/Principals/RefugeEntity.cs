namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;
    using Details;

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

}
