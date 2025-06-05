using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Shared.DTO.Werknemers;

namespace CovadisLeenAuto.Application.Interfaces
{
    public interface IWerknemerRepository
    {
        IEnumerable<GeefAlleWerknemers> GeefAlleWerknemers();
    }
}
