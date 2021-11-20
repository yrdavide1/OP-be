using Microsoft.AspNetCore.Mvc;
using OP_beModel.Services;
using OP_beModel.Entities;

namespace OP_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        private IPeopleService service;

        public AdminController(IPeopleService service)
        {
            this.service = service;
        }

        #region READ
        [HttpGet]
        public IActionResult GetAll()
        {
            var admins = service.GetAdministrators();
            return Ok(admins);
        }

        [HttpPost]
        [Route("id")]
        public IActionResult GetById([FromQuery] long id)
        {
            var admin = service.GetAdminById(id);
            return Ok(admin);
        }
        #endregion

        #region CREATE
        [HttpPost]
        [Route("create")]
        public IActionResult CreateAdmin([FromBody] Administrator a)
        {
            service.CreateAdministrator(a);
            return Created($"/api/admin/id?id={a.PersonId}", a);
        }
        #endregion

        #region DELETE
        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteAdmin([FromQuery] long id)
        {
            var admin = service.GetAdminById(id);
            service.DeleteAdministrator(id);
            return Ok(admin);
        }
        #endregion
    }
}
