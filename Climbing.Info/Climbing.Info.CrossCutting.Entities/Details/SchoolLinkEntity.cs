namespace Climbing.Info.CrossCutting.Entities.Details
{
    using Principals;

    public partial class SchoolLinkEntity : BaseEntity
    {

        public long SchoolLinkId { get; set; }

        public string SchoolLinkDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

    }

}
