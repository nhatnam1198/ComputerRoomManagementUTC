﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerRoomManagementUTC.Models;
using ComputerRoomManagement.BUS;

namespace ComputerRoomManagementUTC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // if (!User.IsLogged())
            return Redirect(Url.Action("Login", "Account"));
            // else return dashboard
            RamBusiness ramBusiness = new RamBusiness();
            var a = ramBusiness.GetAll();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
