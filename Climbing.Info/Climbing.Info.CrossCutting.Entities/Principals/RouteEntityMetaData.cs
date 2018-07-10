namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(RouteEntityMetaData))]
    [Table("Route", Schema = "dbo")]
    public partial class RouteEntity
    {

        sealed class RouteEntityMetaData
        {

            public long RouteId { get; set; }

            [StringLength(1500, ErrorMessage = "RouteDescription debe tener 1500 caracteres o menos")]
            public string RouteDescription { get; set; }

            [StringLength(10, ErrorMessage = "Grade debe tener 10 caracteres o menos")]
            public string Grade { get; set; }

            public int? Meters { get; set; }

        }

    }

}
