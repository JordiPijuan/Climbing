namespace Climbing.Info.Data.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(GuideEntityMetaData))]
    [Table("Guide", Schema = "dbo")]
    public partial class GuideEntity
    {

        sealed class GuideEntityMetaData
        {

            public long GuideId { get; set; }

            [StringLength(1500, ErrorMessage = "GuideDescription debe tener 1500 caracteres o menos")]
            public string GuideDescription { get; set; }

        }

    }

}
