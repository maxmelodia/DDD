using System;
using Microsoft.AspNetCore.Mvc;
using DDD.Domain.Entities;
using DDD.Service.Services;
//maxwell
namespace DDD.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/Produto")]
    public class ProdutoController : ControllerBase
    {
         private BaseService<Produto> service = new BaseService<Produto>();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}