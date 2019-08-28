using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Ekips.WebApi.Domains;
using Senai.Ekips.WebApi.Repositories;

namespace Senai.Ekips.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        FuncionarioRepository FuncionarioRepository = new FuncionarioRepository();
        
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(FuncionarioRepository.Listar());
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionarios funcionario)
        {
            try
            {
                FuncionarioRepository.Cadastrar(funcionario);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new { mensagem = "Algo de ERRADO não está CERTO" + ex.Message });
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Funcionarios Funcionario = FuncionarioRepository.BuscarPorId(id);
            if (Funcionario == null)
                return NotFound();
            return Ok(Funcionario);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            FuncionarioRepository.Deletar(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Atualizar(Funcionarios funcionario)
        {
            try
            {
                Funcionarios FuncionarioBuscado = FuncionarioRepository.BuscarPorId(funcionario.IdFuncionario);
                if (FuncionarioBuscado == null)
                    return NotFound();
                FuncionarioRepository.Atualizar(funcionario);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new { mensagem = "Voce Errou hihihi." });
            }
        }
    }
}