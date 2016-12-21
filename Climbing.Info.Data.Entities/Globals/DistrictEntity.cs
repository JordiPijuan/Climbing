namespace Climbing.Info.Data.Entities.Globals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class DistrictEntity
    {

        public long DistrictId { get; set; }

        [StringLength(100, ErrorMessage = "DistrictName debe tener 100 caracteres o menos")]
        public string DistrictName { get; set; }

        public long ProvinceId { get; set; }

        public virtual ProvinceEntity Province { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

        //-- Navigation properties
        public virtual ICollection<SchoolEntity> Schools { get; set; }

    }
}
