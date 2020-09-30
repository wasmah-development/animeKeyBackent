using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Users : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [Remote("CheckExsist", "Users", AdditionalFields = "Id", HttpMethod = "POST", ErrorMessage = "AlreadyExistsVMsg")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        [Remote("CheckExsist", "Users", AdditionalFields = "Id", HttpMethod = "POST", ErrorMessage = "AlreadyExistsVMsg")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string UserName { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "NotValidEmailAddress")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{5,}$", ErrorMessage = "PasswordRequirements")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string Password { get; set; }

        public long? JobTitleId { get; set; }
        public bool IsMaster { get; set; } = false;
        public bool IsManager { get; set; } = false;
        public string Token { get; set; }
    }
}
