namespace Climbing.Info.Data.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(ClimberEntityMetaData))]
    [Table("Climber", Schema = "dbo")]
    public partial class ClimberEntity
    {

        sealed class ClimberEntityMetaData
        {

            [StringLength(1500, ErrorMessage = "ClimberDescription debe tener 1500 caracteres o menos")]
            [Display(Name = "Description"), DisplayFormat(NullDisplayText = "No description")]
            public string ClimberDescription { get; set; }

        }

    }

}
