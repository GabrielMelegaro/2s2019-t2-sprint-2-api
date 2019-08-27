using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Optus.WebApi.Repositories
{
    public class ArtistaRepository
    {
        ArtistaRepository ArtistasRepository = new ArtistaRepository();

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(ArtistasRepository.Listar());
        }
    }
}
