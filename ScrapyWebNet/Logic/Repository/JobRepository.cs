using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    public class JobRepository : IApiRepository<Job>
    {
        private IScrapydAPI apiClient = null;
        private Node node = null;

        public JobRepository(IScrapydAPI apiClient)
        {
            this.apiClient = apiClient;
        }

        /// <summary>
        /// Sets node instance for API requests; jobs and projects are dependent on Nodes
        /// </summary>
        /// <param name="node">node instance</param>
        public void SetNode(Node node)
        {
            this.node = node;
        }

        public void Add(Job entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Job entity)
        {
            this.apiClient.JobStop(this.node, entity);
        }

        public Job Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Job> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
