using Microsoft.AspNetCore.Mvc;
using NegocioGalRio_API.Contexts;
using NegocioGalRio_API.Models;
using NegocioGalRio_API.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NegocioGalRio_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly RolService _rolService;
        public RolController(RolService rolService)
        {
            _rolService = rolService;
        }

        [HttpGet]
        public IEnumerable<Rol> Get()
        {
            return _rolService.GetRol();
        }
    }
}
