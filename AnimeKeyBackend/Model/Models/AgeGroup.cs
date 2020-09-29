using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class AgeGroup : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string CountryArabicName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string CountryEnglishName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Range(1, int.MinValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public int StartAge { get; set; }

        [Required(ErrorMessage = "Required")]
        [Range(100, int.MaxValue, ErrorMessage = "Please enter a value less than {1}")]
        public int EndAge { get; set; }
    }
}
