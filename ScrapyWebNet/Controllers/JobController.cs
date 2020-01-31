using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScrapyWebNet.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Controllers
{
    public class JobController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly UnitOfWork unitOfWork;

        public JobController(ILogger<HomeController> _logger, IUnitOfWork _unitOfWork)
        {
            this.logger = _logger;
            this.unitOfWork = (UnitOfWork)_unitOfWork;
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
