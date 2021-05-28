using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcces
{
  public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
       
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // filter null dersek tüm datayı istediğimizi kastederiz
        T Get(Expression<Func<T, bool>> filter);


    }
}


