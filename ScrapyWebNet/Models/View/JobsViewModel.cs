using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models.View
{
    public class JobsViewModel
    {
        public Node Node { get; }
        public List<Job> Jobs { get; }

        public JobsViewModel(Node node, IEnumerable<Job> jobs)
        {
            if (jobs == null)
            {
                this.Jobs = new List<Job>();
            }
            else
            {
                this.Jobs = jobs.ToList();
            }
            
            this.Node = node;
        }
    }
}
