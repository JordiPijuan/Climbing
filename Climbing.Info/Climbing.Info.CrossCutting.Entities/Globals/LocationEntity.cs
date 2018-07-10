using System.Collections;

namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class LocationEntity
    {

        public long LocationId { get; set; }

        [StringLength(150, ErrorMessage = "LocationName debe tener 150 caracteres o menos")]
        public string LocationName { get; set; }

        public long ProvinceId { get; set; }

        public virtual ProvinceEntity Province { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

        //-- Navigation properties
        //-- One to Many
        public virtual ICollection<SchoolEntity> Schools { get; set; }

    }
}
