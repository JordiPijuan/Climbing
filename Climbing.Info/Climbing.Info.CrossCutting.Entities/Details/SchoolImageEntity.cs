namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class SchoolImageEntity
    {

        public long SchoolImageId { get; set; }

        [StringLength(300, ErrorMessage = "SchoolImageName debe tener 300 caracteres o menos")]
        public string SchoolImageName { get; set; }

        [StringLength(500, ErrorMessage = "SchoolImageName debe tener 500 caracteres o menos")]
        public string SchoolImageDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

    }
}
