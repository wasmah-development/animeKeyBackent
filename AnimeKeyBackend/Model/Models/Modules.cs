﻿using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Modules : BaseEntity
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
        public string Icon { get; set; }
    }
}
