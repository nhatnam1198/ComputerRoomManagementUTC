using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputerRoomManagementUTC.Controllers
{
    public class CpuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}