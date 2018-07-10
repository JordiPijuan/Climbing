using System.Collections;

namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class RouteEntity : BaseEntity
    {

        public RouteEntity()
        {
            Climbers = new HashSet<ClimberEntity>();
        }

        public long RouteId { get; set; }
        public string RouteDescription { get; set; }
        public string Grade { get; set; }
        public int? Meters { get; set; }
        public long SectionId { get; set; }

        public virtual SectionEntity Section { get; set; }

        //-- Navigation properties
        public virtual ICollection<ClimberEntity> Climbers { get; protected set; }

    }

}
