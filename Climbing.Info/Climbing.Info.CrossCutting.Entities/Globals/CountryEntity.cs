namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.Collections.Generic;

    public partial class CountryEntity : BaseEntity
    {

        public CountryEntity()
        {
            Regions = new HashSet<RegionEntity>();
        }

        public long CountryId { get; set; }

        //-- Navigation properties
        public virtual ICollection<RegionEntity> Regions { get; set; }

    }

}
