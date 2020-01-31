using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScrapyWebNet.Logic;
using ScrapyWebNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Controllers
{
    public class NodeController : Controller, IDisposable
    {
        private readonly ILogger<HomeController> logger = null;
        private readonly UnitOfWork unitOfWork = null;

        public NodeController(ILogger<HomeController> _logger, IUnitOfWork _unitOfWork)
        {
            this.logger = _logger;
            this.unitOfWork = (UnitOfWork)_unitOfWork;
        }

        [HttpPost]
        public IActionResult AddNode([FromForm] string url)
        {
            Node node = new Node();
            node.NodeUrl = url;
            node.NodeId = Guid.NewGuid().ToString();

            this.unitOfWork.Nodes.Add(node);
            this.unitOfWork.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DelNode(string id)
        {
            Node node = this.unitOfWork.Nodes.Get(id);
            if (node != null)
            {
                this.unitOfWork.Nodes.Delete(node);
                this.unitOfWork.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
