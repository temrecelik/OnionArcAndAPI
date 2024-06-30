using Microsoft.Extensions.DependencyInjection;
using OnionArcAndAPI.Application.Abstractions;
using OnionArcAndAPI.Persistence.Concretes;
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

            services.AddSingleton<IProductService,ProductService>();  
        }  
    }
}


