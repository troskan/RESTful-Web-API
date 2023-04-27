namespace RESTful_Web_API.Models
{
    public class Website
    {
        public int WebsiteID { get; set; }
        public string Name { get; set; }
        public ICollection<Interest> Interest { get; set; }
        public ICollection<Person> Person { get; set; }
    }
}
