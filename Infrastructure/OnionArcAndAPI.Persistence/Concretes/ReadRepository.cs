using Microsoft.EntityFrameworkCore;
using OnionArcAndAPI.Application.Repositories;
using OnionArcAndAPI.Domain.Entities.Common;
using OnionArcAndAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Persistence.Concretes
{
    internal class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
   //baseEntity zaten bir classtır içinde her entityde olması gereken sütünları tutar bu sütunlardan en ilki id olmalıdır.
   //Biz id'ye göre veri çekerken buraya class yazarsak her classta id olmayabilir ancak her BaseEntity'de muhakkak bir id vardır.Zaten
   //her entity'de baseEntity'i classını miras aldığı için sorun ortadan kalkar.

    {
        private readonly OnionArcAndAPIDbContext _context;

        public ReadRepository(OnionArcAndAPIDbContext context)
        {
            _context = context;
        }

        //BU T entitysinin tablosunu çeker.Bu tabloya göre veri tabanının iş kodlarını kodlayabiliriz.
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
        => Table;
        
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        =>Table.Where(method);
        
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        =>await Table.FirstOrDefaultAsync(method);
        
        
        public async Task<T> GetByIdAsync(string id)
        =>await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));

        
            
      
    }
}
