using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestionBiblioteca.Controllers
{
    public class AdminController : Controller
    {  
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult BookEnterFrom()
        {
            return View();
        }
    }
}