namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.Collections.Generic;

    public partial class RegionEntity : BaseEntity
    {

        public RegionEntity()
        {
            Provinces = new HashSet<ProvinceEntity>();
        }

        public long RegionId { get; set; }

        public long CountryId { get; set; }

        public virtual CountryEntity Country { get; set; }

        public long? CommunityId { get; set; }

        public virtual CommunityEntity Community { get; set; }

        //-- Navigation properties
        public virtual ICollection<ProvinceEntity> Provinces { get; set; }

    }
}
