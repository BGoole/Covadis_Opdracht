using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Domain.Data;
using CovadisLeenAuto.Domain.Enitities;
using CovadisLeenAuto.Shared.DTO.Ritten;
using Microsoft.EntityFrameworkCore;

namespace CovadisLeenAuto.Application.Repositories
{
    public class RitRepository : IRitRepository
    {
        public readonly LeenAutoContext leenAutoContext;

        public RitRepository(LeenAutoContext leenAutoContext)
        {
            this.leenAutoContext = leenAutoContext;
        }

        public async Task<int> StoreRit(StoreRitten rit)
        {
            if(!await leenAutoContext.LeenAutos.AnyAsync(b => b.ID == rit.LeenautoID)) {
                throw new Exception("Not a correct Leenauto ID and");
            }
            if(!await leenAutoContext.Werknemers.AnyAsync(b => b.ID == rit.WerknemerID))
            {
                throw new Exception("Not a correct Werknemer ID and");
            }

            var ritEnt = new Rit
            {
                WerknemerID = rit.WerknemerID,
                BeginDatum = rit.BeginDatum,
                EindDatum = rit.EindDatum,
                KilometerStandBegin = rit.KilometerStandBegin,
                KilometerStandEind = rit.KilometerStandEind,
                StartAdres = rit.StartAdres,
                EindAdres = rit.EindAdres,
                LeenautoID = rit.LeenautoID
            };

            await leenAutoContext.Ritten.AddAsync(ritEnt);

            await leenAutoContext.SaveChangesAsync();
            return ritEnt.ID;
        }
    }
}
