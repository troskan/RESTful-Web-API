using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace RESTful_Web_API.Models
{
    public class PersonHobby
    {
        [Key]
        public int PersonHobbyID { get; set; }
        public int PersonID { get; set; }
        public Person? Person { get; set; }
        public int LinkID { get; set; }
        public Link? Link { get; set; }
        public int HobbyID { get; set; }
        public Hobby? Hobby { get; set;}

    }
}
