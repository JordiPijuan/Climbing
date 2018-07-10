namespace Climbing.Info.CrossCutting.Entities.Details
{
    using Principals;

    public partial class SectionImageEntity : BaseEntity
    {

        public long SectionImageId { get; set; }

        public string SectionImageDescription { get; set; }

        public long SectionId { get; set; }

        public virtual SectionEntity Section { get; set; }

    }

}
