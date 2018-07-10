namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;

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

}
