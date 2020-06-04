using ColegioOpcaoA.Repositorio.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ColegioOpcaoA.Web.Controllers
{
    [Route("api/[Controller]")]
    public class BaseController : Controller
    {
        private readonly SeedingService _seedingService;
        public BaseController(SeedingService seedingService)
        {
            _seedingService = seedingService;
        }

        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                _seedingService.Seed();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }
    }
}
