namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(ClimberImageEntityMetaData))]
    [Table("ClimberImage", Schema = "dbo")]
    public partial class ClimberImageEntity
    {

        sealed class ClimberImageEntityMetaData
        {

            public long ClimberImageId { get; set; }

            [StringLength(500, ErrorMessage = "ClimberImageDescription debe tener 500 caracteres o menos")]
            [Display(Name = "Description"), DisplayFormat(NullDisplayText = "No description")]
            public string ClimberImageDescription { get; set; }

        }

    }

}
