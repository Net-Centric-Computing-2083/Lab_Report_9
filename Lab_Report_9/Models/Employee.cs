using System;
using System.ComponentModel.DataAnnotations;

namespace Lab_Report_9.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(18, 65)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; } = string.Empty;

        [Range(0, 10000000)]
        public decimal Salary { get; set; }

        [Required]
        [Display(Name = "Joined Date")]
        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }
    }
}