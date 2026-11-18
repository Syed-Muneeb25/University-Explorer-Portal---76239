using System.ComponentModel.DataAnnotations;

namespace University_Explorer_Portal___76239.Models
{
    public class StudentApplication
    {
        // Unique ID for each application
        public int StudentApplicationId { get; set; }

        [Required(ErrorMessage = "Student name is required.")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "University name is required.")]
        public string UniversityName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Course name is required.")]
        public string CourseName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Application date is required.")]
        public DateTime? ApplicationDate { get; set; }
    }
}