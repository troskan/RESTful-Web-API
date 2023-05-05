using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;
using RESTful_Web_API.Services;

namespace RESTful_Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository<Person> _IPersonRepository;
        public PersonController(IPersonRepository<Person> IPersonRepository)
        {
            _IPersonRepository = IPersonRepository;
        }
        [HttpGet("GetHobbysBy/{id:int}")]
        public async Task<IActionResult> GetHobbysByID(int id)
        {
            return Ok(await _IPersonRepository.GetHobbys(id));
        } 
        [HttpGet("GetLinksBy/{id:int}")]
        public async Task<IActionResult> GetLinksByID(int id)
        {
            return Ok(await _IPersonRepository.GetLinks(id));
        }

        [HttpGet]
        public async Task<ActionResult<Person>> GetAll()
        {
            try
            {

            return Ok(await _IPersonRepository.GetAll());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to retrieve data from Person in Database.");
            }
        }
        [HttpPost]
        public async Task<ActionResult<Person>> AddPerson(Person newPerson)
        {
            try
            {
                return Ok(await _IPersonRepository.Add(newPerson));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add Person in Database.");

            }
        }

    }
}
