using OnionArcAndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Application.Abstractions
{
    /*
     Bütün interfaceler Application katmanında yazılır bu interfacelerden oluşturulacak classlar ise interface'in türüne göre
    Infrastructure ya da persistence katmanına yazılır.Entities'lerden oluşturduğumuz kodlar veri tabanı işlerinde kullanıldığı 
    için bu interface'den türetilecek class persistence katmanında Concrete klasöründe türetilmelidir.
     */
   public interface IProductService
    {
        List<Product> GetProducts();
    }
}
