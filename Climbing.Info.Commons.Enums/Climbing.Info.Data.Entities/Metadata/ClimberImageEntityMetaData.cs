namespace Climbing.Info.Data.Entities.Metadata
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(ClimberImageEntityMetaData))]
    public partial class ClimberImageEntity
    {

        sealed class ClimberImageEntityMetaData
        {

            public long ClimberImageId { get; set; }

            [StringLength(300, ErrorMessage = "ClimberImageName debe tener 300 caracteres o menos")]
            [DisplayFormat(NullDisplayText = "No image")]
            public string ClimberImageName { get; set; }

            [StringLength(500, ErrorMessage = "ClimberImageDescription debe tener 500 caracteres o menos")]
            [Display(Name = "Description")]
            [DisplayFormat(NullDisplayText = "No description")]
            public string ClimberImageDescription { get; set; }

            public long ClimberId { get; set; }


            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime CreatedDate { get; set; }

            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            public DateTime? UpdatedDate { get; set; }

        }

    }

}
