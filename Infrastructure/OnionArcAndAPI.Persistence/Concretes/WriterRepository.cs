using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
    public class WriterRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly OnionArcAndAPIDbContext _Context;

        public WriterRepository(OnionArcAndAPIDbContext context)
        {
            _Context = context;
        }

        public DbSet<T> Table => _Context.Set<T>(); 


        public async Task<bool> AddAsync(T model)
        {
           EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(T model)
        {
          EntityEntry<T> entityEntry = Table.Remove(model);
          return entityEntry.State == EntityState.Deleted;
        }
        
        public bool RemoveRange(List<T> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveAsync(string id)
        {
             T model=Table.FirstOrDefault(data => data.Id == Guid.Parse(id));//burada parametredek id string baseEntity'den gelen ise guid bu nedenle Guid.Parse yapıyoruz.
             return Remove(model); //silinecek veriyi bulup modele attık remove fonksiyonumuz ile de sildik.
        }

       
        public async Task<int> SaveAsync()
       =>await _Context.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry<T>  entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }


    

        
    }
}
