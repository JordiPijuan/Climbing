namespace Climbing.Info.CrossCutting.Entities.Details
{
    using Principals;

    public partial class RefugeImageEntity : BaseEntity
    {

        public long RefugeImageId { get; set; }

        public string RefugeImageDescription { get; set; }

        public long RefugeId { get; set; }

        public virtual RefugeEntity Refuge { get; set; }

    }

}
