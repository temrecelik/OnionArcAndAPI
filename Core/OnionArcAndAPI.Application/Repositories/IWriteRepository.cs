using OnionArcAndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Application.Repositories
{
    /*
     Veri tabanına yazdırma servislerinin arayüzleri burada tanımlanır
     */
    public interface IWriteRepository<T> :IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);  //TASK YAPILANMASI ASYNC İŞ KODLARI İÇİN KULLANILMAKTADIR.

        Task<bool> AddRangeAsync(List<T> datas);

        bool Update(T model);

        bool Remove(T model);

        bool RemoveRange(List<T> datas);    

         Task<bool> RemoveAsync(string id);

        Task<int> SaveAsync();
    }
}
