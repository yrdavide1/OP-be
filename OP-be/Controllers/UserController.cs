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

        #region DELETE 
        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteUser([FromQuery] long id)
        {
            var user = service.GetUserById(id);
            service.DeleteUser(id);
            return Ok(user);
        }
        #endregion

        #region UPDATE
        [HttpPut]
        [Route("update")]
        public IActionResult UpdateUser([FromBody] User u) //!!!REQUIRES ID IN REQUEST BODY!!!
        {
            var user = service.UpdateUser(u);
            return Created($"/api/user/id?id={u.PersonId}", u);
        }

        [HttpPatch]
        [Route("update")]
        public IActionResult UpdateUserField([FromQuery] long id, [FromQuery] string field, [FromQuery] string value)
        {
            var user = service.UpdateUserField(id, field, value);
            return Ok(user);
        }
        #endregion

        #region LOGIN
        [HttpPost]
        [Route("login")]
        public IActionResult UserLogin([FromQuery] string username, [FromQuery] string password)
        {
            User? user = service.CustomFilter("Username", username);
            if (password == user.Password && username == user.Username) return Ok(user);
            return NoContent();
        }
        #endregion
    }
}
