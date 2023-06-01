using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;
using System.ComponentModel.DataAnnotations;

namespace RESTful_Web_API.Services
{
    public class PersonHobbyRepository : IWebApi<PersonHobby>
    {
        private readonly Context _db;
        public PersonHobbyRepository(Context db)
        {
            _db = db;
        }

        public async Task<PersonHobby> Add(PersonHobby newObject)
        {
            if (newObject == null)
            {
                return null;
            }

            _db.PersonHobby.Add(newObject);
            await _db.SaveChangesAsync();
            return newObject;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonHobby> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PersonHobby>> GetAll()
        {
           
            
                return await _db.PersonHobby.ToListAsync();
            
        }

        public Task<PersonHobby> Update(PersonHobby newObject)
        {
            throw new NotImplementedException();
        }
    }
}
