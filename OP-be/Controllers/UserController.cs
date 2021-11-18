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

        //adding a single call which automatically choses the field to use to filter results
        [HttpPost]
        [Route("search")]
        public IActionResult FilterUsers([FromQuery] string field, [FromQuery] string value)
        {
            var users = service.CustomFilter(field, value);
            return Ok(users);
        }

        #endregion
    }
}
