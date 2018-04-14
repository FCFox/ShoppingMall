using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.Domain.Abstract
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T Get(Expression<Func<T,bool>> predicate);
        void Remove(T entity);
        void Update(T entity);
        void Add(T entity);
        long Count();
    }
}
