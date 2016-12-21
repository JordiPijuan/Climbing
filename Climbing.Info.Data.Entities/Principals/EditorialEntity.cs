namespace Climbing.Info.Data.Entities.Principals
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class EditorialEntity : BaseEntity
    {

        public EditorialEntity()
        {
            Guides = new HashSet<GuideEntity>();
        }

        public long EditorialId { get; set; }
        public string EditorialDescription { get; set; }

        //-- Navigation properties
        public virtual ICollection<GuideEntity> Guides { get; protected set; }

    }

    [MetadataType(typeof(EditorialEntityMetaData))]
    [Table("Editorial", Schema = "dbo")]
    public partial class EditorialEntity
    {

        sealed class EditorialEntityMetaData
        {

            public long EditorialId { get; set; }

            [StringLength(1500, ErrorMessage = "EditorialDescription debe tener 1500 caracteres o menos")]
            [Display(Name = "Description")]
            public string EditorialDescription { get; set; }
       
        }

    }

}
