using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Contracts : BaseEntity
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
        public long VehiclesId { get; set; }

        [Required(ErrorMessage = "Required")]
        public long ContractTypeId { get; set; }


        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "PositiveNumbersOnly")]
        public double ActivationCost { get; set; }

        [Required(ErrorMessage = "Required")]
        public int RecurringCostAmount { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "PositiveNumbersOnly")]
        public double OdometerAtCreation { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Required")]
        public DateTime ContractStartDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Required")]
        public DateTime ContractEndDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Required")]
        public DateTime ContractExpirationDate { get; set; } = DateTime.Now;

 

        [Required(ErrorMessage = "Required")]
        public string ContractReference { get; set; }

        public bool AcceptTerms { get; set; } = false;

        [Required(ErrorMessage = "Required")]
        public int ContractStatus { get; set; }
        public List<ContractsServices> ContractsServices { get; set; }
        public List<ContractsImages> ContractsImages { get; set; }
        public long? CompanyId { get; set; }

    }
}
