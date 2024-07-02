using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Domain.Entities.Common
{
    public class Customer : BaseEntity
    {
        //Bir Müşterinin birden fazla siparişi olabileceğini ifade eder.Aynı şeyi Order entity'si için yapmayız çünkü
        //bir siparişin birden fazla müşteri yoktur.
        public ICollection<Order> Orders { get; set; }
          
    }
}
