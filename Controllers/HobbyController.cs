using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTful_Web_API.Models;
using RESTful_Web_API.Services;

namespace RESTful_Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HobbyController : ControllerBase
    {
        // GET: HobbyController
        private readonly IHobby<Hobby> _IHobby;
        public HobbyController(IHobby<Hobby> IHobby)
        {
            _IHobby = IHobby;
        }



    }
}
