using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    interface IDbRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(string id);
        void Add(T entity);
        void Delete(T entity);
    }
}
