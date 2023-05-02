using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Models
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        [Required]
        public string LinkName { get; set; }
        [Required]
        public string LinkURL { get; set; }

    }
}
