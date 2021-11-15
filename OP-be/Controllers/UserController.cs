using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OP_be.DTOs;
using OP_beModel.Services;

namespace OP_be.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private IPeopleService service;
        private IMapper mapper;

        public UserController(IPeopleService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = service.GetAll();
            var usersDTOs = mapper.Map<IEnumerable<UserDTO>>(users);
            return Ok(usersDTOs);
        }
    }
}
