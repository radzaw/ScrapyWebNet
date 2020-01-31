using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScrapyWebNet.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Controllers
{
    public class ProjectController: Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IUnitOfWork unitOfWork;
        private readonly IScrapydAPI scrapyApi;

        public ProjectController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IScrapydAPI scrapyApi)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
            this.scrapyApi = scrapyApi;
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
