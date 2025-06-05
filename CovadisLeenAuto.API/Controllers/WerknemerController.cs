using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Shared.DTO.Werknemers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovadisLeenAuto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WerknemerController : ControllerBase
    {
        private readonly IWerknemerService werknemerService;

        public WerknemerController(IWerknemerService werknemerService)
        {
            this.werknemerService = werknemerService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<GeefAlleWerknemers>> GeefAlleWerknemers()
        {
            return Ok(werknemerService.GeefAlleWerknemers());
        }
    }
}
