using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_ASP_Git.Controllers
{
    public class IndexController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
