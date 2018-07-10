namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(CountryEntityMetaData))]
    [Table("Country", Schema = "dbo")]
    public partial class CountryEntity
    {

        sealed class CountryEntityMetaData
        {

            public long CountryId { get; set; }

        }

    }

}
