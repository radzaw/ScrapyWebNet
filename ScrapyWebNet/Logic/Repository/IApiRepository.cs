using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    interface IApiRepository<T> where T : class
    {
        void SetNode(Node node);

        List<T> GetAll();
        T Get(string id);
        void Add(T entity);
        void Delete(T entity);
    }
}
