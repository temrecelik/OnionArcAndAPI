using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Domain.Entities.Common
{
    public class Order :BaseEntity
    {
        public string Description { get; set; }


        //projenin türüne göre adress sütunu customer tablosundada olabilir ama bir müşteri her zaman kendi profilindeki adrese 
        //sipariş vermek istemeyebilir bu nedenle küçük bir projede adresin Order tablosunda olması daha mantıklıdır.
        public string Address { get; set; }


        //bir siparişte birden fazla ürün olacağını ifade eder.
        public ICollection<Product> Products { get; set; }

        //bir siparişin sepetinin sadece bir müşteriye ait olduğunu belirtir.
        public Customer Customer { get; set; }
    }
}
