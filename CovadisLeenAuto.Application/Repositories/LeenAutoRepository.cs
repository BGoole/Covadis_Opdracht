using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Application.Interfaces;
using CovadisLeenAuto.Domain.Data;
using CovadisLeenAuto.Domain.Enitities;
using CovadisLeenAuto.Shared.DTO.LeenAutos;
using Microsoft.EntityFrameworkCore;

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
        public async Task UpdateLeenAuto(int id, UpdateLeenAuto leenAuto)
        {
            if(id != leenAuto.ID)
            {
                throw new ValidationException("Ids are not corresponding");
            }
            //if(!await leenAutoContext.LeenAutos.AnyAsync(n => n.ID == leenAuto.))
            //{

            //}
            LeenAuto? leenAutoEnt = await leenAutoContext.LeenAutos.SingleOrDefaultAsync(n => n.ID == id);

            if (leenAutoEnt == null)
            {
                throw new Exception("No auto found");
            }
            leenAutoEnt.GereserveerdVan = leenAuto.GereserveerdVan;
            leenAutoEnt.GereserveerdTot = leenAuto.GereserveerdTot;
            if (leenAutoEnt.Gereserveerd == true)
            {
                leenAutoEnt.Gereserveerd = false;
            } else
            {
                leenAutoEnt.Gereserveerd = true;
            }

            //MapAuto(leenAutoEnt, leenAuto);

            await leenAutoContext.SaveChangesAsync();
           ///Hier was ik
        }
        public async Task<GeefLeenAuto?> GeefLeenAuto(int id)
        {
            LeenAuto? leenauto = await leenAutoContext.LeenAutos.SingleOrDefaultAsync(n => n.ID == id);
            return MapAuto(leenauto);
        }
        private static void MapAuto(LeenAuto leenautoEnt, UpdateLeenAuto leenauto)
        {
            leenautoEnt.GereserveerdVan = leenauto.GereserveerdVan;
            leenautoEnt.Gereserveerd = leenauto.Gereserveerd;
            leenautoEnt.GereserveerdTot = leenauto.GereserveerdTot;
            leenautoEnt.KilometerStand = leenauto.KilometerStand;
            leenautoEnt.Kenteken = leenauto.Kenteken;
            leenautoEnt.Type = leenauto.Type;
        }
        private static GeefLeenAuto? MapAuto(LeenAuto? leenauto)
        {
            if (leenauto == null) return null;
            return new GeefLeenAuto()
            {
                ID = leenauto.ID,
                GereserveerdVan = leenauto.GereserveerdVan,
                Gereserveerd = leenauto.Gereserveerd,
                GereserveerdTot = leenauto.GereserveerdTot,
                KilometerStand = leenauto.KilometerStand,
                Kenteken = leenauto.Kenteken,
                Type = leenauto.Type,
            };
        }
    }
}
