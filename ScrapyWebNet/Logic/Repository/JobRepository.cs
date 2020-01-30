using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    public class JobRepository : IRepository<Job>
    {
        private IApiClient apiClient = null;

        public JobRepository(IApiClient apiClient)
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

        public Job Get(Func<Job, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Job> GetMany(Func<Job, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
