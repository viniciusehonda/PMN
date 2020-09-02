using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PMN.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
