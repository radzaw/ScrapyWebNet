using ScrapyWebNet.Logic.Repository;
using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private IScrapydAPI apiClient = null;
        private DatabaseContext dbContext = null;
        private bool disposed = false;

        private NodeRepository nodeRepository = null;
        public NodeRepository Nodes
        {
            get
            {
                if (this.nodeRepository == null)
                {
                    this.nodeRepository = new NodeRepository(this.dbContext);
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

        public UnitOfWork(IScrapydAPI apiClient, DatabaseContext _dbContext)
        {
            this.apiClient = apiClient;
            this.dbContext = _dbContext;
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }

        #region Handle objects disposal
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.dbContext.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
