using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Screens : BaseEntity
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
        [StringLength(500, ErrorMessage = "Must be at max {1} characters")]
        public string ScreenCode { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Icon { get; set; }
        public string URL { get; set; }
        public long ModuleId { get; set; }
    }
}
