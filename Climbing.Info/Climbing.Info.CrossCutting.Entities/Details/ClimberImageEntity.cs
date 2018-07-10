namespace Climbing.Info.CrossCutting.Entities.Details
{
    using Principals;

    public partial class ClimberImageEntity : BaseEntity
    {

        public long ClimberImageId { get; set; }

        public string ClimberImageDescription { get; set; }

        public long ClimberId { get; set; }

        public virtual ClimberEntity Climber { get; set; }

    }

}
