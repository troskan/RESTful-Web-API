using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTful_Web_API.Data;
using RESTful_Web_API.Models;
using RESTful_Web_API.Services;

namespace RESTful_Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonHobbyController : ControllerBase
    {
        private readonly IWebApi<PersonHobby> _IWebApi;
        private readonly Context _db;
        public PersonHobbyController(IWebApi<PersonHobby> IWebApi, Context db)
        {
            _IWebApi = IWebApi;
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _IWebApi.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> AddPersonHobby(PersonHobbyDTO newObject)
        {
            try
            {
                var result = new PersonHobby();
                result.HobbyID = newObject.HobbyID;
                result.PersonID = newObject.PersonID;
                result.LinkID = newObject.LinkID;


                return Ok(await _IWebApi.Add(result));
            }
            catch (Exception)
            {
                return BadRequest(StatusCode(StatusCodes.Status500InternalServerError));
            }
        }
        
    }
}
