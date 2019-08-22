using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Filmes.WebApi.Domains;

namespace Senai.Filmes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        List<GeneroDomain> generos = new List<GeneroDomain>()
        {
            new GeneroDomain { IdGenero = 1, Nome = "Terror" },
            new GeneroDomain { IdGenero = 2, Nome = "Comédia" }
        };

        [HttpGet]
        public IEnumerable<GeneroDomain> Get()
        {
            return generos;
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            GeneroDomain Genero = generos.Find(x => x.IdGenero == id);
            if (Genero == null)
            {
                return NotFound();
            }
            return Ok(Genero);
        }
        [HttpPost]
        public IActionResult Cadastrar()
        {
            generos.Add(new GeneroDomain { IdGenero = generos.Count + 1, Nome = "Ação" });
            return Ok(generos);
        }
    }
}
