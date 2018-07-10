namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(SchoolImageEntityMetaData))]
    [Table("SchoolImage", Schema = "dbo")]
    public partial class SchoolImageEntity
    {

        sealed class SchoolImageEntityMetaData
        {

            public long SchoolImageId { get; set; }

            [StringLength(500, ErrorMessage = "SchoolImageName debe tener 500 caracteres o menos")]
            public string SchoolImageDescription { get; set; }

        }

    }

}
