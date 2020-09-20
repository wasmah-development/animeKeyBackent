using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class ContractsServices : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long? ContractsId { get; set; }
        public long? ServicesId { get; set; }
        public decimal? CostOfService { get; set; }
        public long? CompanyId { get; set; }

    }
}
