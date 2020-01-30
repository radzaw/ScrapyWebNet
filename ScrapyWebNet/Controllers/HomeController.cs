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
        private readonly UnitOfWork uow;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork uow)
        {
            this.logger = logger;
            this.uow = (UnitOfWork)uow;
        }

        public IActionResult Index()
        {
            IEnumerable<Node> nodes = this.uow.Nodes.GetMany(n => n.Active == 1);

            IndexViewModel viewModel = new IndexViewModel(nodes);

            return View(viewModel);
        }

        public IActionResult Privacy()
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
