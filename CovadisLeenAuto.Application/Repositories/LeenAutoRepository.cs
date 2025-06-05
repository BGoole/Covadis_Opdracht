using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Domain.Data;
using CovadisLeenAuto.Shared.DTO.LeenAutos;

namespace CovadisLeenAuto.Application.Repositories
{
    public class LeenAutoRepository : ILeenAutoRepository
    {
        private readonly LeenAutoContext leenAutoContext;
        public LeenAutoRepository(LeenAutoContext leenAutoContext)
        {
            this.leenAutoContext = leenAutoContext;
        }
        public IEnumerable<GeefAlleLeenAutos> GeefAlleLeenAutos()
        {
            return leenAutoContext.LeenAutos.Select(x => new GeefAlleLeenAutos
            {
                ID = x.ID,
                GereserveerdVan = x.GereserveerdVan,
                GereserveerdTot = x.GereserveerdTot,
                Gereserveerd = x.Gereserveerd,
                Type = x.Type,
            }).ToList();
        }
    }
}
