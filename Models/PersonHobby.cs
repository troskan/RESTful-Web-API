using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace RESTful_Web_API.Models
{
    public class PersonHobby
    {
        [Key]
        public int PersonHobbyID { get; set; }
        public int PersonID { get; set; }
        [JsonIgnore]
        public Person? Person { get; set; }
        public int LinkID { get; set; }
        [JsonIgnore]
        public Link? Link { get; set; }
        public int HobbyID { get; set; }
        [JsonIgnore]
        public Hobby? Hobby { get; set;}

    }
}
