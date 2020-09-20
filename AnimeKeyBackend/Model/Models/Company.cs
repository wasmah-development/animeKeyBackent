using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Company : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string ArabicName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string EnglishName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string IndonesiahName { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "NotValidPhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^\+?\d+$", ErrorMessage = "Numbers Only")]
        public string taxNumber { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Address { get; set; }

        public string Location { get; set; }

        /// <summary>
        ///  this  coloums  will  be  used   for  relate  Restaurant_Wasmaa or  not
        /// </summary>
        public long? UserGroupId { get; set; }

        [Required(ErrorMessage = "Required")]
        [Remote("CheckExsist", "Company", AdditionalFields = "Id", HttpMethod = "POST", ErrorMessage = "AlreadyExistsVMsg")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string CompanyUserName { get; set; }

        [Required(ErrorMessage = "Required")]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{5,}$", ErrorMessage = "PasswordRequirements")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string CompanyPassword { get; set; }

        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Required")]
        public long CountryId { get; set; }

        public string Description { get; set; }
    }
}
