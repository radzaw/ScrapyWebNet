using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public interface IScrapydAPI
    {
        void JobStart(Node node, Project project, Job job);

        void JobStop(Node node, Job job);

        List<Job> JobList(Node node, Project project);

        List<Project> ProjectList(Node node);

        void NodeStatus(Node node);
    }
}
