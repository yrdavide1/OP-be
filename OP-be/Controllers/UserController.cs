using Microsoft.AspNetCore.Mvc;
using OP_beModel.Services;

namespace OP_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IPeopleService service;

        public UserController(IPeopleService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = service.GetAll();
            return Ok(users);
        }
    }
}
