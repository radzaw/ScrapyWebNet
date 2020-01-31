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

        public ScrapydAPI(IApiClient _apiClient)
        {
            this.apiClient = _apiClient;
        }

        public void GetStatus(Node node)
        {
            this.apiClient.Url = node.NodeUrl;

            ApiStatusResponse status = null;

            try
            {
                status = this.apiClient.GetStatus();
            }
            catch (ApiException)
            {
                node.Status = Node.NodeStatus.ConnectionError;
            }

            if (status == null)
            {
                return;
            }

            node.Pending = Convert.ToInt32(status.Pending);
            node.Running = Convert.ToInt32(status.Running);
            node.NodeName = status.NodeName;

            switch (status.Status)
            {
                case "Ok":
                    node.Status = Node.NodeStatus.OK;
                    break;
                default:
                    node.Status = Node.NodeStatus.Unknown;
                    break;
            }
        }
    }
}
