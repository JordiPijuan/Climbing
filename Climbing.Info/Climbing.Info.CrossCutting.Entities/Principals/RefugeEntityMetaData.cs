namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(RefugeEntityMetaData))]
    [Table("Refuge", Schema = "dbo")]
    public partial class RefugeEntity
    {

        sealed class RefugeEntityMetaData
        {

            public long RefugeId { get; set; }

            [StringLength(1500, ErrorMessage = "RefugeDescription debe tener 1500 caracteres o menos")]
            public string RefugeDescription { get; set; }

        }

    }

}
