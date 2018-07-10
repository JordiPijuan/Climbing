namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(ProvinceMetaData))]
    [Table("Province", Schema = "dbo")]
    public partial class ProvinceEntity
    {
		
		sealed class ProvinceMetaData
		{

            public long ProvinceId { get; set; }

        }

    }

}
