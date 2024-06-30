using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Domain.Entities.Common
{
/*    
    NOT:Entity'ler onion mimarisinde domain katmanının içinde oluşturulur.

    Bu iki bilgi tüm Entity'lerde bulunacağı için base Entity'de bir kere kullanarak kod tekrarından kaçınabiliriz.Bunu diğer
    Entity'leri bu baseEntity'den miras aldırarak sağlarız.
                                                                    */
    public  class BaseEntity
    {
    //Guid veri tipi(globally unique identifier) 463C2A03-277A-485E-ACEB-8891886F4D11 gibi unique değerleri tuan veri tipidir.
        public Guid Id { get; set; }
        

        public DateTime CreatedDate { get; set; }
    }
}
