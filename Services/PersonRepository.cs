using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;

namespace RESTful_Web_API.Services
{
    public class PersonRepository : IWebApi<Person>
    {
        private Context _db;
        public PersonRepository(Context db)
        {
            _db = db;
        }
        public async Task<Person> Add(Person newObject)
        {
            if (newObject == null)
            {
            return null;
                
            }
            _db.Person.Add(newObject);
            await _db.SaveChangesAsync();
            return newObject;

        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Person> Get(int id)
        {
            if (id == 0) 
            {
                return null;
            }
            return await _db.Person.FirstOrDefaultAsync(p => p.PersonID == id);
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _db.Person.ToListAsync();
        }

        public Task<Person> Update(Person newObject)
        {
            throw new NotImplementedException();
        }
    }
}
