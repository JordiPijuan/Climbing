namespace Climbing.Info.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract partial class BaseEntity
    {
        //public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    [MetadataType(typeof(BaseEntityMetadata))]
    public abstract partial class BaseEntity
    {

        sealed class BaseEntityMetadata
        {

            //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            //[Column("ID", Order = 1)]
            //public long Id { get; set; }

            [Required(ErrorMessage = "El campo es obligatorio")]
            [Column("Name", Order = 2, TypeName = "nvarchar")]
            [StringLength(150, ErrorMessage = "El campo debe tener 150 caracteres o menos")]
            public string Name { get; set; }

            [Column("CreatedDate", Order = 3)]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public DateTime CreatedDate { get; set; }

            [Column("LastDate", Order = 4)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public DateTime? UpdatedDate { get; set; }

        }

    }

}
