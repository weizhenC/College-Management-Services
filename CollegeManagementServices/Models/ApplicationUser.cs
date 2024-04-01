using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementServices.Models
{
    public class ApplicationUser : IdentityUser
    {
        //properties especially for Staff
        [Required(ErrorMessage = "Staff ID is required")]
        [RegularExpression(@"^[A-Z]{2}[0-9]{3}$", ErrorMessage = "Staff ID must have exactly 5 characters containing 3 digits [0-9] and 2 letters [A-Z]")]
        public string StaffId { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be a 10-digit number")]
        public string PhoneNumber { get; set; }

        //properties especially for Student
        [Required(ErrorMessage = "Student ID is required")]

        [RegularExpression(@"^\d{4}[A-Z]{2}$", ErrorMessage = "Student ID must have exactly 6 characters containing 4 digits [0-9] and 2 letters [A-Z]")]
        public string StudentId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, ErrorMessage = "Name cannot be longer than 10 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Name must contain only letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(10, ErrorMessage = "Surname cannot be longer than 10 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Surname must contain only letters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [RegularExpression(@"^[H][1-5|9][A|B|C|E|G|J|H|L|N|R|V|X|W|Z]$", ErrorMessage = "Postal code format is invalid")]
        public string PostalCode { get; set; }


        //properties especially for Gamer
        [Required(ErrorMessage = "Gamer ID is required")]
        [RegularExpression(@"^\d{1}[A-Z]{1}$", ErrorMessage = "Gamer ID must have exactly 2 characters containing 1 digit [0-9] and 1 letter [A-Z]")]
        public string GamerId { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 45, ErrorMessage = "Age must be between 18 and 45")]
        public int Age { get; set; }
    }
}
