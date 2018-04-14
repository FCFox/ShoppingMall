using ShoppingMall.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMall.Domain.Infrastructure
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly DbContext context;
        private DbSet<T> dbSet;
        
        public Repository(DbContext _context)
        {
            this.context = _context;
            this.dbSet = this.context.Set<T>();
        }

        public long Count()
        {
            return this.dbSet.LongCount();
        }

        public void Remove(T entity)
        {
            this.dbSet.Remove(entity);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return this.dbSet.SingleOrDefault(predicate);
        }

        public IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate = null)
        {
            if(predicate==null)
            {
                return this.dbSet.AsEnumerable();
            }
            return this.dbSet.Where(predicate).ToList();
        }

        public void Add(T entity)
        {
            this.dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            this.dbSet.Attach(entity);
            this.context.Entry(entity).State = EntityState.Modified;
        }
    }
}
