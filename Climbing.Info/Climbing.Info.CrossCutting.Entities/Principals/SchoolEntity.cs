namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;
    using Details;
    using Globals;

    public partial class SchoolEntity : BaseLocation
    {

        public SchoolEntity()
        {
            Zones = new HashSet<ZoneEntity>();
            Images = new HashSet<SchoolImageEntity>();
            Links = new HashSet<SchoolLinkEntity>();
            Details = new HashSet<SchoolDetailEntity>();
            Refuges = new HashSet<RefugeEntity>();
            Guides = new HashSet<GuideEntity>();
            Provinces = new HashSet<ProvinceEntity>();
            Districts = new HashSet<DistrictEntity>();
        }

        public long SchoolId { get; set; }
        public string SchoolDescription { get; set; }

        //-- LocationEntity [Foreign Key] 
        public long LocationId { get; set; }

        public virtual LocationEntity Location { get; set; }

        //-- Navigation properties
        //-- One to Many
        public virtual ICollection<ZoneEntity> Zones { get; protected set; }
        public virtual ICollection<SchoolImageEntity> Images { get; protected set; }
        public virtual ICollection<SchoolLinkEntity> Links { get; protected set; }
        public virtual ICollection<SchoolDetailEntity> Details { get; protected set; }
        //-- Many to Many
        public virtual ICollection<RefugeEntity> Refuges { get; protected set; }
        public virtual ICollection<GuideEntity> Guides { get; protected set; }
        public virtual ICollection<ProvinceEntity> Provinces { get; protected set; }
        public virtual ICollection<DistrictEntity> Districts { get; protected set; }

    }

}
