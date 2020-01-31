using ScrapyWebNet.Logic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public interface IUnitOfWork
    {
        NodeRepository Nodes { get; }
        JobRepository Jobs { get; }
        
        ProjectRepository Projects { get; }
    }
}
