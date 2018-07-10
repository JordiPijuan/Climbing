namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(DistrictEntityMetaData))]
    [Table("District", Schema = "dbo")]
    public partial class DistrictEntity
    {
		
		sealed class DistrictEntityMetaData
		{

            public long DistrictId { get; set; }

        }
    }
}
