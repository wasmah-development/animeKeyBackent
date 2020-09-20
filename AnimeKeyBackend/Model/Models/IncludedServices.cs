using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Model
{
    public class IncludedServices : BaseEntity
    {

        [Key]
        public long Id { get; set; }

        public long? ServicesId { get; set; }

        public long? AdditonalServiceId { get; set; }

        public decimal? CostOfService { get; set; }
    }
}
