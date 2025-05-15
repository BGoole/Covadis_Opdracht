using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Shared.DTO.LeenAutos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovadisLeenAuto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeenAutoController : ControllerBase
    {
        private readonly ILeenAutoService leenAutoService;

        public LeenAutoController(ILeenAutoService leenAutoService)
        {
            this.leenAutoService = leenAutoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GeefAlleLeenAutos>> GeefLeenAutos()
        {
            return Ok(leenAutoService.GeefAlleLeenAutos());
        }
    }
}
