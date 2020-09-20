using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class ContractsImages : BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public long? VehicleId { get; set; }
        public string AttachmentUrl { get; set; }

    }
}
