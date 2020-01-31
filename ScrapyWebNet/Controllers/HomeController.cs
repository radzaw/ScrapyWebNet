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

        public HomeController(ILogger<HomeController> _logger, IUnitOfWork _unitOfWork, IScrapydAPI _scrapyApi)
        {
            this.logger = _logger;
            this.unitOfWork = _unitOfWork;
            this.scrapyApi = _scrapyApi;
        }

        public IActionResult Index()
        {
            IEnumerable<Node> nodes = this.unitOfWork.Nodes.GetAll();

            if (nodes != null)
            {
                // check status of all nodes
                foreach (Node node in nodes)
                {
                    this.scrapyApi.GetStatus(node);
                }
            }

            IndexViewModel viewModel = new IndexViewModel(nodes);

            return View(viewModel);
        }

        public IActionResult Jobs([FromQuery] string nodeName)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
