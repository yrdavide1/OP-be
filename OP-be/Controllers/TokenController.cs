using Microsoft.AspNetCore.Mvc;
using OP_beModel.Services;

namespace OP_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        private IPeopleService service;

        public TokenController(IPeopleService service)
        {
            this.service = service;
        }

        #region READ
        [HttpGet]
        [Route("id")]
        public IActionResult GetById([FromQuery] long id)
        {
            var token = service.GetTokenById(id);
            return Ok(token);
        }
        #endregion
    }
}
