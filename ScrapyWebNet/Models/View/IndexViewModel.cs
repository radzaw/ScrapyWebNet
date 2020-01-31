using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models.View
{
    public class IndexViewModel
    {
        public List<Node> Nodes { get; }
        public Dictionary<string, List<Project>> Projects { get; }

        public IndexViewModel(IEnumerable<Node> nodes, Dictionary<string, List<Project>> projects)
        {
            if (nodes == null)
            {
                // if we got null then initialize empty list
                this.Nodes = new List<Node>();
            }
            else
            {
                this.Nodes = nodes.ToList();
            }

            if (projects == null)
            {
                // if we got null then initialize empty list
                projects = new Dictionary<string, List<Project>>();
            }
            else
            {
                this.Projects = projects;
            }
        }
    }
}
