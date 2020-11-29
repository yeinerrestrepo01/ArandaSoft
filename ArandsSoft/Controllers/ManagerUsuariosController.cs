using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DataAccesLayer;
using Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ArandaSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerUsuariosController : ControllerBase
    {
        private readonly IDataRepository<Usuarios> _DataRepository;

        public ManagerUsuariosController(IDataRepository<Usuarios> DataRepository) 
        {
            _DataRepository = DataRepository;
        }
        // GET: api/<ManagerUsuariosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_DataRepository.GetAll());
        }

        // GET api/<ManagerUsuariosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_DataRepository.Get(id));
        }

        // POST api/<ManagerUsuariosController>
        [HttpPost]
        public IActionResult Post([FromBody] Usuarios value)
        {
            return Ok(_DataRepository.Add(value));
        }

        // PUT api/<ManagerUsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ManagerUsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
