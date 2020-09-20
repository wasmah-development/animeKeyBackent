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
        public string UserName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(200, ErrorMessage = "Must be at max {1} characters")]
        public string Password { get; set; }

        //public long? JobTitleId { get; set; }
        public bool IsMaster { get; set; } = false;
        public long CompanyId { get; set; } 
        public bool IsCompanyManager { get; set; } = false;
        public string Token { get; set; }
    }
}
