namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.Collections.Generic;
    using Principals;

    public partial class DistrictEntity : BaseEntity
    {

        public long DistrictId { get; set; }

        public long ProvinceId { get; set; }

        public virtual ProvinceEntity Province { get; set; }

        //-- Navigation properties
        public virtual ICollection<SchoolEntity> Schools { get; set; }

    }

}
