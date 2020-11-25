using Microsoft.AspNetCore.Mvc;
using CatalogoMarinho.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoMarinho.API.Controllers
{
    public class EspecieController
    {
        [ApiController]
        [Route("Especie")]
        public class EspecieController : ControllerBase
        {
            [HttpPost]
            [Route("Cadastrar")]
            public ActionResult AddEspecie(Especie especie)
            {
                var resultado = new Especie().Adicionar(especie);

                if (resultado == true)
                {
                    return Ok("Adicionado com Sucesso");
                }
                return BadRequest("Essa especíe já existe");
            }
        }
    }
}
