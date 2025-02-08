using System.ComponentModel.DataAnnotations;

namespace WebAPICRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(150)]
        public string? Position { get; set; }
        [Required]
        [DataType("decimal(9,2)")]
        [Range(10000, 100000)]

        public decimal Salary { get; set; }
    }
}
