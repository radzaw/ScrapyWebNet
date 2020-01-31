using ScrapyWebNet.Logic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public interface IUnitOfWork
    {
        public NodeRepository Nodes { get; }
        public JobRepository Jobs { get; }
        //public ProjectRepository Projects { get; set; }
    }
}
