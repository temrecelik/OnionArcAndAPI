using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Application.Repositories
{
    /*
     IReadRepository veritabanında veri okuma ile alakalı servislerin ınterface'leri bulunur
     */
    public interface IReadRepository<T> :IRepository<T> where T : class
    {
        //veri tabanından ilgili tablodaki tüm veriler getirir.
        IQueryable<T> GetAll();

        //istenilen özelliğe göre ilgili tablodan veriler getirilir.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        //istenilen özelliğe göre ilk satırı döndürür.async çalışır orm'ye göre
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);

        //idye göre tek bir satır getirir.async çalışır orm'ye göre
        Task<T> GetByIdAsync(string id);
    }
}
