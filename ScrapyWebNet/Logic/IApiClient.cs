﻿using ScrapyWebNet.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public interface IApiClient
    {
        ApiStatusResponse GetStatus();
        ApiListProjectsResponse GetProjectsList();
        ApiListSpidersResponse GetProjectSpiders(string projectName);

        ApiListJobsResponse GetProjectJobs(string projectName);
    }
}
