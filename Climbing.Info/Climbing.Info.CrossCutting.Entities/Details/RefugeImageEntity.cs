namespace Climbing.Info.CrossCutting.Entities.Details
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Principals;

    public class RefugeImageEntity
    {

        public long RefugeImageId { get; set; }

        [StringLength(300, ErrorMessage = "RefugeImageName debe tener 300 caracteres o menos")]
        public string RefugeImageName { get; set; }

        [StringLength(500, ErrorMessage = "RefugeImageDescription debe tener 500 caracteres o menos")]
        public string RefugeImageDescription { get; set; }

        public long RefugeId { get; set; }

        public virtual RefugeEntity Refuge { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

    }
}
