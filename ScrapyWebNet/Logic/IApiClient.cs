using ScrapyWebNet.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public interface IApiClient
    {
        string Url {get;set;}

        ApiStatusResponse GetStatus();
        ApiListProjectsResponse GetProjects();
        ApiListSpidersResponse GetProjectSpiders(string projectName);

        ApiListJobsResponse GetProjectJobs();
    }
}
