using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Filmes.WebApi.Domains;
using Senai.Filmes.WebApi.Repositories;

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

        GeneroRepository GeneroRepository = new GeneroRepository();

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
        public IActionResult Cadastrar(GeneroDomain generoDomain)
        {
            //generos.Add(new GeneroDomain { IdGenero = generos.Count + 1, Nome = "Ação" });
            //generos.Add(new GeneroDomain { IdGenero = generos.Count + 1, Nome = generoDomain.Nome });   
            GeneroRepository.Cadastrar(generoDomain);
            //return Ok(generos);
            return Ok();
        }
        [HttpPut]
        public IActionResult Atualizar(GeneroDomain generoDomain)
        {
            GeneroDomain generoProcurado = generos.Find(x => x.IdGenero == generoDomain.IdGenero);
            generoProcurado.Nome = generoDomain.Nome;
            return Ok(generos);
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            generos.Remove(generos.Find(x => x.IdGenero == id));
            return Ok(generos);
        }
    }
}
