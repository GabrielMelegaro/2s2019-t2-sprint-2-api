using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Domains;
using Senai.Peoples.WebApi.Repositories;

namespace Senai.Peoples.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        PeopleRepository PeopleRepository = new PeopleRepository();

        [HttpGet]
        public IEnumerable<PeopleDomains> ListarTodos()
        {
            return PeopleRepository.Listar();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            PeopleDomains peopleDomains = PeopleRepository.BuscarPorId(id);
            if (peopleDomains == null)
                return NotFound();
            return Ok(peopleDomains);
        }
        
        [HttpPost]
        public IActionResult Cadastrar(PeopleDomains PeopleDomains)
        {
            PeopleRepository.Cadastrar(PeopleDomains);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            PeopleRepository.Deletar(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(PeopleDomains peopleDomains)
        {
            PeopleRepository.Atualizar(peopleDomains);
            return Ok();
        }
    }
}