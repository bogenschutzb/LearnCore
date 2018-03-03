using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearnCore.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}