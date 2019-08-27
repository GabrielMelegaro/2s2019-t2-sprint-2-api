using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Optus.WebApi.Domains;
using Senai.Optus.WebApi.Repositories;

namespace Senai.Optus.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EstilosController : ControllerBase
    {
        EstiloRepository EstiloRepository = new EstiloRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(EstiloRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Estilos estilos)
        {
            try
            {
                EstiloRepository.Cadastrar(estilos);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new { mensagem = "Eita Erro" + ex.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Estilos Estilo = EstiloRepository.BuscarPorId(id);
            if (Estilo == null)
                return NotFound();
             return Ok(Estilo);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            EstiloRepository.Deletar(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(Estilos estilos)
        {
            try
            {
                Estilos EstiloBuscado = EstiloRepository.BuscarPorId
                    (estilos.IdEstilo);
                
                if (EstiloBuscado == null)
                    return NotFound();
                
                EstiloRepository.Atualizar(estilos);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Ah, não." });
            }
        }
    }
}