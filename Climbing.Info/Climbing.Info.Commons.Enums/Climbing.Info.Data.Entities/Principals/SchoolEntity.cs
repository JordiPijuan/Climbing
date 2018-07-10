namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Details;
    using Globals;

    [Table("School", Schema = "dbo")]
    public partial class SchoolEntity : BaseEntity
    {

        public SchoolEntity()
        {
            Zones = new HashSet<ZoneEntity>();
            Images = new HashSet<SchoolImageEntity>();
            Links = new HashSet<SchoolLinkEntity>();
            Details = new HashSet<SchoolDetailEntity>();
            Refuges = new HashSet<RefugeEntity>();
            Guides = new HashSet<GuideEntity>();
            Provinces = new HashSet<ProvinceEntity>();
            Districts = new HashSet<DistrictEntity>();
        }

        //-- Primary key
        public long SchoolId { get; set; }
        public string SchoolDescription { get; set; }

        //-- LocationEntity [Foreign Key] 
        public long LocationId { get; set; }

        public virtual LocationEntity Location { get; set; }

        //-- Navigation properties
        //-- One to Many
        public virtual ICollection<ZoneEntity> Zones { get; protected set; }
        public virtual ICollection<SchoolImageEntity> Images { get; protected set; }
        public virtual ICollection<SchoolLinkEntity> Links { get; protected set; }
        public virtual ICollection<SchoolDetailEntity> Details { get; protected set; }
        //-- Many to Many
        public virtual ICollection<RefugeEntity> Refuges { get; protected set; }
        public virtual ICollection<GuideEntity> Guides { get; protected set; }
        public virtual ICollection<ProvinceEntity> Provinces { get; protected set; }
        public virtual ICollection<DistrictEntity> Districts { get; protected set; }

    }

    [MetadataType(typeof(SchoolEntityMetaData))]
    public partial class SchoolEntity
    {

        sealed class SchoolEntityMetaData
        {

            public long SchoolId { get; set; }

            [StringLength(1500, ErrorMessage = "SchoolDescription debe tener 1500 caracteres o menos")]
            public string SchoolDescription { get; set; }
            
            public long LocationId { get; set; }
            
            public LocationEntity Location { get; set; }

        }

    }

}
