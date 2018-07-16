namespace Climbing.Info.CrossCutting.Entities
{
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BaseLocation
    {

        sealed class BaseLocationMetadata
        {

            [Column("Latitude")]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public decimal Latitude { get; set; }

            [Column("Latitude")]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public decimal Longitude { get; set; }

        }

    }

}
