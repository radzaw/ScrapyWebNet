using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetMany(Func<T, bool> predicate = null);
        T Get(Func<T, bool> predicate);
        void Add(T entity);
        void Delete(T entity);
    }
}
