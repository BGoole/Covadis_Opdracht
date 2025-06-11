using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeenAuto.Shared.DTO.LeenAutos
{
    public class GeefAlleLeenAutos
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public DateTime GereserveerdVan { get; set; }
        public DateTime GereserveerdTot { get; set; }
        public bool Gereserveerd { get; set; }
    }
}
