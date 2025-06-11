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
        public IEnumerable<GeefWerknemers> GeefWerknemers()
        {
            return leenAutoContext.Werknemers.Select(x => new GeefWerknemers
            {
                ID = x.ID,
                Naam = x.Naam,
            }).ToList();
        }
    }
}
