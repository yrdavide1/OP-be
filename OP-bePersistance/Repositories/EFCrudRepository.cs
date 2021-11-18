using Microsoft.EntityFrameworkCore;
using OP_beContext.EFContext;
using OP_beModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beContext.Repositories
{
    public class EFCrudRepository<T, K> : ICrudRepository<T, K> where T : class
    {
        protected readonly OPbeContext ctx;
        private DbSet<T> entities;

        public EFCrudRepository(OPbeContext ctx)
        {
            this.ctx = ctx;
            entities = ctx.Set<T>();
        }
        public T Create(T entity)
        {
            entities.Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public void Delete(K key)
        {
            T found = entities.Find(key);
            entities.Remove(found);
        }

        public IEnumerable<T> FindById(K key)
        {
            var found = new List<T>();
            found.Add(entities.Find(key));
            return found;
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Update(T entity)
        {
            entities.Update(entity);
            return entity;
        }
    }
}
