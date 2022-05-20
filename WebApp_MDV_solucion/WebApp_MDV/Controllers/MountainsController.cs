using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_MDV.Controllers
{
    public class MountainsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
