using System.Collections;

namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Route", Schema = "dbo")]
    public partial class RouteEntity : BaseEntity
    {

        public RouteEntity()
        {
            Climbers = new HashSet<ClimberEntity>();
        }

        public long RouteId { get; set; }
        public string RouteDescription { get; set; }
        public string Grade { get; set; }
        public int? Meters { get; set; }
        public long SectionId { get; set; }

        public virtual SectionEntity Section { get; set; }

        //-- Navigation properties
        public virtual ICollection<ClimberEntity> Climbers { get; protected set; }

    }

    [MetadataType(typeof(RouteEntityMetaData))]
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

            public long SectionId { get; set; }

            public SectionEntity Section { get; set; }

        }

    }

}
