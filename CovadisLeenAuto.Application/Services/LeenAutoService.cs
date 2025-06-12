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
        public IEnumerable<GeefAlleLeenAutos> GeefAlleLeenAutos()
        {
            return leenAutoRepository.GeefAlleLeenAutos();
        }
        public async Task UpdateLeenAuto(int id, UpdateLeenAuto leenauto)
        {
            await leenAutoRepository.UpdateLeenAuto(id, leenauto);
        }
        public async Task<GeefLeenAuto?> GeefLeenAuto(int id)
        {
            return await leenAutoRepository.GeefLeenAuto(id);
        }
    }
}
