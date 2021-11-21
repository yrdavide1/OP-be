using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_beModel.Repositories
{
    public interface ICrudRepository<T, K>
    {
        T Create(T entity);
        void Delete(T entity);
        void Delete(K key);
        T Update(T entity);
        T? FindById(K key);
        IEnumerable<T> GetAll();
    }
}
