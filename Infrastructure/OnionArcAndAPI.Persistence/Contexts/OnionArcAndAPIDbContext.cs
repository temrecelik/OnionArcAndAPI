using Microsoft.EntityFrameworkCore;
using OnionArcAndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Persistence.Contexts
{
    //Context sınıfımızı API üzerinde erişebilmek için IoC container'a eklemeliyiz zaten ServiceRegistration'ı eklemiştik o zaman
    //Context sınıfımızı da ServiceRegistration'ın içine ekleriz böylece IoC container'a eklenmiş olur.
    public class OnionArcAndAPIDbContext : DbContext
    {
        public OnionArcAndAPIDbContext(DbContextOptions options) : base(options)
        {}


        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }  
        public DbSet<Order> Orders { get; set; }
    }
}
