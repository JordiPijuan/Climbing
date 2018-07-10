namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(SchoolDetailEntityMetaData))]
    [Table("SchoolDetail", Schema = "dbo")]
    public partial class SchoolDetailEntity
    {

        sealed class SchoolDetailEntityMetaData
        {

            public long SchoolDetailId { get; set; }

            [StringLength(500, ErrorMessage = "SchoolDetailDescription debe tener 500 caracteres o menos")]
            public string SchoolDetailDescription { get; set; }

        }

    }

}
