using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Shared.DTO.LeenAutos;

namespace CovadisLeenAuto.Application.Interfaces
{
    public interface ILeenAutoRepository
    {
        IEnumerable<LeenAutoListItem> GeefAlleLeenAutos();

    }
}
