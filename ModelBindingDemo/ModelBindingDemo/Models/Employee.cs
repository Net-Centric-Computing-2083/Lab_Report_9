using System.ComponentModel.DataAnnotations;
namespace ModelBindingDemo.Models { 
    public class Employee { 
        [Required] 
        public int Id { get; set; } 
        [Required] 
        public string Name { get; set; } = string.Empty; 
        [Required][EmailAddress] 
        public string Email { get; set; } = string.Empty; 
        [Range(18, 100)] 
        public int Age { get; set; } 
        [Required] 
        public string ContactNo { get; set; } = string.Empty;
        [Range(0, 100000000)] 
        public decimal Salary { get; set; } 
        [Required][DataType(DataType.Date)] 
        public DateTime JoinedDate { get; set; } 
    } 
}