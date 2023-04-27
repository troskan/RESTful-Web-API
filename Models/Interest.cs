using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Models
{
    public class Interest
    {
        [Key]
        public int InterestID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<Person> Person { get; set; }
    }
}
