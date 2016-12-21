namespace Climbing.Info.Data.Entities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class SectionImageEntity
    {

        public long SectionImageId { get; set; }

        [StringLength(300, ErrorMessage = "SectionImageName debe tener 300 caracteres o menos")]
        public string SectionImageName { get; set; }

        [StringLength(500, ErrorMessage = "SectionImageDescription debe tener 500 caracteres o menos")]
        public string SectionImageDescription { get; set; }

        public long SectionId { get; set; }

        public virtual SectionEntity Section { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

    }
}
