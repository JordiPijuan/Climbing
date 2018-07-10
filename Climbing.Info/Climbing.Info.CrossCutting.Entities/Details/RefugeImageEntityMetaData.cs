namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(RefugeImageEntityMetaData))]
    [Table("RefugeImage", Schema = "dbo")]
    public partial class RefugeImageEntity
    {

        sealed class RefugeImageEntityMetaData
        {

            public long RefugeImageId { get; set; }

            [StringLength(500, ErrorMessage = "RefugeImageDescription debe tener 500 caracteres o menos")]
            public string RefugeImageDescription { get; set; }

        }

    }

}
