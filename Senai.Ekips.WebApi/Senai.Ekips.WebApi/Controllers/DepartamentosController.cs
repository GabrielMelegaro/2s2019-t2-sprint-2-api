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
    public class DepartamentosController : ControllerBase
    {
        DepartamentoRepository DepartamentosRepository = new DepartamentoRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(DepartamentosRepository.Listar());
        }

        [HttpPost]
        public void Cadastrar(Departamentos Departamento)
        {
            using (EkipsContext ctx = new EkipsContext())
            {
                ctx.Departamentos.Add(Departamento);

                ctx.SaveChanges();
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            Departamentos Departamento = DepartamentosRepository.BuscarPorId(id);
                if (Departamento == null) 
                return NotFound();
            return Ok(Departamento);
        }
    }
}