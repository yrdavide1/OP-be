using Microsoft.AspNetCore.Mvc;
using OP_beModel.Entities;
using OP_beModel.Services;
using System.Security.Cryptography;
using System.Text;

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
            if(field == "Password") value = Md5Encode(value);
            var users = service.CustomFilter(field, value);
            return Ok(users);
        }
        #endregion

        #region CREATE
        [HttpPost]
        [Route("create")]
        public IActionResult CreateUser([FromBody] User u)
        {
            u.Password = Md5Encode(u.Password);
            service.CreateUser(u);
            return Created($"/api/user/id?id={u.PersonId}", null);
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
            u.Password = Md5Encode(u.Password);
            var user = service.UpdateUser(u);
            return Created($"/api/user/id?id={u.PersonId}", u);
        }

        [HttpPatch]
        [Route("update")]
        public IActionResult UpdateUserField([FromQuery] long id, [FromQuery] string field, [FromQuery] string value)
        {
            if(field == "Password") value = Md5Encode(value);
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
            password = Md5Encode(password);
            if (password == user.Password && username == user.Username) return Ok(user);
            return NoContent();
        }
        #endregion

        private static string Md5Encode(string str)
        {
            using (MD5 md5 = MD5.Create())
            {
                string hash = GetMd5Hash(md5, str);
                return hash;
            }
        }

        private static string GetMd5Hash(MD5 md5Hash, string str)
        {
            //converts string into byte array and computes the hash
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
