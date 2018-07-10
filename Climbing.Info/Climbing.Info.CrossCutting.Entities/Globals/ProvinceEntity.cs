namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.Collections.Generic;
    using Principals;

    public partial class ProvinceEntity : BaseEntity
    {

        public long ProvinceId { get; set; }

        public long RegionId { get; set; }

        public virtual RegionEntity Region { get; set; }

        //-- Navigation properties
        public virtual ICollection<LocationEntity> Locations { get; set; }
        public virtual ICollection<DistrictEntity> Districts { get; set; }
        public virtual ICollection<SchoolEntity> Schools { get; set; }

    }
}
