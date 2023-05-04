using RESTful_Web_API.Models;

namespace RESTful_Web_API.Services
{
    public interface IPersonRepository<T>
    {
        Task<IEnumerable<Hobby>> GetHobbys(int id);
        Task<IEnumerable<Link>> GetLinks(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T newObject);
        Task Delete(int id);
        Task<T> Update(T newObject);
    }
}
