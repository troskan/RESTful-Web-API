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
    public class PersonController : Controller
    {
        private readonly IWebApi<Person> _IWebApi;
        public PersonController(IWebApi<Person> IWebApi)
        {
            _IWebApi = IWebApi;
        }
        
        [HttpGet]
        public async Task<ActionResult<Person>> GetAll()
        {
            try
            {

            return Ok(await  _IWebApi.GetAll());
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
                return Ok(await _IWebApi.Add(newPerson));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error to add Person in Database.");

            }
        }

    }
}
