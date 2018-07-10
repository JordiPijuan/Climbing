namespace Climbing.Info.Data.Entities.Globals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RegionEntity
    {

        public RegionEntity()
        {
            Provinces = new HashSet<ProvinceEntity>();
        }

        public long RegionId { get; set; }

        [StringLength(100, ErrorMessage = "RegionName debe tener 100 caracteres o menos")]
        public string RegionName { get; set; }

        public long CountryId { get; set; }

        public virtual CountryEntity Country { get; set; }

        public long? CommunityId { get; set; }

        public virtual CommunityEntity Community { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

        //-- Navigation properties
        public virtual ICollection<ProvinceEntity> Provinces { get; set; }

    }
}
