﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class LookUpItems 
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage ="Required")]
        public string ArabicName { get; set; }

        public string EnglishName { get; set; }
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string IndonesiahName { get; set; }

        [Required(ErrorMessage = "Required")]
        public long LookUpId { get; set; }

        public long? CreatedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public long? ModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModificationDate { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsDeleted { get; set; } = false;
        public long? CompanyId { get; set; }
    }

}
