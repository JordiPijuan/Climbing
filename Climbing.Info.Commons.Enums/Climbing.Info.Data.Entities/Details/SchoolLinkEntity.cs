namespace Climbing.Info.Data.Entities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class SchoolLinkEntity
    {

        public long SchoolLinkId { get; set; }

        [StringLength(300, ErrorMessage = "SchoolLinkName debe tener 300 caracteres o menos")]
        public string SchoolLinkName { get; set; }

        [StringLength(500, ErrorMessage = "SchoolLinkDescription debe tener 500 caracteres o menos")]
        public string SchoolLinkDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

    }
}
