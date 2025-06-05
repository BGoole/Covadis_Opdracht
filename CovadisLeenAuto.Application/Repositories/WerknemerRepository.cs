using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Domain.Data;
using CovadisLeenAuto.Shared.DTO.Werknemers;

namespace CovadisLeenAuto.Application.Repositories
{
    public class WerknemerRepository : IWerknemerRepository
    {
        private readonly LeenAutoContext leenAutoContext;

        public WerknemerRepository(LeenAutoContext leenAutoContext)
        {
            this.leenAutoContext = leenAutoContext;
        }
        public IEnumerable<GeefAlleWerknemers> GeefAlleWerknemers()
        {
            return leenAutoContext.Werknemers.Select(x => new GeefAlleWerknemers
            {
                ID = x.ID,
                Naam = x.Naam,
            }).ToList();
        }
    }
}
