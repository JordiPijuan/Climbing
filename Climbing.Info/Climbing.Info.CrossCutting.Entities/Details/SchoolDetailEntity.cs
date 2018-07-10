namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class SchoolDetailEntity
    {

        public long SchoolDetailId { get; set; }

        [StringLength(300, ErrorMessage = "SchoolDetailName debe tener 300 caracteres o menos")]
        public string SchoolDetailName { get; set; }

        [StringLength(500, ErrorMessage = "SchoolDetailDescription debe tener 500 caracteres o menos")]
        public string SchoolDetailDescription { get; set; }

        public long SchoolId { get; set; }

        public virtual SchoolEntity School { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? UpdatedDate { get; set; }

    }
}
