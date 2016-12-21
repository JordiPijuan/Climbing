namespace Climbing.Info.Data.Entities.Metadata
{
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(ClimberEntityMetaData))]
    public partial class ClimberEntity
    {

        sealed class ClimberEntityMetaData
        {

            public long ClimberId { get; set; }

            [StringLength(1500, ErrorMessage = "ClimberDescription debe tener 1500 caracteres o menos")]
            [Display(Name = "Description")]
            [DisplayFormat(NullDisplayText = "No description")]
            public string ClimberDescription { get; set; }

        }

    }

}
