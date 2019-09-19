using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.RAM;
using Microsoft.AspNetCore.Mvc;

namespace InsideApi.Controllers
{
    public class RamController : Controller
    {
        public IActionResult Index()
        {
            //RamBusiness ramBusiness = new RamBusiness();
            //ReturnResult<RAM> result = ramBusiness.GetAll();
            return View();
        }

        public IActionResult RamPaging(BaseCondition<RAM> condition)
        {
            //RamBusiness ramBusiness = new RamBusiness();
            //var result = ramBusiness.GetAllRamSearched(condition);
            var ramList = result.ItemList;
            return View();
        }
    }
}