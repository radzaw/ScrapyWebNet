using ScrapyWebNet.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public class ApiClient : IApiClient
    {
        private string apiUrl = String.Empty;

        public string Url
        {
            get { return this.apiUrl; }
            set { this.apiUrl = value; }
        }

        public ApiListJobsResponse GetProjectJobs(string projectName)
        {
            throw new NotImplementedException();
        }

        public ApiListProjectsResponse GetProjectsList()
        {
            throw new NotImplementedException();
        }

        public ApiListSpidersResponse GetProjectSpiders(string projectName)
        {
            throw new NotImplementedException();
        }

        public ApiStatusResponse GetStatus()
        {
            //throw new NotImplementedException();
            return new ApiStatusResponse();
        }
    }
}
