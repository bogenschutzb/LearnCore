using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnCore.CommonLibrary.Users;
using Microsoft.AspNetCore.Mvc;

namespace LearnCore.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public IActionResult UserDashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UserDetailsView()
        {
            var users = _userManager.GetAllUsers().Result.Select(x => new Models.User() { Id = x.Id, Name = x.Name, EmailAddress = x.EmailAddress });

            return PartialView("_UserDetails", users);
        }
    }
}