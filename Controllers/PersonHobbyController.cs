using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTful_Web_API.Models;
using RESTful_Web_API.Services;

namespace RESTful_Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonHobbyController : ControllerBase
    {
        private readonly IWebApi<PersonHobby> _IWebApi;
        public PersonHobbyController(IWebApi<PersonHobby> IWebApi)
        {
            _IWebApi = IWebApi;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _IWebApi.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> AddPersonHobby(PersonHobby newObject)
        {
            try
            {
                return Ok(await _IWebApi.Add(newObject));
            }
            catch (Exception)
            {
                return BadRequest(StatusCode(StatusCodes.Status500InternalServerError));
            }
        }
        
    }
}
