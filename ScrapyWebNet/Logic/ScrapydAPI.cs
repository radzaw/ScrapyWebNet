using Microsoft.Extensions.Logging;
using ScrapyWebNet.Models;
using ScrapyWebNet.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public class ScrapydAPI: IScrapydAPI
    {
        private IApiClient apiClient = null;
        private ILogger<ScrapydAPI> logger = null;

        private Node.NodeStatus ConvertStatus(string statusString)
        {
            switch (statusString)
            {
                case "ok":
                    return Node.NodeStatus.OK;
                default:
                    return Node.NodeStatus.Unknown;
            }
        }

        public ScrapydAPI(IApiClient apiClient, ILogger<ScrapydAPI> logger)
        {
            this.apiClient = apiClient;
            this.logger = logger;
        }

        public void JobStart(Node node, Project project, Job job)
        {
            throw new NotImplementedException();
        }

        public void JobStop(Node node, Job job)
        {
            throw new NotImplementedException();
        }

        public List<Project> ProjectList(Node node)
        {
            this.apiClient.Url = node.NodeUrl;

            List<Project> response = new List<Project>();

            try
            {
                ApiListProjectsResponse apiResponse = this.apiClient.GetProjects();
                foreach (string project in apiResponse.Projects)
                {
                    response.Add(new Project(project));
                }
            }
            catch (ApiException e)
            {
                this.logger.LogError(e, e.Message);
            }

            return response;
        }

        public List<Job> JobList(Node node, Project project)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets 
        /// </summary>
        /// <param name="node"></param>
        public void NodeStatus(Node node)
        {
            this.apiClient.Url = node.NodeUrl;

            ApiStatusResponse status = null;

            try
            {
                status = this.apiClient.GetStatus();
            }
            catch (ApiException e)
            {
                this.logger.LogError(e, e.Message);
                node.Status = Node.NodeStatus.ConnectionError;
            }

            if (status == null)
            {
                return;
            }

            node.Pending = status.Pending;
            node.Running = status.Running;
            node.NodeName = status.NodeName;

            
        }
    }
}
