using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScrapyWebNet.Logic;
using ScrapyWebNet.Models;
using ScrapyWebNet.Models.View;

namespace ScrapyWebNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IUnitOfWork unitOfWork;
        private readonly IScrapydAPI scrapyApi;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IScrapydAPI scrapyApi)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
            this.scrapyApi = scrapyApi;
        }

        public IActionResult Index()
        {
            IEnumerable<Node> nodes = this.unitOfWork.Nodes.GetAll();
            Dictionary<string, List<Project>> projects = new Dictionary<string, List<Project>>();

            if (nodes != null)
            {
                foreach (Node node in nodes)
                {
                    // check status of the node
                    this.scrapyApi.NodeStatus(node);

                    // get projects on this node
                    this.unitOfWork.Projects.SetNode(node);
                    projects.Add(node.NodeId, this.unitOfWork.Projects.GetAll());
                }


            }

            IndexViewModel viewModel = new IndexViewModel(nodes, projects);

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
