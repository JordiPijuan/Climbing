﻿namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;
    using Details;

    public partial class ClimberEntity : BaseEntity
    {

        public ClimberEntity()
        {
            Routes = new HashSet<RouteEntity>();
            Images = new HashSet<ClimberImageEntity>();
        }

        public long ClimberId { get; set; }
        public string ClimberDescription { get; set; }

        //-- Navigation properties
        public virtual ICollection<RouteEntity> Routes { get; protected set; }
        public virtual ICollection<ClimberImageEntity> Images { get; protected set; }

    }

}
