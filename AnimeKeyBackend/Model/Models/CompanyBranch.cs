using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("CompanyBranches")]
    public class CompanyBranch : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string ArabicName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string EnglishName { get; set; }
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string IndonesiahName { get; set; }
        [Required(ErrorMessage = "Required")]
        public long CityId { get; set; }

        [Required(ErrorMessage = "Required")]
        public long DistrictId { get; set; }

        public TimeSpan FromTime { get; set; } = new TimeSpan(9, 0, 0);

        public TimeSpan ToTime { get; set; } = new TimeSpan(17, 0, 0);

        public string Address { get; set; }

        public string Location { get; set; }
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "Numbers Only")]
        public string BranchNumber { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "NotValidEmailAddress")]
        public string BranchEmail { get; set; }
        public long? CompanyId { get; set; }


    }
}
