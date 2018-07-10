namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System;
    using Principals;

    public partial class SchoolImageEntity : BaseEntity
    {

        public long SchoolImageId { get; set; }

        public string SchoolImageDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

    }

}
