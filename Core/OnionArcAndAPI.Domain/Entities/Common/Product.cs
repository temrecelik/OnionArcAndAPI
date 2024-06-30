using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Domain.Entities.Common
{
    public class Product :BaseEntity
    {
        public string Name {  get; set; }

        public int Stock {  get; set; }

        public long Price { get; set; }

        //bir ürünün birden fazla siparişte olabileceğini ifade eder.v
        public ICollection<Order>Orders { get; set; }
    }
}
