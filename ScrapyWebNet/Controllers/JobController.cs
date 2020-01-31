using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScrapyWebNet.Logic;
using ScrapyWebNet.Models;
using ScrapyWebNet.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Controllers
{
    public class JobController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IUnitOfWork unitOfWork;

        public JobController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            this.logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public IActionResult List([FromQuery] string nodeId)
        {
            Node node = this.unitOfWork.Nodes.Get(nodeId);
            if (node == null)
            {
                return RedirectToAction("Index", "Home");
            }

            this.unitOfWork.Jobs.SetNode(node);
            IEnumerable<Job> jobs = this.unitOfWork.Jobs.GetAll();

            JobsViewModel viewModel = new JobsViewModel(node, jobs);

            return View(viewModel);
        }

        public IActionResult Start()
        {
            return Ok();
        }

        public IActionResult Stop()
        {
            return Ok();
        }

    }
}
