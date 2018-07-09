﻿namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;

    public partial class ZoneEntity : BaseEntity
    {

        public ZoneEntity()
        {
            Sections = new HashSet<SectionEntity>();
        }

        public long ZoneId { get; set; }
        public string ZoneDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

        //-- Navigation properties
        public virtual ICollection<SectionEntity> Sections { get; protected set; }

    }

}
