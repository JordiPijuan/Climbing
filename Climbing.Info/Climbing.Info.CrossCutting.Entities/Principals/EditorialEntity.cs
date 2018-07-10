namespace Climbing.Info.CrossCutting.Entities.Principals
{
    using System.Collections.Generic;

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

}
