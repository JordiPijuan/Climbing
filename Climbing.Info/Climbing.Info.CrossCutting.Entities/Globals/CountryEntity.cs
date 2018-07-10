namespace Climbing.Info.CrossCutting.Entities.Globals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CountryEntity
    {

        public CountryEntity()
        {
            Regions = new HashSet<RegionEntity>();
        }

        public long CountryId { get; set; }

        public string CountryName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        //-- Navigation properties
        public virtual ICollection<RegionEntity> Regions { get; set; }

    }

    [MetadataType(typeof(CountryEntityMetaData))]
    public partial class CountryEntity
    {

        sealed class CountryEntityMetaData
        {

            [Display(Name = "ID")]
            public long CountryId { get; set; }

            [StringLength(100, ErrorMessage = "CountryName debe tener 100 caracteres o menos")]
            [Display(Name = "Country")]
            public string CountryName { get; set; }

            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime CreatedDate { get; set; }

            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime? UpdatedDate { get; set; }

            //-- Navigation properties
            [Display(Name = "Regions")]
            public ICollection<RegionEntity> Regions { get; set; }

        }

    }

}
