using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public ICollection<Interest> Interest { get; set; }
    }
}
