using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArcAndAPI.Application.Abstractions;
using OnionArcAndAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Persistence
{
    public static class ServiceRegistration //Registration sınıfı static olmalıdır. 
    {
        public static void AddPersistenceService(this IServiceCollection services) {

   
            //UseNpgsql postgresql'dir burada seçmek için persistence katmanına nuget managerden Postgressql'i yükledik
            services.AddDbContext<OnionArcAndAPIDbContext>(options => options.UseSqlServer("server=DESKTOP-EKSE2T7;database=OnionArcAndAPIDb;integrated security=true ;TrustServerCertificate=True"));
        }  
    }
}


