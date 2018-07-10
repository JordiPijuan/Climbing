namespace Climbing.Info.CrossCutting.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(BaseEntityMetadata))]
    public partial class BaseEntity
    {

        sealed class BaseEntityMetadata
        {

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
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
            [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
            public DateTime? UpdatedDate { get; set; }

        }

    }

}
