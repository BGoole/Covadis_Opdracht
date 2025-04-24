using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CovadisLeenAuto.Domain.Data
{
    public class LeenAutoContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Todo Database testdata vullen.
            //Entities nodig
        }
    }
}
