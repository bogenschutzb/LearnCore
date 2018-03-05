using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearnCore.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult ChartDashboard()
        {
            return View();
        }
    }
}