namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.Collections.Generic;

    public partial class CommunityEntity : BaseEntity
    {

        public long CommunityId { get; set; }

        //-- Navigation properties
        public virtual ICollection<RegionEntity> Regions { get; set;}

    }
}
