using Microsoft.EntityFrameworkCore;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;

namespace RESTful_Web_API.Services
{
    public class HobbyRepository : IHobby<Hobby>
    {
        private readonly Context _db;
        public HobbyRepository(Context db)
        {
            _db = db;
        }
        public Task<Hobby> Add(Hobby newObject)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Hobby> Get(int id)
        {
            throw new NotImplementedException();
        } 


        public Task<IEnumerable<Hobby>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Hobby> Update(Hobby newObject)
        {
            throw new NotImplementedException();
        }
    }
}
