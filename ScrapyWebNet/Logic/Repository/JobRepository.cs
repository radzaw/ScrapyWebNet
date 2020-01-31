using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    public class JobRepository : IRepository<Job>
    {
        private IScrapydAPI apiClient = null;

        public JobRepository(IScrapydAPI apiClient)
        {
            this.apiClient = apiClient;
        }

        public void Add(Job entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Job entity)
        {
            throw new NotImplementedException();
        }

        public Job Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
