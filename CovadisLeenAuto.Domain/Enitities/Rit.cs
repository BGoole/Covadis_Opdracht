using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeenAuto.Domain.Enitities
{
    public class Rit
    {
        public int ID { get; set; }
        public int WerknemerID { get; set; }
        public int LeenautoID { get; set; }
        public int KilometerStandBegin {  get; set; }
        public int KilometerStandEind { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
        public string StartAdres { get; set; }
        public string EindAdres { get; set; }
        //De klant wilt het liefst per kwartier
        // DateTime today = DateTime.Today;
        public virtual Werknemer? Werknemer { get; set; }
        public virtual LeenAuto? Leenauto { get; set; }
    }
}
