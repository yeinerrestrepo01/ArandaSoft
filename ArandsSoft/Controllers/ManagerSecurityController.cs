using BusinessLogicLayer;
using Entities;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArandaSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerSecurityController : ControllerBase
    {
        private readonly ManagerSecurity _ManagerSecurity;
        public ManagerSecurityController(ManagerSecurity ManagerSecurity) 
        {
            _ManagerSecurity = ManagerSecurity;   
        }

        // POST api/<ManagerSecurityController>
        [HttpPost]
        public IActionResult Post([FromBody] UsuariosLogin value)
        {
            return Ok(_ManagerSecurity.Login(value));
        }
    }
}
