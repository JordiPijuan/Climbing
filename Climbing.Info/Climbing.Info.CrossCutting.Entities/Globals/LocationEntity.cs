namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.Collections.Generic;
    using Principals;

    public partial class LocationEntity : BaseEntity
    {

        public long LocationId { get; set; }

        public long ProvinceId { get; set; }

        public virtual ProvinceEntity Province { get; set; }

        //-- Navigation properties
        //-- One to Many
        public virtual ICollection<SchoolEntity> Schools { get; set; }

    }
}
