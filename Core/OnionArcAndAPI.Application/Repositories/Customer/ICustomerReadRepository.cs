using OnionArcAndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Application.Repositories //klasörden gelen customer namespace'ini sildik yoksa hata alırız.
{
    public interface ICustomerReadRepository : IReadRepository<Customer>
    {
    }
}
