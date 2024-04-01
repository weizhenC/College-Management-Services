using System.ComponentModel.DataAnnotations;

namespace CollegeManagementServices.Models
{
    public class StudentDuty
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required")]
        [RegularExpression(@"^[A-Z]{2}\d{2}$", ErrorMessage = "Code must have exactly 4 characters containing 2 digits [0-9] and 2 letters [A-Z]")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }
    }
}
