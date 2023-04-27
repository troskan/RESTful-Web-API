using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Models
{
    public class PersonInterest
    {
        [Key]   
        public int PersonInterestID { get; set; }
        [Required]
        public int InterestID { get; set; }
        [Required]
        public int PersonID { get; set; }

    }
}
