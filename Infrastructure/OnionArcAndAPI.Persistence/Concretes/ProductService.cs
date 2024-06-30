using OnionArcAndAPI.Application.Abstractions;
using OnionArcAndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
       => new() //bu şekilde fonksiyon cinsinden bir liste oluşturulur.
       {
           //Guid.NewGuid() ile her seferinde Guid türünde başka değer oluşturulur.Normalde bu fonksiyon verileri veri
           //tabanında getirecek biz deneme amaçlı kendimiz veriler girdik
           new(){Id =Guid.NewGuid() ,Name="Product 1" ,Price=100,Stock=10},
           new(){Id =Guid.NewGuid() ,Name="Product 2" ,Price=200,Stock=10},
           new(){Id =Guid.NewGuid() ,Name="Product 3" ,Price=300,Stock=10},
           new(){Id =Guid.NewGuid() ,Name="Product 4" ,Price=400,Stock=10},
           new(){Id =Guid.NewGuid() ,Name="Product 5" ,Price=500,Stock=10},

       };
    }
}
