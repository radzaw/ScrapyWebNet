using ScrapyWebNet.Models;
using ScrapyWebNet.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic.Repository
{
    public class NodeRepository : IDbRepository<Node>
    {
        private DatabaseContext dbContext = null;

        public NodeRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Node entity)
        {
            this.dbContext.Nodes.Add(entity);
        }

        public void Delete(Node entity)
        {
            this.dbContext.Nodes.Remove(entity);
        }

        public Node Get(string id)
        {
            return this.dbContext.Nodes.FirstOrDefault(n => n.NodeId == id);
        }

        public IEnumerable<Node> GetAll()
        {
            return this.dbContext.Nodes;
        }
    }
}
