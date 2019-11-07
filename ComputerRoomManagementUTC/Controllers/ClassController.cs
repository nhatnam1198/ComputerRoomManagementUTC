using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.Class;
using ComputerRoomManagementUTC.Helper;
using ComputerRoomManagementUTC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComputerRoomManagementUTC.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private readonly IAppUrlHelper _appUrlHelper;
        private readonly UserSessionHelper _userSessionHelper;
        public ClassController(IAppUrlHelper appUrlHelper, UserSessionHelper userSessionHelper)
        {
            _appUrlHelper = appUrlHelper;
            _userSessionHelper = userSessionHelper;
        }

        [HttpGet]
        public async Task<ActionResult> ClassPaging(BaseCondition<Class> condition)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.CLASS_GET_PAGING);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Class>>(apiUrl, JsonConvert.SerializeObject(condition));
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
        public async Task<ActionResult> Add(AddClassViewModel model)
        {
            model.CreatedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_ADD);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Class>>(apiUrl, JsonConvert.SerializeObject(model));
            return Json(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_GET_ALL);
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Class>>(apiUrl);
            return Json(result);
        }

        /// <summary>
        /// Display edit form
        /// </summary>
        /// <pamodel name="id"></pamodel>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            string apiUrl = _appUrlHelper.GetApiUrl(string.Format(ApiUrlPath.MOUSE_GET_BY_ID, id));
            var result = await HttpUtilities.GetAsyncApi<ReturnResult<Class>>(apiUrl);
            return View(result.Item);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(ClassEditViewModel model)
        {
            model.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_EDIT);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<ClassEditViewModel>>(apiUrl, JsonConvert.SerializeObject(model));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(ClassDeleteViewModel model)
        {
            model.DeletedBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_DELETE);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Class>>(apiUrl, JsonConvert.SerializeObject(model));
            return Json(result);
        }

        [HttpPost]
        public async Task<ActionResult> EditStatus(ClassEditStatusViewModel model)
        {
            model.EditBy = _userSessionHelper.GetUserSession().UserName;
            string apiUrl = _appUrlHelper.GetApiUrl(ApiUrlPath.MOUSE_EDIT_STATUS);
            var result = await HttpUtilities.PostAsyncApi<ReturnResult<Class>>(apiUrl, JsonConvert.SerializeObject(model));
            return Json(result);
        }
    }
}