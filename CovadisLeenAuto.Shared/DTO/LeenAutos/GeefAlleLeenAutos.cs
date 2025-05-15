using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovadisLeenAuto.Shared.DTO.LeenAutos
{
    public class LeenAutoListItem
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public bool Gereserveerd { get; set; }
    }
}
