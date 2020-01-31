using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    public class ProjectRepository : IApiRepository<Project>
    {
        private IScrapydAPI apiClient = null;
        private Node node = null;

        public ProjectRepository(IScrapydAPI apiClient)
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

        public void Add(Project entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Project entity)
        {
            throw new NotImplementedException();
        }

        public Project Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll()
        {
            return this.apiClient.ProjectList(this.node);
        }

    }
}
