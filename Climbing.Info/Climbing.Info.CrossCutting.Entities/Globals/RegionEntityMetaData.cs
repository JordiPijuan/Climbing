namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(RegionEntityMetaData))]
    [Table("Region", Schema = "dbo")]
    public partial class RegionEntity
    {
		
		sealed class RegionEntityMetaData
        {

            public long RegionId { get; set; }

        }

    }

}
