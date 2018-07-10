namespace Climbing.Info.Data.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(SectionEntityMetaData))]
    [Table("Section", Schema = "dbo")]
    public partial class SectionEntity
    {

        sealed class SectionEntityMetaData
        {

            public long SectionId { get; set; }

            [MaxLength(1500, ErrorMessage = "SectionDescription debe tener 1500 caracteres o menos")]
            public string SectionDescription { get; set; }

        }

    }

}
