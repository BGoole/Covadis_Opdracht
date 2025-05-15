using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Shared.DTO.LeenAutos;

namespace CovadisLeenAuto.Application.Services
{
    public class LeenAutoService : ILeenAutoService
    {
        private readonly ILeenAutoRepository leenAutoRepository;
        public LeenAutoService(ILeenAutoRepository leenAutoRepository) { 
            this.leenAutoRepository = leenAutoRepository;
        }
        public IEnumerable<LeenAutoListItem> GeefAlleLeenAutos()
        {
            return leenAutoRepository.GeefAlleLeenAutos();
        }
    }
}
