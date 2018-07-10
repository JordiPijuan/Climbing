namespace Climbing.Info.Data.Entities.Globals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CommunityEntity
    {

        public long CommunityId { get; set; }

        [StringLength(100, ErrorMessage = "CommunityName debe tener 100 caracteres o menos")]
        public string CommunityName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

        //-- Navigation properties
        public virtual ICollection<RegionEntity> Regions { get; set;}

    }
}
