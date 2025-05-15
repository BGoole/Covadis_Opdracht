using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeenAuto.Domain.Enitities
{
    public class LeenAuto
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Kenteken { get; set; }
        public bool Gereserveerd { get; set; }
        public DateTime GereserveerdVan { get; set; }
        public DateTime GereserveerdTot { get; set; }
        public int KilometerStand { get; set; }
    }
}
