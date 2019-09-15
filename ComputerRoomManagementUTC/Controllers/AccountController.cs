using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using ComputerRoomManagement.Models.Account;
using ComputerRoomManagementUTC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
             AccountService loginService = new AccountService();
            if (loginService.IsAuthenticate(login))
            {
                var token = loginService.CreateToken();
                
                 HttpContext.Request.Headers.Add("Authorizaion", "Bearer " + token);
                ViewBag.Token = token;
                var a = Url.Action("Index", "Home");
                return View("PreLoader");
            }
            else
            {
                return Unauthorized();
            }
        }

        //public IActionResult Login(Account account)
        //{
        //    return View();
        //}
    }
}