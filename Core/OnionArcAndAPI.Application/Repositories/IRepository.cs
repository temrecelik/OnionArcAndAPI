using Microsoft.EntityFrameworkCore;
using OnionArcAndAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcAndAPI.Application.Repositories
{

    //temel arayüzler burada tutulur
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table {  get; }

    }
}
