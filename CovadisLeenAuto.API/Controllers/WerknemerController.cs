using CovadisLeenAuto.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovadisLeenAuto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WerknemerController : ControllerBase
    {
        private readonly IWerknemerRepository werknemerRepository;


    }
}
