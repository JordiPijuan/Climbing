namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(ZoneEntityMetaData))]
    [Table("Zone", Schema = "dbo")]
    public partial class ZoneEntity
    {

        sealed class ZoneEntityMetaData
        {

            public long ZoneId { get; set; }

            [StringLength(1500, ErrorMessage = "ZoneDescription debe tener 1500 caracteres o menos")]
            public string ZoneDescription { get; set; }

        }

    }

}
