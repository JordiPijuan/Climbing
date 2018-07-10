namespace Climbing.Info.Data.Entities.Globals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class ProvinceEntity
    {

        public long ProvinceId { get; set; }

        [StringLength(100, ErrorMessage = "ProvinceName debe tener 100 caracteres o menos")]
        public string ProvinceName { get; set; }

        public long RegionId { get; set; }

        public virtual RegionEntity Region { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

        //-- Navigation properties
        public virtual ICollection<LocationEntity> Locations { get; set; }
        public virtual ICollection<DistrictEntity> Districts { get; set; }
        public virtual ICollection<SchoolEntity> Schools { get; set; }

    }
}
