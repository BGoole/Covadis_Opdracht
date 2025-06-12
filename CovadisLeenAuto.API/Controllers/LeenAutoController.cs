using System.ComponentModel.DataAnnotations;
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
        public async Task<ActionResult<IEnumerable<GeefAlleLeenAutos>>> GeefLeenAutos()
        {
            return Ok(leenAutoService.GeefAlleLeenAutos());
        }
        [HttpGet("{ID}")]
        public async Task<IActionResult> GeefLeenAuto(int ID)
        {
            GeefLeenAuto? retval = await leenAutoService.GeefLeenAuto(ID);
            return retval != null ? Ok(retval) : NotFound();
        }
        [HttpPut("{ID}")]
        public async Task<IActionResult> UpdateLeenAuto(int ID, UpdateLeenAuto leenauto)
        {
            try
            {
                await leenAutoService.UpdateLeenAuto(ID, leenauto);
                return Ok();
            } catch(ValidationException ex)
            {
                return BadRequest(ex.Message);
            } catch( Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
    }
}
