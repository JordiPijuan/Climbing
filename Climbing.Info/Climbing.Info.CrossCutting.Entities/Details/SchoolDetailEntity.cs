namespace Climbing.Info.CrossCutting.Entities.Details
{
    using Principals;

    public partial class SchoolDetailEntity : BaseEntity
    {

        public long SchoolDetailId { get; set; }

        public string SchoolDetailDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

    }

}
