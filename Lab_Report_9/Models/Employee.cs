using System.ComponentModel.DataAnnotations;

namespace Lab_Report_9.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Range(18, 100)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Joined Date")]
        public DateTime JoinedDate { get; set; }
    }
}