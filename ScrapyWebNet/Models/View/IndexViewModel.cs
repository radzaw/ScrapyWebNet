using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models.View
{
    public class IndexViewModel
    {
        public List<Node> Nodes = null;

        public IndexViewModel(IEnumerable<Node> nodes)
        {
            if (nodes != null)
            {
                this.Nodes = nodes.ToList();
            }
            else
            {
                this.Nodes = new List<Node>();
            }
        }
    }
}
