namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;
    using Details;

    public partial class SectionEntity : BaseLocation
    {

        public SectionEntity()
        {
            Routes = new HashSet<RouteEntity>();
            Images = new HashSet<SectionImageEntity>();
        }

        public long SectionId { get; set; }
        public string SectionDescription { get; set; }

        public long ZoneId { get; set; }

        public virtual ZoneEntity Zone { get; set; }

        //-- Navigation properties
        public virtual ICollection<RouteEntity> Routes { get; protected set; }
        public virtual ICollection<SectionImageEntity> Images { get; protected set; }

    }

}
