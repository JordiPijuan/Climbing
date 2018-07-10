namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(SectionImageEntityMetaData))]
    [Table("SectionImage", Schema = "dbo")]
    public partial class SectionImageEntity
    {
        
        sealed class SectionImageEntityMetaData
        {

            public long SectionImageId { get; set; }

            [StringLength(500, ErrorMessage = "SectionImageDescription debe tener 500 caracteres o menos")]
            public string SectionImageDescription { get; set; }

        }

    }

}
