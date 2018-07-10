namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(SchoolEntityMetaData))]
    [Table("School", Schema = "dbo")]
    public partial class SchoolEntity
    {

        sealed class SchoolEntityMetaData
        {

            public long SchoolId { get; set; }

            [StringLength(1500, ErrorMessage = "SchoolDescription debe tener 1500 caracteres o menos")]
            public string SchoolDescription { get; set; }

        }

    }

}
