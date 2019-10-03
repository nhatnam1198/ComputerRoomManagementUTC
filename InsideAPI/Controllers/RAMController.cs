using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Common;
using Common.Entity.Models.RAM;
using InsideAPI.BUS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsideAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RAMController : ControllerBase
    {
        public IActionResult GetPaging(BaseCondition<RAM> condition)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.GetAllRamSearched(condition);
            return Ok(result);
        }

        public IActionResult Add(RAM ram)
        {
            RamBusiness ramBusiness = new RamBusiness();
            var result = ramBusiness.AddRam(ram);
            return Ok(result);
        }
    }
}