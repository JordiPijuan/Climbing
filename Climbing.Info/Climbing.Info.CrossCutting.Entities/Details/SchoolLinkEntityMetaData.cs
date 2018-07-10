namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(SchoolLinkEntityMetaData))]
    [Table("SchoolLink", Schema = "dbo")]
    public partial class SchoolLinkEntity
    {

        sealed class SchoolLinkEntityMetaData
        {

            public long SchoolLinkId { get; set; }

            [StringLength(500, ErrorMessage = "SchoolLinkDescription debe tener 500 caracteres o menos")]
            public string SchoolLinkDescription { get; set; }

        }

    }

}
