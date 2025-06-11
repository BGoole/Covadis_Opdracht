using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Shared.DTO.Werknemers;

namespace CovadisLeenAuto.Application.Services
{
    public class WerknemerService : IWerknemerService
    {
        private readonly IWerknemerRepository werknemerRepository;

        public WerknemerService(IWerknemerRepository werknemerRepository)
        {
            this.werknemerRepository = werknemerRepository;
        }
        public IEnumerable<GeefWerknemers> GeefWerknemers()
        {
            return werknemerRepository.GeefWerknemers();
        }
    }
}
