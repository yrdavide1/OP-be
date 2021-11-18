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

        #region READ
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = service.GetAll();
            return Ok(users);
        }

        [HttpPost]
        [Route("address")]
        public IActionResult GetByAddress([FromQuery] string address)
        {
            var users = service.GetUsersByAddress(address);
            return Ok(users);
        }

        [HttpPost]
        [Route("city")]
        public IActionResult GetByCity([FromQuery] string city)
        {
            var users = service.GetUsersByCity(city);
            return Ok(users);   
        }

        [HttpPost]
        [Route("dateofbirth")]
        public IActionResult GetByDateOfBirth([FromQuery] string dateOfBirth)
        {
            var users = service.GetUsersByDateOfBirth(dateOfBirth);
            return Ok(users);
        }

        [HttpPost]
        [Route("email")]
        public IActionResult GetByEmail([FromQuery] string email)
        {
            var users = service.GetUsersByEmail(email);
            return Ok(users);
        }

        [HttpPost]
        [Route("firstname")]
        public IActionResult GetByFirstName([FromQuery] string firstname)
        {
            var users = service.GetUsersByFirstName(firstname);
            return Ok(users);
        }

        [HttpPost]
        [Route("gender")]
        public IActionResult GetByGender([FromQuery] string gender)
        {
            var users = service.GetUsersByGender(gender);
            return Ok(users);
        }

        [HttpPost]
        [Route("id")]
        public IActionResult GetById([FromQuery] long personId)
        {
            var users = service.GetUsersById(personId);
            return Ok(users);
        }

        [HttpPost]
        [Route("lastname")]
        public IActionResult GetByLastName([FromQuery] string lastname)
        {
            var users = service.GetUsersByLastName(lastname);
            return Ok(users);
        }

        [HttpPost]
        [Route("phone")]
        public IActionResult GetByPhoneNumber([FromQuery] string phoneNumber)
        {
            var users = service.GetUsersByPhoneNumber(phoneNumber);
            return Ok(users);
        }
        #endregion
    }
}
