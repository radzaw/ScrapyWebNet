using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    public class NodeRepository : IRepository<Node>
    {
        public NodeRepository()
        {

        }

        public void Add(Node entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Node entity)
        {
            throw new NotImplementedException();
        }

        public Node Get(Func<Node, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Node> GetMany(Func<Node, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
