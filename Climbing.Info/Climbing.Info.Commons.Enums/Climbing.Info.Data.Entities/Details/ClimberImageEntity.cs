namespace Climbing.Info.Data.Entities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public partial class ClimberImageEntity : BaseEntity
    {

        public long ClimberImageId { get; set; }

        [StringLength(500, ErrorMessage = "ClimberImageDescription debe tener 500 caracteres o menos")]
        public string ClimberImageDescription { get; set; }

        public long ClimberId { get; set; }

        public virtual ClimberEntity Climber { get; set; }

    }

}
