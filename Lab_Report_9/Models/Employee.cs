using System.ComponentModel.DataAnnotations;

namespace ModelBindingDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string? Email { get; set; }

        [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Contact number is required")]
        public string ?ContactNo { get; set; }

        [Range(0, 10000000, ErrorMessage = "Enter a valid salary")]
        public decimal Salary { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }
    }
}