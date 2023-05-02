namespace RESTful_Web_API.Services
{
    public interface IWebApi<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T newObject);
        Task Delete(int id);
        Task<T> Update(T newObject);

    }
}
