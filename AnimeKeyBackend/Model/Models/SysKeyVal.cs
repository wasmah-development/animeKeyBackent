using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class SysKeyVal : BaseEntity
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100, ErrorMessage = "Must be at max {1} characters")]
        public string Key { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string Value { get; set; }
        public long? CompanyId { get; set; }

    }
}
