using Microsoft.AspNetCore.Mvc;
using OP_beModel.Entities;
using OP_beModel.Services;

//delegate IEnumerable<User> userSearch(string field);
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

        #region READ
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = service.GetAll();
            return Ok(users);
        }

        [HttpPost]
        [Route("id")]
        public IActionResult GetById([FromQuery] long id)
        {
            var user = service.GetUserById(id);
            return Ok(user);
        }

        //adding a single call which automatically choses the field to use to filter results
        [HttpPost]
        [Route("search")]
        public IActionResult FilterUsers([FromQuery] string field, [FromQuery] string value)
        {
            var users = service.CustomFilter(field, value);
            return Ok(users);
        }
        #endregion

        #region CREATE
        [HttpPost]
        [Route("create")]
        public IActionResult CreateUser([FromBody] User u)
        {
            service.CreateUser(u);
            return Created($"/api/user/id?id={u.PersonId}", u);
        }
        #endregion
    }
}
