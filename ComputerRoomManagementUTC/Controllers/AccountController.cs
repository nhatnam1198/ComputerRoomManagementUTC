using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using ComputerRoomManagement.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace ComputerRoomManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        public IActionResult Login(Login login)
        {
            var a = login;
            return Json(login);
        }

        //public IActionResult Login(Account account)
        //{
        //    return View();
        //}
    }
}