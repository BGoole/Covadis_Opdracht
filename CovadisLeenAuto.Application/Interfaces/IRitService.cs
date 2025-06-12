using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Shared.DTO.Ritten;

namespace CovadisLeenAuto.Application.Interfaces
{
    public interface IRitService
    {
        Task<int> StoreRit(StoreRitten rit);
        Task<IEnumerable<GeefAlleRitten>> GeefAlleRitten();
    }
}
