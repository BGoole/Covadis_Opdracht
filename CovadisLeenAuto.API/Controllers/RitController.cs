using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Domain.Enitities;
using CovadisLeenAuto.Shared.DTO.Ritten;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovadisLeenAuto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RitController : ControllerBase
    {
        private readonly IRitService ritService;

        public RitController(IRitService ritService) {
            this.ritService = ritService;
        }

        [HttpPost]
        public async Task<IActionResult> ReserveerRit(StoreRitten rit)
        {
            try
            {
                var id = await ritService.StoreRit(rit);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet] 
        public async Task<IActionResult> GeefAlleRitten()
        {
            return Ok(await ritService.GeefAlleRitten());
        }

    }
}
