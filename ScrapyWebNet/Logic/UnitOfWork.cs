using ScrapyWebNet.Logic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public class UnitOfWork: IUnitOfWork
    {
        private IApiClient apiClient = null;

        private NodeRepository nodeRepository = null;
        public NodeRepository Nodes
        {
            get
            {
                if (this.nodeRepository == null)
                {
                    this.nodeRepository = new NodeRepository();
                }

                return this.nodeRepository;
            }
        }

        private JobRepository jobRepository = null;
        public JobRepository Jobs
        {
            get
            {
                if (this.jobRepository == null)
                {
                    this.jobRepository = new JobRepository(this.apiClient);
                }

                return this.jobRepository;
            }
        }

        public UnitOfWork(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }
    }
}
