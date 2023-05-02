using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Phone { get; set; }
    }
}
