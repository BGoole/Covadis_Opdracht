using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Domain.Data;
using CovadisLeenAuto.Shared.DTO.Ritten;

namespace CovadisLeenAuto.Application.Services
{
    public class RitService : IRitService
    {
        private readonly IRitRepository ritRepository;
        public RitService(IRitRepository ritRepository)
        {
            this.ritRepository = ritRepository;
        }
        public async Task<int> StoreRit(StoreRitten rit)
        {
            return await ritRepository.StoreRit(rit);
        }
        public async Task<IEnumerable<GeefAlleRitten>> GeefAlleRitten()
        {
            return await ritRepository.GeefAlleRitten();
        }
    }   
}
