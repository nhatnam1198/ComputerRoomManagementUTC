using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.RAM;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace InsideApi.Controllers
{
    public class RamController : Controller
    {
        private readonly IAppUrlHelper _appUrlHelper;
        public RamController(IAppUrlHelper appUrlHelper)
        {
            _appUrlHelper = appUrlHelper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> RamPaging(BaseCondition<RAM> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RAM>>(apiUrl, JsonConvert.SerializeObject(condition));
            ViewBag.PAGE_INDEX = condition.PAGE_INDEX;
            ViewBag.PAGE_SIZE = condition.PAGE_SIZE;
            return View(result);
        }

        /// <summary>
        /// Display add form view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(RAM ram)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RAM>>(apiUrl, JsonConvert.SerializeObject(ram));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(RamEditViewModel ram)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.RAM_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<RamEditViewModel>>(apiUrl, JsonConvert.SerializeObject(ram));
            return View();
        }
    }
}