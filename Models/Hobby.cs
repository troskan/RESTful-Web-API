using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyID { get; set; }
        [Required]
        public string HobbyName { get; set; }
        public string HobbyDescription { get; set; }
    }
}
