namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(LocationEntityMetaData))]
    [Table("Location", Schema = "dbo")]
    public partial class LocationEntity
    {
		
		sealed class LocationEntityMetaData
		{

            public long LocationId { get; set; }

        }

    }

}
