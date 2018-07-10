namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(CommunityEntityMetaData))]
    [Table("Community", Schema = "dbo")]
    public partial class CommunityEntity
	{
		
		sealed class CommunityEntityMetaData
		{
			
            public long CommunityId { get; set; }

        }

    }

}
