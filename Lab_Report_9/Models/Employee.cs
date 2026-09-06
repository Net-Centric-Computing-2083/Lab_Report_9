using System.ComponentModel.DataAnnotations;

namespace LabReport9.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18, 65)]
        public int Age { get; set; }

        [Required]
        public string ContactNo { get; set; }

        [Required]
        [Range(0, 10000000)]
        public decimal Salary { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }
    }
}