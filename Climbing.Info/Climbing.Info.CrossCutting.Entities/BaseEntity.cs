﻿namespace Climbing.Info.CrossCutting.Entities
{
    using System;

    public partial class BaseEntity
    {
        //public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

}
