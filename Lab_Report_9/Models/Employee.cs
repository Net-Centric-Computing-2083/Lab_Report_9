using System;
using System.ComponentModel.DataAnnotations;

namespace Lab_Report_9.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }

        public string ContactNo { get; set; }

        public decimal Salary { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }
    }
}