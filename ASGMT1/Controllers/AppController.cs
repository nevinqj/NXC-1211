using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASGMT1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASGMT1.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AppViewModel form)
        {
            ViewBag.UserOutput = form.UserInput;
            return View();
        }
    }
}
