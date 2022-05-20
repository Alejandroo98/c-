using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_MDV.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar( int numUno, int numDos )
        {
            ViewData["resultado"] = numUno + numDos;
            //int numUno = int.Parse(Request.Form["numUno"]);
            return View();
        }
    }
}
