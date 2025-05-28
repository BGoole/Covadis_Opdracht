using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeenAuto.Shared.DTO.Ritten
{
    public class StoreRitten
    {
        public int ID { get; set; }
        public int WerknemerID { get; set; }
        public int KilometerStandBegin { get; set; }
        public int KilometerStandEind { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public string StartAdres { get; set; }
        public string EindAdres { get; set; }
    }
}
