using ScrapyWebNet.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScrapyWebNet.Logic
{
    public class ApiClient : IApiClient, IDisposable
    {
        private string apiUrl = String.Empty;

        const string ApiStatusPart = "daemonstatus.json";
        const string ApiProjectListPart = "listprojects.json";

        private WebClient webClientInstance = null;
        private WebClient webClient
        {
            get 
            { 
                if (this.webClientInstance == null)
                {
                    this.webClientInstance = new WebClient();
                }

                return this.webClientInstance;
            }
        }

        public string Url
        {
            get { return this.apiUrl; }
            set { this.apiUrl = value; }
        }

        public ApiListJobsResponse GetProjectJobs()
        {
            throw new NotImplementedException();
        }

        public ApiListProjectsResponse GetProjects()
        {
            ApiListProjectsResponse response = null;

            try
            {
                string jsonResponse = this.webClient.DownloadString(this.apiUrl + ApiProjectListPart);
                response = JsonSerializer.Deserialize<ApiListProjectsResponse>(jsonResponse);
            }
            catch (Exception e)
            {
                throw new ApiException(e.Message);
            }

            return response;
        }

        public ApiListSpidersResponse GetProjectSpiders(string projectName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Query API for daemon status including basic jobs counters
        /// </summary>
        /// <returns>daemon status informations or null, can throw ApiException</returns>
        public ApiStatusResponse GetStatus()
        {
            ApiStatusResponse response = null;

            try
            {
                string jsonResponse = this.webClient.DownloadString(this.apiUrl + ApiStatusPart);
                response = JsonSerializer.Deserialize<ApiStatusResponse>(jsonResponse);
            }
            catch (Exception e)
            {
                throw new ApiException(e.Message);
            }

            return response;
        }

        public void Dispose()
        {
            if (this.webClient != null)
            {
                this.webClient.Dispose();
            }
        }
    }
}
