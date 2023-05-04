using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;

namespace RESTful_Web_API.Services
{
    public class PersonRepository : IPersonRepository<Person>
    {
        private Context _db;
        public PersonRepository(Context db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Hobby>> GetHobbys(int id)
        {
            var query =
            from ph in _db.PersonHobby
            join h in _db.Hobby on ph.HobbyID equals h.HobbyID
            join p in _db.Person on ph.PersonID equals p.PersonID
            where ph.PersonID == id
            select h;
            //select $"ID:{p.PersonID}, Name:{p.FirstName}, HobbyID:{ph.HobbyID} Hobby name:{h.HobbyName}";

            return await query.ToListAsync();
        } 
        public async Task<IEnumerable<Link>> GetLinks(int id)
        {
            var query =
            from ph in _db.PersonHobby
            join l in _db.Link on ph.LinkID equals l.LinkID
            join p in _db.Person on ph.PersonID equals p.PersonID
            where ph.PersonID == id
            select l;

            return await query.ToListAsync();
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
