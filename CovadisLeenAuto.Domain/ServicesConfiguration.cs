using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CovadisLeenAuto.Domain.Data;
using Microsoft.Extensions.DependencyInjection;

namespace CovadisLeenAuto.Domain
{
    public static class ServicesConfiguration
    {
        public static void RegisterServices(IServiceCollection services, string connectionString) {
            services.AddSqlite<LeenAutoContext>(connectionString);
        }
    }
}
